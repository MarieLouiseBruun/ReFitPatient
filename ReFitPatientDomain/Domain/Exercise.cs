using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
    public class Exercise
    {
        public Exercise()
        {
            Hide = false;
        }
        [Key]
        [Required] 
        public int ExerciseID { get; set; }
        public string ExerciseLink { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public int Sets { get; set; }
        [Required]
        [MaxLength(50)]
        public int Repetitions { get; set; }
        [Required]
        public bool Hide { get; set; }
        public ExercisePackage ExercisePackage { get; set; }
    }
}
