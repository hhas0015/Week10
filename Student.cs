using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week10
{
    public class Student
    {
        public int Id { get; set; }

        public string studentName { get; set; }

        public int studentAge { get; set; }


        public Student(int _id, string _name, int _age) 
        {
            this.Id = _id;
            this.studentName = _name;
            this.studentAge = _age;
        }

        public Student()
        {
        }
    }
}
