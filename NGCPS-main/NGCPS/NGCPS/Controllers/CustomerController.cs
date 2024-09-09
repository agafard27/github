using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGCPS.Data;
using NGCPS.Models.AddDto;
using NGCPS.Models.UpdateDto;
using NGCPS.Models.Entities;
using System.Globalization;
using Microsoft.EntityFrameworkCore; // Import CultureInfo
namespace NGCPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.customer.ToList());
        }
        [HttpGet("{id:int}")] 
        public IActionResult GetById(int id)
        {
            var customer = dbContext.customer.Find(id);
            return Ok(customer);
        }
        [HttpPost]
        public IActionResult Add(AddCustomerDto addCustomerDto)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    // customersq tablosundaki lastref_id değerini al
                    var lastRefId = dbContext.customersq
                        .Select(c => c.lastref_id)
                        .FirstOrDefault() ?? 0;

                    var newCustId = lastRefId + 1;

                    // lastref_id değerini güncelle
                    dbContext.Database.ExecuteSqlRaw(
                        "UPDATE customersq SET lastref_id = {0}", newCustId);

                    Console.WriteLine($"Updated lastref_id to: {newCustId}");

                    // Güncellenmiş lastref_id değerini kullanarak customer kaydını oluştur
                    var customerEntity = new customer()
                    {
                        cust_id = newCustId,
                        cust_code = addCustomerDto.cust_code,
                        cust_desc = addCustomerDto.cust_desc,
                        cust_adress = addCustomerDto.cust_adress,
                        cust_country = addCustomerDto.cust_country,
                        cust_city = addCustomerDto.cust_city,
                        cust_phone = addCustomerDto.cust_phone,
                        cust_status = addCustomerDto.cust_status,
                    };

                    // customer kaydını ekle
                    dbContext.customer.Add(customerEntity);

                    // Değişiklikleri kaydet
                    dbContext.SaveChanges();
                    Console.WriteLine($"Added customer with ID: {customerEntity.cust_id}");

                    // İşlemi başarılı bir şekilde bitir
                    transaction.Commit();

                    return Ok(customerEntity);
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
        public IActionResult Update(int id, UpdateCustomerDto updateCustomerDto)
        {
            var customerEntity = dbContext.customer.Find(id);
            if (customerEntity == null)
            {
                return NotFound();
            }
            customerEntity.cust_code = updateCustomerDto.cust_code;
            customerEntity.cust_desc = updateCustomerDto.cust_desc;
            customerEntity.cust_adress = updateCustomerDto.cust_adress;
            customerEntity.cust_country = updateCustomerDto.cust_country;
            customerEntity.cust_city = updateCustomerDto.cust_city;
            customerEntity.cust_phone = updateCustomerDto.cust_phone;
            customerEntity.cust_status = updateCustomerDto.cust_status;
            dbContext.SaveChanges();
            return Ok(customerEntity);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var customerEntity = dbContext.customer.Find(id);
            if (customerEntity == null)
            {
                return NotFound();
            }
            dbContext.customer.Remove(customerEntity);
            dbContext.SaveChanges();
            return Ok();
        }

    }
}
