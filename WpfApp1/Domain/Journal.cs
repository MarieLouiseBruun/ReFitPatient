using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
    public class Journal
    {
        public string JournalType { get; set; }
        public double PainScale { get; set; }
        public double BendAngle { get; set; }
        public string Medicine { get; set; }
        public string GeneralComment { get; set; }
        //public string ExerciseComment { get; set; }

        public Journal(string journalType, double painscale, double bendAngle, string medicine, string generalComment)
        {
            JournalType = journalType;
            PainScale = painscale;
            BendAngle = bendAngle;
            Medicine = medicine;
            GeneralComment = generalComment;
        }
    }
}
