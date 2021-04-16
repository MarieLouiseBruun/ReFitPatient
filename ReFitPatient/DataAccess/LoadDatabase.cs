using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.Domain;

namespace ReFitPatient.DataAccess
{
    class LoadDatabase
    {
        public Patient LoadPatientInfo(string SSN)
        {
            return new Patient();
        }

        public void LoadPackageInfo(ExercisePackageID id)
        {

        }

        public Journal GetPreviousJournalInformation()
        {
            return new Journal();
        }
        public bool ValidateLogin(string SSN, string Password)
        {
            return true;
        }
    }
}
