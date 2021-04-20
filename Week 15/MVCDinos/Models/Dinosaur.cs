using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDinos.Models
{
    public class Dinosaur
    {
        public int DinosaurID { get; set; }
        public string DinosaurName { get; set; }
        public string Pronounced { get; set; }
        public string BriefDesc { get; set; }
        public string NameMeans { get; set; }
        public int LengthFt { get; set; }
        public int WeightLbs { get; set; }
        public int LivedYearsAgo { get; set; }

        [ForeignKey("Class")]
        public string ClassID { get; set; }
        [ForeignKey("Period")]
        public string PeriodID { get; set; }
    }
}
