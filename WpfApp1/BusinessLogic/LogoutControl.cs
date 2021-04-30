using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFitPatient.BusinessLogic
{
    public class LogoutControl
    {
        private HomeWindow _homeWindow;
        private LoginWindow _loginWindow;

        public LogoutControl(HomeWindow window)
        {
            _homeWindow = window;
        }
        public void LogoutIsPressed()
        {
            _loginWindow = new LoginWindow();
            _loginWindow.Show();
            _homeWindow.Close();

            //Vi skal have ryddet vores cache på en måde, slettet det, som er gemt fra tidligere login
        }
    }
}
