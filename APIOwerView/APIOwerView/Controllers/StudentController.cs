using APIOwerView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIOwerView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> students = new List<Student>

            {
                new Student {Id=1, Name="Burak", LastName="Bayar", Adress="Bursa"},
                new Student {Id=2, Name="Can", LastName="Bayar", Adress="Bursa"},
                new Student {Id=3, Name="İlknur", LastName="Mert", Adress="Rize"}
            };

        //1. Tüm öğrencileri döndürür
        [HttpGet]
        public IActionResult GetStudents()
        {

           

            return Ok(students);
        }

        [HttpGet("id/{ogrId}")]
        public IActionResult GetStudent(int ogrId)
        {

            var student = students.FirstOrDefault(stu => stu.Id == ogrId);
           
            if (student==null)
            {
                return NotFound();
            }
            return Ok(student);
            //return Ok();
            

        }

        [HttpGet("city/{city}")]
        public IActionResult GetStudentsByCity(string city)
        {
            var findingStundets = students.Where(x => x.Adress.Contains(city));
            if (findingStundets==null)
            {
                return NotFound();
            }
            return Ok(findingStundets);
        }
    }
}
