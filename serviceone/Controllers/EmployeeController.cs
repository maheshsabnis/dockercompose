using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using serviceone.Models;

namespace serviceone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeDb database;

        public EmployeeController()
        {
            database = new EmployeeDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(database);
        }
    }
}