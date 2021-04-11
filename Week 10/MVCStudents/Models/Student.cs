using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCStudents.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public List<Student> Students { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }

        public List<int> Scores;
    }
}
