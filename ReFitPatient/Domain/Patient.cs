using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.Domain
{
    class Patient
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public List<ExercisePackage> PackageList { get; set; }

        public Patient()
        {
            
        }
    }
}
