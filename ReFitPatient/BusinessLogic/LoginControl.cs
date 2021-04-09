﻿using System;
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
        private bool loginBool;
        private ValidateLogin _validateLogin;
        private Patient _patient;
        private LoadDatabase _loadDatabase;
        public void LoginButtonIsPressed(string SSN, string Password)
        {
            loginBool = _validateLogin.LoginPressed(SSN, Password);

            if (loginBool == true)
            {
                //_loadDatabase.LoadPatientInfo(SSN);
                //ny patientdomæneklasse skal oprettes her og gemmes i Loginklassen??
                //_loginWindow.Close();
                //_homeWindow.Show();
            }
            else
            {
                //_loginWindow.LoginErrorMessage();
            }
        }
    }
}