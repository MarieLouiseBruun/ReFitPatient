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
    /// Klassen indeholder properties for en øvelse i en øvelsespakke
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
        /// Property som indeholder unikt id for en øvelse
        /// </summary>
        [Key]
        [Required] 
        public int ExerciseID { get; set; }
        /// <summary>
        /// Property som indeholder en streng til øvelsens youtube link
        /// </summary>
        public string ExerciseLink { get; set; }
        /// <summary>
        /// Property som indeholder en streng til beskrivelsen af øvelsen
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// Property som indeholder et hel tal for antallet af sæt
        /// </summary>
        [Required]
        [MaxLength(50)]
        public int Sets { get; set; }
        /// <summary>
        /// Property som indeholder et hel tal for antallet af gentagelser
        /// </summary>
        [Required]
        [MaxLength(50)]
        public int Repetitions { get; set; }
        /// <summary>
        /// Property som indikerer om en øvelse skal gemmes væk eller ej
        /// </summary>
        [Required]
        public bool Hide { get; set; }
        /// <summary>
        /// Property som indikerer hvilken øvelsepakke øvelsen indgår i
        /// </summary>
        public ExercisePackage ExercisePackage { get; set; }
    }
}
