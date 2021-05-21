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
   /// <summary>
   /// domaineklasse til exercisepakage
   /// </summary>
    public class ExercisePackage
    {
        /// <summary>
        /// constructor til exercisepakage
        /// </summary>
        public ExercisePackage()
        {
            Patients = new HashSet<Patient>();
            Exercises = new List<Exercise>();
            Completed = false;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
        public int ExercisePackageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required] public bool Completed { get; set; } = false;
        public ICollection<Exercise> Exercises { get; set; }
       /// <summary>
       /// 
       /// </summary>
        public virtual ICollection<Patient> Patients { get; set; }

    }
}
