using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        public IActionResult Get();
        public IActionResult GetById(int id);

        public IActionResult Add(T entity);

        public IActionResult Update(int id, T entity);
        public IActionResult Delete(int id);

    }
}
