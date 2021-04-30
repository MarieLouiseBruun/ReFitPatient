using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
    public class Patient
    {
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
        public List<ExercisePackage> PackageList { get; set; } = new List<ExercisePackage>();
        public List<Journal> JournalList { get; set; } = new List<Journal>();

        //public Patient(string name, string password, string ssn, string email, string phonenumber, List<ExercisePackage> packageList)
        //{
        //    Name = name;
        //    Password = password;
        //    SSN = ssn;
        //    Email = email;
        //    PhoneNumber = phonenumber;
        //    PackageList = packageList;
        //}
    }
}
