using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
    /// <summary>
    /// domine klasse til de enkelte øvelser
    /// </summary>
    public class Exercise
    {
        /// <summary>
        /// constructor til exercise
        /// </summary>
        public Exercise()
        {
            Hide = false;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required] 
        public int ExerciseID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ExerciseLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(50)]
        public int Sets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(50)]
        public int Repetitions { get; set; }
       /// <summary>
       /// 
       /// </summary>
        [Required]
        public bool Hide { get; set; }
       /// <summary>
       /// 
       /// </summary>
       public ExercisePackage ExercisePackage { get; set; }
    }
}
