using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
    public class Journal
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public string JournalType { get; set; }
        [MaxLength(10)]
        public double PainScale { get; set; }
        [MaxLength(10)]
        public double BendAngle { get; set; }
        [MaxLength(250)]
        public string Medicine { get; set; }
        [MaxLength(500)]
        public string GeneralComment { get; set; }
        //public string ExerciseComment { get; set; }

        //public Journal(string journalType, double painscale, double bendAngle, string medicine, string generalComment)
        //{
        //    JournalType = journalType;
        //    PainScale = painscale;
        //    BendAngle = bendAngle;
        //    Medicine = medicine;
        //    GeneralComment = generalComment;
        //}
    }
}
