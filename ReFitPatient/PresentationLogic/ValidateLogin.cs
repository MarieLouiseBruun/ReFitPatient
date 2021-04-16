using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.PresentationLogic
{
    class ValidateLogin
    {
        private int value;
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
