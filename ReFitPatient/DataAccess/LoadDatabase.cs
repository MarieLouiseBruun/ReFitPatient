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
            return new Patient("a","b","c","d","e",1,2,new List<ExercisePackage>());
        }

        //public void LoadPackageInfo(ExercisePackageID id)
        //{

        //}

        public Journal GetPreviousJournalInformation()
        {
            return new Journal(5,35,"Heroin","Jeg har det skidt","Jeg kan bænke 120 kg");
        }
        public bool ValidateLogin(string SSN, string Password)
        {
            return true;
        }
    }
}
