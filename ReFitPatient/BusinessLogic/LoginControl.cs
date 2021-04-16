using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.DataAccess;
using ReFitPatient.Domain;
using ReFitPatient.PresentationLogic;

namespace ReFitPatient.BusinessLogic
{
    class LoginControl
    {
        private ValidateLogin _validateLogin;
        private Patient _patient;
        private LoadDatabase _loadDatabase;
        private HomeWindow _homeWindow;
        private LoginWindow _loginWindow;

        public LoginControl(LoginWindow loginWindow)
        {
            _validateLogin = new ValidateLogin();
            _loginWindow = loginWindow;
            _loadDatabase = new LoadDatabase();
        }
        public void LoginButtonIsPressed(string SSN, string Password)
        {
            if (_validateLogin.CheckSSN(SSN))
            {

                if (_loadDatabase.ValidateLogin(SSN, Password))
                {
                    _patient = _loadDatabase.LoadPatientInfo(SSN);
                    //LoadPatientInfo skal her returnere en ny patient
                    _homeWindow = new HomeWindow();
                    _homeWindow.Show();
                    _loginWindow.Close();
                }
                else
                {
                    _loginWindow.LoginErrorMessage();
                    _loginWindow.cprTB.Clear();
                    _loginWindow.pwTB.Clear();
                    _loginWindow.cprTB.Focus();
                }
            }
            else
            {
                _loginWindow.SSNErrorMessage();
                _loginWindow.cprTB.Clear();
                _loginWindow.pwTB.Clear();
                _loginWindow.cprTB.Focus();
            }
        }
    }
}
