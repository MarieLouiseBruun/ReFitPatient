using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.PresentationLogic
{
    class ValidateLogin
    {
        public bool LoginPressed(string SSN, string password)
        {
            return true;
            //skal verificere loginoplysninger i databasen
            //denne klasse skal måske slettes og metoden flyttes over til LoadDatabase?
        }
    }
}
