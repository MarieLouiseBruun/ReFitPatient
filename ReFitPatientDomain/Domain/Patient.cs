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
    ///  Klassen holder på properties for en patient
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
        /// Property som indeholder CPR-nummer for en patient
        /// </summary>
        [Required]
        [Key]
        [MaxLength(10)]
        public string SSN { get; set; }
        /// <summary>
        /// Property som indeholder en patients navn
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// Property som indeholder en patients password
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        /// <summary>
        /// Property som indeholder en patients email
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        /// <summary>
        /// Property som indeholder en patients navn telefonnummer
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Property som indeholder en liste af jorunals.
        /// </summary>
        public ICollection<Journal> Journals { get; set; }
        /// <summary>
        /// Property som indeholder en liste af øvelsespakker
        /// </summary>
        public virtual ICollection<ExercisePackage> ExercisePackages { get; set; }

        /// <summary>
        /// Metoden spørger for at patienten kan udskrives korrekt i autocomplete boxen i præsentationslaget
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return SSN + ", " + Name;
        }
    }
}

