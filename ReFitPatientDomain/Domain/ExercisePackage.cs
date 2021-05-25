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
    /// Klassen indeholder properties for en øvelsespakke
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
        /// Property som indeholder unikt id for en øvelsespakke
        /// </summary>
        [Key]
        [Required]
        public int ExercisePackageID { get; set; }
        /// <summary>
        /// Property som indeholder en streng for navnet på øvelsespakken
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// Property som indeholder en collection af øvelser som indgår i øvelsespakken
        /// </summary>
        [Required] public bool Completed { get; set; } = false;
        public ICollection<Exercise> Exercises { get; set; }
        /// <summary>
        /// Property som indeholder en collection af Patienter som er tilknyttet øvelsespakken
        /// </summary>
        public virtual ICollection<Patient> Patients { get; set; }

    }
}
