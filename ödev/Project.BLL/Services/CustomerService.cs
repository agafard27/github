using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interface;
using Project.DAL;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Services
{
    public class CustomerService : IGenericRepository<customer>
    {
        private readonly CustomerRepository customerRepository;
        public CustomerService(CustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;


        }


        public IActionResult Get()
        {
            var result = customerRepository.Get();
            return new OkObjectResult(result);
        }

        public IActionResult GetById(int id)
        {
            var result = customerRepository.GetById(id);
            return new OkObjectResult(result);
        }
        public IActionResult Add(customer entity)
        {

            var result = customerRepository.Add(entity);
            return result;
        }





        public IActionResult Update(int id, customer entity)
        {

            var result = customerRepository.Update(id, entity);
            return new OkObjectResult(result);

        }

        public IActionResult Delete(int id)
        {
            var result = customerRepository.Delete(id);
            return new OkObjectResult(result);
        }


    }
}
