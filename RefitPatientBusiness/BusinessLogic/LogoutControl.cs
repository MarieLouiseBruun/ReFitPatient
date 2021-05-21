using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientData;
using ReFitPatientBusiness;

namespace ReFitPatientBusiness
{
    /// <summary>
    /// controller til UC5 logout - bruges ikke pt.
    /// </summary>
    public class LogoutControl :ILogoutControl
    {
        /// <summary>
        /// constructor til logoutcontrol
        /// </summary>
        public LogoutControl()
        {
        }
        /// <summary>
        /// denne metode skal sørge for at patienten bliver ordentlig logget ud når der bliver trykket på log ud
        /// </summary>
        public void LogoutIsPressed()
        {
            //Vi skal have ryddet vores cache på en måde, slettet det, som er gemt fra tidligere login
        }
    }
}
