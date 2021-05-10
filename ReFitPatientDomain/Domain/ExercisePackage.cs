using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
   
    public class ExercisePackage
    {
        public ExercisePackage()
        {
            Patients = new HashSet<Patient>();
            Exercises = new List<Exercise>();
            Completed = false;
        }
        [Key]
        [Required]
        public int ExercisePackageID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required] public bool Completed { get; set; } = false;
        
        public ICollection<Exercise> Exercises { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }

    }
}
