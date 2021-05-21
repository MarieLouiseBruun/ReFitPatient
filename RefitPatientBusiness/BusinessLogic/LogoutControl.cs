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

        public LogoutControl()
        {
        }
        public void LogoutIsPressed()
        {
            //Vi skal have ryddet vores cache på en måde, slettet det, som er gemt fra tidligere login
        }
    }
}
