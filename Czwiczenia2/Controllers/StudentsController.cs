using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Czwiczenia2.DAL;
using Czwiczenia2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Czwiczenia2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
    }
}