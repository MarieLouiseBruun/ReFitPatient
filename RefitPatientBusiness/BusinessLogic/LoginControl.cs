using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    public class LoginControl
    {
        private Patient _patient;
        private LoadDatabase _loadDatabase;
        private List<ExercisePackage> _packageList;
        private ExercisePackage _exercisePackage;
        private Exercise _exercise;
        private List<Exercise> _exerciseList;

        public LoginControl()
        {
            _loadDatabase = new LoadDatabase();
        }
        public bool LoginButtonIsPressed(string SSN, string Password)
        {
            if (CheckSSN(SSN))
            {

                if (_loadDatabase.ValidateLogin(SSN, Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Patient GetPatientInfo(string ssr, string pw)
        {
            return _loadDatabase.LoadPatientInfo(ssr, pw);
        }
        public bool CheckSSN(string SSN)
        {
            if (SSN.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
