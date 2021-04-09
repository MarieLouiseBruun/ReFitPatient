using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.Domain
{
   
    class ExercisePackage
    {
        public string PackageName { get; set; }
        public List<Exercise> ExerciseList { get; set; }
        //skal listen indeholde exercise eller exerciseID? ID er jo ikke en klasse..
    }
}
