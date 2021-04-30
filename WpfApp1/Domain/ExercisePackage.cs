using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
   
    public class ExercisePackage
    {
        [Key]
        [Required]
        public int ExercisePackageID { get; set; }
        [Required]
        [MaxLength(100)]
        public string PackageName { get; set; }
        
        public List<Exercise> ExerciseList { get; set; } = new List<Exercise>();
    }
}
