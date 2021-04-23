using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using ReFitPatient.DataAccess;
using ReFitPatient.Domain;
using ReFitPatient.PresentationLogic;

namespace ReFitPatient.BusinessLogic
{
    public class LoginControl
    {
        private ValidateLogin _validateLogin;
        private Patient _patient;
        private LoadDatabase _loadDatabase;
        private HomeWindow _homeWindow;
        private LoginWindow _loginWindow;
        private List<ExercisePackage> _packageList;
        private ExercisePackage _exercisePackage;
        private Exercise _exercise;
        private List<Exercise> _exerciseList;

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

                    //ALT HERFRA TIL _HOMEWINDOW TÆNKER VI ER GODT 
                    //Spørgsmålet er, hvorvidt det skal placeres her, eller i homewindow eller et andet sted, så det kommer
                    //med videre rundt i forløbet i programmet. :)
                    _patient = _loadDatabase.LoadPatientInfo(SSN);
                    foreach (var item in _patient.PackageList)
                    {
                        _exercisePackage = _loadDatabase.LoadPackageInfo(item.ExercisePackageID);
                        _packageList.Add(_exercisePackage);
                    }

                    foreach (var item in _packageList)
                    {
                        foreach (var exercise in item.ExerciseList)
                        {
                            _exercise = _loadDatabase.LoadExerciseInfo(exercise.ExerciseID);
                            _exerciseList.Add(_exercise);
                        }
                    }
                    
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
