using Microsoft.AspNetCore.Mvc;
using Project.BLL.Services;
using Project.ENTITIES.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService customerService;
        public CustomerController(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = customerService.Get();
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = customerService.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(customer entity)
        {

            var result = customerService.Add(entity);
            return result;
        }





        [HttpPut("{id:int}")]
        public IActionResult Update(int id, customer entity)
        {

            var result = customerService.Update(id, entity);
            return Ok(result);

        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = customerService.Delete(id);
            return Ok(result);
        }

    }
}
