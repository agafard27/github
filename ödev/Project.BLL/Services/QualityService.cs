using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interface;
using Project.DAL;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.BLL.Services
{
    public class QualityService : IGenericRepository<cw_000_quality>
    {
        private readonly QualityRepository qualityRepository;

        public QualityService(QualityRepository qualityRepository)
        {
            this.qualityRepository = qualityRepository;
        }

        public IActionResult Add(cw_000_quality entity)
        {
           var result = qualityRepository.Add(entity);
            return result;
        }

        public IActionResult Delete(int id)
        {
           var result=qualityRepository.Delete(id);
            return new OkObjectResult(result);
        }

        [HttpGet]
        public IActionResult Get()
        {

            var result = qualityRepository.Get();
            return new OkObjectResult(result);
            


        }

        public IActionResult GetById(int id)
        {
            var result=qualityRepository.GetById(id);
            return new OkObjectResult(result);
        }

        public IActionResult Update(int id, cw_000_quality entity)
        {
            var result= qualityRepository.Update(id, entity);
            return new OkObjectResult(result);
        }
    }
}
