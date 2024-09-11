using Microsoft.AspNetCore.Mvc;
using Project.DAL.Repository;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Services
{
    public class WarehouseService : ControllerBase
    {
        private readonly WarehouseRepository warehouseRepository;
        public WarehouseService(WarehouseRepository warehouseRepository)
        {
            this.warehouseRepository = warehouseRepository;
        }

        public IActionResult Get()
        {
            var result = warehouseRepository.Get();
            return Ok(result);
        }

        public IActionResult GetById(int id)
        {
            var result = warehouseRepository.GetById(id);
            return Ok(result);
        }

        public IActionResult Add(warehouse entity)
        {

            var result = warehouseRepository.Add(entity);
            return Ok(result);
        }


        public IActionResult Update(int id, warehouse warehouse)
        {
            var result = warehouseRepository.Update(id, warehouse);
            return Ok(result);
        }

        public IActionResult Delete(int id)
        {
            var result = warehouseRepository.Delete(id);
            return Ok(result);
        }

    }
}
