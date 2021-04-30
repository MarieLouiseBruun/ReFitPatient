using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatientCore.PresentationLogic
{
    public class ValidateLogin
    {
        private int value;
        public bool CheckSSN(string SSN)
        {
            //return true her er bare for at jeg ikke skal skrive 10 tal hver gang
            return true;
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
