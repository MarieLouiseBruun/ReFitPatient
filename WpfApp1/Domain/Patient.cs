using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.Domain
{
    public class Patient
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
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
