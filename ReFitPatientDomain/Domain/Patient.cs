using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
    /// <summary>
    /// domaineklasse til patient
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// constructor til patientklassen
        /// </summary>
        public Patient()
        {
            ExercisePackages = new HashSet<ExercisePackage>();
            Journals = new List<Journal>();
        }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Key]
        [MaxLength(10)]
        public string SSN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<Journal> Journals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<ExercisePackage> ExercisePackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return SSN + ", " + Name;
        }
    }
}

