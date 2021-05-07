using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
    public class Journal
    {
        public int JournalID { get; set; }
        [Required]
        public DateTime JournalDate { get; set; }
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
    }
}
