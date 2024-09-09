using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.BLL.Interface;
using Project.DAL.Data;
using Project.ENTITIES.Models.quality;
using System;
using System.Linq;

namespace Project.DAL.Repository
{
    public class QualityRepository : IGenericRepository<quality>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<quality> _dbSet;

        public QualityRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<quality>();
        }

        // Get all Quality records
        public IActionResult Get()
        {
            var qualities = _dbSet.ToList();
            return new OkObjectResult(qualities);
        }

        // Get a Quality record by ID
        public IActionResult GetById(int id)
        {
            var quality = _dbSet.Find(id);
            if (quality == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(quality);
        }

        // Add a new Quality record
        public IActionResult Add(quality entity)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbSet.Add(entity);
                    _dbContext.SaveChanges();
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
                    return new StatusCodeResult(500);
                }
            }
        }

        // Update an existing Quality record
        public IActionResult Update(int id, quality entity)
        {
            var existingQuality = _dbSet.Find(id);
            if (existingQuality == null)
            {
                return new NotFoundResult();
            }

            existingQuality.qlty_code = entity.qlty_code;
            existingQuality.qlty_desc = entity.qlty_desc;
            existingQuality.qlty_tradingname = entity.qlty_tradingname;
            existingQuality.qlty_reed = entity.qlty_reed;
            existingQuality.qlty_density = entity.qlty_density;
            existingQuality.qlty_status = entity.qlty_status;

            _dbSet.Update(existingQuality);
            _dbContext.SaveChanges();
            return new OkObjectResult(existingQuality);
        }

        // Delete a Quality record
        public IActionResult Delete(int id)
        {
            var quality = _dbSet.Find(id);
            if (quality == null)
            {
                return new NotFoundResult();
            }

            _dbSet.Remove(quality);
            _dbContext.SaveChanges();
            return new NoContentResult();
        }
    }
}
