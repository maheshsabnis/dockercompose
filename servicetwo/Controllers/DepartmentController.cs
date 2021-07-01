using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servicetwo.Models;
namespace servicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentsDb database;
        public DepartmentController()
        {
            database = new DepartmentsDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(database);
        }
    }
}