using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.BLL.Interface;
using Project.DAL.Data;
using Project.ENTITIES.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Project.DAL
{
    public class QualityRepository : IGenericRepository<cw_000_quality>
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<cw_000_quality> _dbSet;

        public QualityRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            _dbSet = dbContext.Set<cw_000_quality>();
        }

        // Tüm quality kayıtlarını getirir
        public IActionResult Get()
        {
            var qualities = _dbSet.ToList();
            return new OkObjectResult(qualities);
        }

        // ID'ye göre quality kaydını getirir
        public IActionResult GetById(int id)
        {
            var quality = _dbSet.Find(id);
            if (quality == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(quality);
        }

        // Yeni quality ekler
        public IActionResult Add(cw_000_quality entity)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Console.WriteLine("Add start ");
                    var lastRefId = dbContext.cw_000_qualityseq.Select(c => c.lastref).FirstOrDefault() ?? 0;
                    var newQualiyId = lastRefId + 1;

                    // `qualitysq` tablosundan `lastref_id` almayı bırakıyoruz.
                    // `quality` tablosunda doğrudan bir ekleme işlemi yapıyoruz.
                    dbContext.Database.ExecuteSqlRaw("UPDATE cw_000_qualityseq SET lastref = {0}", newQualiyId);
                    // Diğer alanları da entity'ye ata
                    
                    Console.WriteLine("Add start ....");
                    
                    entity.qty_referans = newQualiyId;   
                    
                    entity.qty_kodu = entity.qty_kodu ?? "DefaultKode";
                    entity.qty_desc = entity.qty_desc ?? "DefaultDesc";
                    entity.qty_tickodu = entity.qty_tickodu ?? "DefaultTickCode";
                    entity.qty_ticname = entity.qty_ticname ?? "Defaultticname";
                    entity.qty_status = entity.qty_status;


                    Console.WriteLine("Add start  ???? ");
                    // quality kaydını ekle
                    _dbSet.Add(entity);

                    // Değişiklikleri kaydet
                    dbContext.SaveChanges();
                    Console.WriteLine($"Added quality with ID: {entity.qty_referans}");
                    Console.WriteLine("Add  &&&& ");
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


        // Mevcut quality kaydını günceller
        public IActionResult Update(int id,cw_000_quality entity)
        {
            var existingQuality = _dbSet.Find(id);
            if (existingQuality == null)
            {
                return new NotFoundResult();
            }

            // Güncellenmiş verileri mevcut quality kaydına ata
            existingQuality.qty_kodu = entity.qty_kodu;
            existingQuality.qty_desc = entity.qty_desc;
            existingQuality.qty_tickodu = entity.qty_tickodu;
            
            existingQuality.qty_ticname = entity.qty_ticname;
            existingQuality.qty_status = entity.qty_status;

            _dbSet.Update(existingQuality);
            dbContext.SaveChanges();
            return new OkObjectResult(existingQuality);
        }

        // quality kaydını siler
        public IActionResult Delete(int id)
        {
            var quality = _dbSet.FirstOrDefault(q => q.qty_referans == id);

            // Kayıt bulunamazsa hata döndür
            if (quality == null)
            {
                return new NotFoundResult();
            }

            _dbSet.Remove(quality);
            dbContext.SaveChanges();
            return new NoContentResult();
        }
    }
}
