using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCore;
using WebData;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public GenericRepository<Employee> emp;
        public EmployeeController(EmployeeDB employeeDB)
        {
            emp = new GenericRepository<Employee>(employeeDB);
        }

        [HttpGet("GetAll")]
        public IEnumerable<Employee> GetAll()
        {
            return emp.GetAll();
        }
        [HttpGet("GetByID")]
        public Employee GetByID(int ID)
        {
            return emp.GetByID(ID);
        }

        [HttpPost("Create")]
        public void Create(Employee employee)
        {
            emp.Create(employee);
            emp.Save();
        }

        [HttpPost]
        public void Update(Employee employee)
        {
            emp.Update(employee);
            emp.Save();
        }
    }
}