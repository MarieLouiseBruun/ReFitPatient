using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.Domain;

namespace ReFitPatient.DataAccess
{
    public class LoadDatabase
    {
        public Patient LoadPatientInfo(string SSN)
        {
            return new Patient("a","b","c","d","e",new List<ExercisePackage>());
        }

        public ExercisePackage LoadPackageInfo(int ID)
        {
            return new ExercisePackage();
        }

        public Exercise LoadExerciseInfo(int ID)
        {
            return new Exercise();
        }

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
