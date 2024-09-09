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

namespace Project.DAL
{
    public class CustomerRepository : IGenericRepository<customer>
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<customer> _dbSet;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            _dbSet = dbContext.Set<customer>();
        }

        public IActionResult Get()
        {
            var customers = _dbSet.ToList();
            return new OkObjectResult(customers);
        }

        public IActionResult GetById(int id)
        {
            var customer = _dbSet.Find(id);
            if (customer == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(customer);
        }

        public IActionResult Add(customer entity)
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
            entity.cust_id = newCustId;

            // Diğer alanları da entity'ye ata
            entity.cust_code = entity.cust_code ?? "DefaultCode"; // Varsayılan değerler ekleyebilirsiniz
            entity.cust_desc = entity.cust_desc ?? "DefaultDesc";
            entity.cust_adress = entity.cust_adress ?? "DefaultAddress";
            entity.cust_country = entity.cust_country ?? "DefaultCountry";
            entity.cust_city = entity.cust_city ?? "DefaultCity";
            entity.cust_phone = entity.cust_phone ?? "DefaultPhone";
            entity.cust_status = entity.cust_status ?? false;

            // customer kaydını ekle
            _dbSet.Add(entity);

            // Değişiklikleri kaydet
            dbContext.SaveChanges();
            Console.WriteLine($"Added customer with ID: {entity.cust_id}");

            // İşlemi başarılı bir şekilde bitir
            transaction.Commit();

            return new OkObjectResult(entity);
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
            return new StatusCodeResult(500);
        }
    }
}


        public IActionResult Update(int id, customer entity)
        {
            var existingCustomer = _dbSet.Find(id);
            if (existingCustomer == null)
            {
                return new NotFoundResult();
            }

            // Güncellenmiş verileri mevcut customer'a ata
            existingCustomer.cust_code = entity.cust_code;
            existingCustomer.cust_desc = entity.cust_desc;
            existingCustomer.cust_adress = entity.cust_adress;
            existingCustomer.cust_country = entity.cust_country;
            existingCustomer.cust_city = entity.cust_city;
            existingCustomer.cust_phone = entity.cust_phone;
            existingCustomer.cust_status = entity.cust_status;

            _dbSet.Update(existingCustomer);
            dbContext.SaveChanges();
            return new OkObjectResult(existingCustomer);
        }

        public IActionResult Delete(int id)
        {
            var customer1 = _dbSet.Find(id);
            if (customer1 == null)
            {
                return new NotFoundResult();
            }
            _dbSet.Remove(customer1);
            dbContext.SaveChanges();
            return new NoContentResult();
        }
    }
}
