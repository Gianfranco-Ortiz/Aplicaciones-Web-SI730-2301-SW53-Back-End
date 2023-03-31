using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private static List<Student> _students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Carlos" },
            new Student() { Id = 2, Name = "Rubi" },
            new Student() { Id = 3, Name = "Blanca" },
            new Student() { Id = 4, Name = "Miguel" },
        };

    // GET: api/Student
        [HttpGet(Name = "GetStudent")]
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _students.Where(s => s.Id == id).First();
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                if (student.Name == "") // Error Client
                {
                    return StatusCode(400);
                }
                else // Existoso
                {
                    
                    //Conecta y graba
                    throw new Exception("Error de base de datos");
                    return StatusCode(201);
                }
            }
            catch (Exception e) //Erro de servidor
            {
                //Loggear error
                return StatusCode(500);
            }
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] string value )
        {
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
