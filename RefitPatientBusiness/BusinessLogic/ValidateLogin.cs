using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientData;

namespace ReFitPatientBusiness
{
    public class ValidateLogin
    {
        private LoadDatabase _loadDatabase;
        private int value;

        public ValidateLogin()
        {
            _loadDatabase = new LoadDatabase();
        }
        public bool CheckSSN(string SSN)
        {
            if (SSN.Length == 10)
            {
                if (int.TryParse(SSN,out value))
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
    }
}
