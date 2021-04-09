using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.Domain
{
    class Journal
    {
        public int PainScale { get; set; }
        public double BendAngle { get; set; }
        public string Medicine { get; set; }
        public string GeneralComment { get; set; }
        public string ExerciseComment { get; set; }
    }
}
