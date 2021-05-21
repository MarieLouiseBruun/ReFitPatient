using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
    /// <summary>
    /// domaineklasse til journal
    /// </summary>
    public class Journal
    {
        /// <summary>
        /// 
        /// </summary>
        public int JournalID { get; set; }
       /// <summary>
       /// 
       /// </summary>
        [Required]
        public DateTime JournalDate { get; set; }
       /// <summary>
       /// 
       /// </summary>
       [Required]
        public string JournalType { get; set; }
       /// <summary>
       /// 
       /// </summary>
       [MaxLength(10)]
        public double PainScale { get; set; }
       /// <summary>
       /// 
       /// </summary>
       [MaxLength(10)]
        public double BendAngle { get; set; }
       /// <summary>
       /// 
       /// </summary>
        [MaxLength(250)]
        public string Medicine { get; set; }
       /// <summary>
       /// 
       /// </summary>
        [MaxLength(500)]
        public string GeneralComment { get; set; }
       /// <summary>
       /// 
       /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>dato som en tekststreng</returns>
        public override string ToString()
        {
            return "Dato: " + JournalDate.ToString();
        }

    }
}
