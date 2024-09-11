using Microsoft.AspNetCore.Mvc;
using Project.BLL.Services;
using Project.ENTITIES.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly WarehouseService warehouseService;

        public WarehouseController(WarehouseService warehouseService)
        {
            this.warehouseService = warehouseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = warehouseService.Get();
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = warehouseService.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(warehouse entity)
        {

            var result = warehouseService.Add(entity);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, warehouse entity)
        {
            var result = warehouseService.Update(id, entity);
            return Ok(result);
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = warehouseService.Delete(id);
            return Ok(result);
        }



    }
}
