using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public string ExerciseLink { get; set; }
        public string Description { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
    }
}
