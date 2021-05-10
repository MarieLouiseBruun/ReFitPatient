using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Patient
    {
        public Patient()
        {
            ExercisePackages = new HashSet<ExercisePackage>();
            Journals = new List<Journal>();
        }
        [Required]
        [Key]
        [MaxLength(10)]
        public string SSN { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public ICollection<Journal> Journals { get; set; }
        public virtual ICollection<ExercisePackage> ExercisePackages { get; set; }

        public override string ToString()
        {
            return SSN + ", " + Name;
        }
    }
}

