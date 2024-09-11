using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.BLL.Interface;
using Project.DAL.Data;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.DAL.Repository
{
    public class WarehouseRepository : IGenericRepository<warehouse>
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<warehouse> _dbSet;

        public WarehouseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            _dbSet = dbContext.Set<warehouse>();
        }

        public IActionResult Get()
        {
            var warehouses = _dbSet.ToList();
            return new OkObjectResult(warehouses);
        }

        public IActionResult GetById(int id)
        {
            var warehouse = _dbSet.Find(id);
            if (warehouse == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(warehouse);
        }

        public IActionResult Add(warehouse entity)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    var lastRefId = dbContext.warehousesq
                        .Select(c => c.lastref_id)
                        .FirstOrDefault() ?? 0;

                    var newWarId = lastRefId + 1;

                    dbContext.Database.ExecuteSqlRaw(
                        "UPDATE warehousesq SET lastref_id = {0}", newWarId);

                    Console.WriteLine($"Updated lastref_id to: {newWarId}");

                    entity.ware_id = newWarId;
                    entity.ware_code = entity.ware_code ?? "DefaultCode";
                    entity.ware_desc = entity.ware_desc ?? "DefaultDesc";
                    entity.ware_status = entity.ware_status;

                    _dbSet.Add(entity);
                    dbContext.SaveChanges();

                    Console.WriteLine($"Added warehouse with ID: {entity.ware_id}");
                    transaction.Commit();

                    return new OkObjectResult(entity);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    var errorMessage = $"Error: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        errorMessage += $" InnerException: {ex.InnerException.Message}";
                    }

                    Console.WriteLine(errorMessage);
                    return new StatusCodeResult(500);
                }
            }
        }

        public IActionResult Update(int id, warehouse entity)
        {
            var existingWarehouse = _dbSet.Find(id);
            if (existingWarehouse == null)
            {
                return new NotFoundResult();
            }

            existingWarehouse.ware_code = entity.ware_code;
            existingWarehouse.ware_desc = entity.ware_desc;
            existingWarehouse.ware_status = entity.ware_status;

            _dbSet.Update(existingWarehouse);
            dbContext.SaveChanges();

            return new OkObjectResult(existingWarehouse);
        }

        public IActionResult Delete(int id)
        {
            var warehouse = _dbSet.Find(id);
            if (warehouse == null)
            {
                return new NotFoundResult();
            }

            _dbSet.Remove(warehouse);
            dbContext.SaveChanges();

            return new NoContentResult();
        }
    }
}
