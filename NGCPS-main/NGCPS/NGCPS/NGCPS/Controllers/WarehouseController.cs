using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGCPS.Data;
using NGCPS.Models.AddDto;
using NGCPS.Models.UpdateDto;
using NGCPS.Models.Entities;
using System.Globalization;
using Microsoft.EntityFrameworkCore; // Import CultureInfo

namespace HandTerminalProjectBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public WarehouseController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.warehouse.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var warehouseEntity = dbContext.warehouse.Find(id);
            if (warehouseEntity == null)
            {
                return NotFound();
            }
            return Ok(warehouseEntity);
        }

        [HttpPost]
        public IActionResult Add(AddWarehouseDto addWarehouseDto)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    // warehousesq tablosundaki lastref_id değerini al
                    var lastRefId = dbContext.warehousesq
                        .Select(c => c.lastref_id)
                        .FirstOrDefault() ?? 0;

                    var newWarId = lastRefId + 1;

                    // lastref_id değerini warehousesq tablosunda güncelle
                    dbContext.Database.ExecuteSqlRaw(
                        "UPDATE warehousesq SET lastref_id = {0}", newWarId);

                    Console.WriteLine($"Updated lastref_id to: {newWarId}");

                    // Güncellenmiş lastref_id değerini kullanarak warehouse kaydını oluştur
                    var warehouseEntity = new warehouse()
                    {
                        ware_id = newWarId,
                        ware_code = addWarehouseDto.ware_code,
                        ware_desc = addWarehouseDto.ware_desc,
                        ware_status = addWarehouseDto.ware_status,
                    };

                    // warehouse kaydını ekle
                    dbContext.warehouse.Add(warehouseEntity);

                    // Değişiklikleri kaydet
                    dbContext.SaveChanges();
                    Console.WriteLine($"Added warehouse with ID: {warehouseEntity.ware_id}");

                    // İşlemi başarılı bir şekilde bitir
                    transaction.Commit();

                    return Ok(warehouseEntity);
                }
                catch (Exception ex)
                {
                    // İşlemi geri al
                    transaction.Rollback();

                    // Hata mesajlarını döndür
                    var errorMessage = $"Error: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        errorMessage += $" InnerException: {ex.InnerException.Message}";
                    }

                    Console.WriteLine(errorMessage);
                    return StatusCode(500, errorMessage);
                }
            }
        }


        [HttpPut("{id:int}")]
        public IActionResult Update(int id, UpdateWarehouseDto updateWarehouseDto)
        {
            var warehouseEntity = dbContext.warehouse.Find(id);
            if (warehouseEntity == null)
            {
                return NotFound();
            }
            warehouseEntity.ware_code = updateWarehouseDto.ware_code;
            warehouseEntity.ware_desc = updateWarehouseDto.ware_desc;
            dbContext.SaveChanges();
            return Ok(warehouseEntity);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var warehouseEntity = dbContext.warehouse.Find(id);
            if (warehouseEntity == null)
            {
                return NotFound();
            }
            dbContext.warehouse.Remove(warehouseEntity);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
