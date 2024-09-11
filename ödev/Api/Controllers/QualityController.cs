using Microsoft.AspNetCore.Mvc;
using Project.BLL.Services;
using Project.ENTITIES.Models;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualityController : ControllerBase
    {
        private readonly QualityService _qualityService;

        public QualityController(QualityService qualityService)
        {
            _qualityService = qualityService;
        }

        // GET: api/quality
        [HttpGet]
        public IActionResult Get()
        {
            var result = _qualityService.Get();
            
            return Ok(result);
        }

        // GET: api/quality/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _qualityService.GetById(id);
            return Ok(result);
        }

        // POST: api/quality
        [HttpPost]
        public IActionResult Post( cw_000_quality quality)
        {

            var result = _qualityService.Add(quality);
           
            return Ok(result);  // Başarılı dönüş
        }

        // PUT: api/quality/5
        [HttpPut("{id:int}")]
        public IActionResult Update(int id,cw_000_quality quality)
        {
           

            var result = _qualityService.Update(id, quality);
            
            return Ok(result);  // Başarılı güncelleme
        }

        // DELETE: api/quality/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _qualityService.Delete(id);
           
            return Ok(result);  // Başarılı silme işlemi
        }
    }
}
