using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCStudents.Models
{
    public class LastNameViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Names { get; set; }
        public string LastName { get; set; }
        public string SearchString { get; set; }
    }
}
