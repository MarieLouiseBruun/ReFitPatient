using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientCore.Domain;

namespace ReFitPatientData
{
    public class LoadDatabase
    {
        //public Patient LoadPatientInfo(string SSN)
        //{
        //    return new Patient("a", "b", "c", "d", "e", new List<ExercisePackage>());
        //}

        public ExercisePackage LoadPackageInfo(int ID)
        {
            return new ExercisePackage();
        }

        public Exercise LoadExerciseInfo(int ID)
        {
            return new Exercise();
        }

        //public Journal GetPreviousJournalInformation()
        //{
        //    return new Journal("a", 1, 3, "d", "e");
        //}
        public bool ValidateLogin(string SSN, string Password)
        {
            return true;
        }
    }
}
