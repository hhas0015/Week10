using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week10.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ApplicationDb _context;

        public StudentController(ApplicationDb context)
        {
            _context = context;

            if (_context.studentList.Count() == 0)
            {
                for ( int i = 0;i < 5; i++)
                {
                    _context.studentList.Add( GetAllStudent() );
                    _context.SaveChanges();

                }
               
                
            }
        }

        String[] studentNames = { "Harsha","Adam","Paul","Milanda","Judie","Ayesha" };
        int[] studentAge = { 23, 65, 23, 43, 32, 42, 19, 46, 67 };
 
        [HttpGet]
        public List<Student> Get()
        {
            List<Student> studentList = new List<Student> { };

            studentList = _context.studentList.ToList();

            return studentList;
        }


        [HttpPost]
        public void Post(Student student)
        {
            _context.studentList.Add(student);
            _context.SaveChanges();

        }

        public Student GetAllStudent()
        {
            


                int index = new Random().Next(1, 5);
                string name = studentNames[index];

                int ageIndex = new Random().Next(1, 5);

                int age = studentAge[ageIndex];

                int studentId = new Random().Next(1, 5000);

            Student student = new Student(studentId, name, age);


            return student;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }





        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
