using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientDomain
{
    /// <summary>
    /// Klassen holder på properties for en journal
    /// </summary>
    public class Journal
    {
        /// <summary>
        /// Property som indeholder id for en  jorunal
        /// </summary>
        public int JournalID { get; set; }
        /// <summary>
        /// Property som indeholder dato for oprettelse af en journal
        /// </summary>
        [Required]
        public DateTime JournalDate { get; set; }
        /// <summary>
        /// Property som indeholder typen af en jorunal. Ved typen forstås hvilken øvelsespakke jorunalen er tilknyttet.
        /// </summary>
        [Required]
        public string JournalType { get; set; }
        /// <summary>
        /// Property som indeholder en værdi for smerteskala
        /// </summary>
        [MaxLength(10)]
        public double PainScale { get; set; }
        /// <summary>
        /// Property som indeholder en vinkel over hvor meget en patient kan bøje sit knæ
        /// </summary>
        [MaxLength(10)]
        public double BendAngle { get; set; }
        /// <summary>
        /// Property som indeholder en streng til beskrivelse af medicin indtag
        /// </summary>
        [MaxLength(250)]
        public string Medicine { get; set; }
        /// <summary>
        /// Property som indeholder en generel kommentar 
        /// </summary>
        [MaxLength(500)]
        public string GeneralComment { get; set; }
        /// <summary>
        /// Property som indeholder en patient, som journalen er tilknyttet
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Metoden spørger for at journalen udskrives med oprettelses dato i præsentationslaget
        /// </summary>
        /// <returns>dato som en tekststreng</returns>
        public override string ToString()
        {
            return "Dato: " + JournalDate.ToString();
        }

    }
}
