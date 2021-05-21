using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    /// <summary>
    /// controller til UC1 login. kalder metoder videre til dataAccesLogic og sender tilbage til presentationlogic
    /// </summary>
    public class LoginControl : ILoginControl
    {
        private ILoadDatabase _loadDatabase;
        public LoginControl()
        {
            _loadDatabase = new LoadDatabase();
        }

        public LoginControl(ILoadDatabase loadDatabase)
        {
            _loadDatabase = loadDatabase;
        }
        /// <summary>
        /// Sender cpr og password videre til datalaget, hvis cpr overholder reglerne
        /// </summary>
        /// <param name="SSN">cpr nummer</param>
        /// <param name="Password">password</param>
        /// <returns>true hvis cpr overholder regler OG false hvis det ikke overholder en af delene</returns>
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
        /// <summary>
        /// henter patient informationerner fra databasen hvis cpr og password passer
        /// </summary>
        /// <param name="ssr">det indtastede cpr nummer</param>
        /// <param name="pw">det indtastede password</param>
        /// <returns></returns>
        public Patient GetPatientInfo(string ssr, string pw)
        {
            return _loadDatabase.LoadPatientInfo(ssr, pw);
        }
        /// <summary>
        /// tjekker om CPR-nummeret passer til rammerne for et 
        /// </summary>
        /// <param name="SSN">cpr nummer</param>
        /// <returns>true hvis cpr nummeret er 10 tegn, false hvis det ikke gør</returns>
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
