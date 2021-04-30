using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
   
    public class ExercisePackage
    {
        public string PackageName { get; set; }
        public int ExercisePackageID { get; set; }
        public List<Exercise> ExerciseList { get; set; }
    }
}
