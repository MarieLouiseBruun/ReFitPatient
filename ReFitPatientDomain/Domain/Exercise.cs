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
        [Key]
        [Required]
        public int ExerciseID { get; set; }
        [Required]
        [MaxLength(200)]
        public string ExerciseLink { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public int Sets { get; set; }
        [Required]
        [MaxLength(50)]
        public int Repetitions { get; set; }
        [Required]
        public bool Hide { get; set; } = false;
    }
}
