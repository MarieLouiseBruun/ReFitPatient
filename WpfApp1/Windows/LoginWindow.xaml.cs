using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReFitPatientBusiness;
using ReFitPatientDomain;
using ReFitPatientData;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LoginControl _loginControl;
        private HomeWindow _homeWindow;
        private Patient _patient;
        private string _currentDirectory;
        private bool _passwordIsVisible;
        
        /// <summary>
        /// constructor for loginwindow
        /// </summary>
        public LoginWindow()
        {
            _loginControl = new LoginControl();
            InitializeComponent();
            cprTB.Focus();
            pwTB.Visibility = Visibility.Hidden;
            _passwordIsVisible = false;
            ShowHideImg.Visibility = Visibility.Hidden;
            _currentDirectory = Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\netcoreapp3.1", "");

            ShowHideImg.Source = new BitmapImage(new Uri(_currentDirectory + "\\Images\\Show.JPG"));
        }


        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            if (_loginControl.LoginButtonIsPressed(cprTB.Text, Convert.ToString(pwPB.Password)))
            {
                _patient = _loginControl.GetPatientInfo(cprTB.Text, Convert.ToString(pwPB.Password));
                _homeWindow = new HomeWindow(_patient);
                _homeWindow.Show();
                this.Close();
            }
            else
            {
                this.LoginErrorMessage();
                this.cprTB.Clear();
                this.pwTB.Clear();
                this.pwPB.Clear();
                this.cprTB.Focus();
            }
        }

        /// <summary>
        /// viser et poopupvindue om at der er fejl i login.
        /// </summary>
        public void LoginErrorMessage()
        {
            MessageBox.Show("Fejl i login. Prøv igen");
        }


        //private void showPWCB_Checked(object sender, RoutedEventArgs e)
        //{
        //    pwTB.Text = pwPB.Password;
        //    pwPB.Visibility = Visibility.Collapsed;
        //    pwTB.Visibility = Visibility.Visible;

        //}

        
        void ShowPassword()
        {
            ShowHideImg.Source = new BitmapImage(new Uri(_currentDirectory + "\\Images\\Hide.JPG"));
            pwTB.Text = pwPB.Password;
            pwPB.Visibility = Visibility.Collapsed;
            pwTB.Visibility = Visibility.Visible;
        }
        void HidePassword()
        {
            ShowHideImg.Source = new BitmapImage(new Uri(_currentDirectory + "\\Images\\Show.JPG"));
            pwPB.Password = pwTB.Text;
            pwTB.Visibility = Visibility.Collapsed;
            pwPB.Visibility = Visibility.Visible;
        }

        //private void showPWCB_UnChecked(object sender, RoutedEventArgs e)
        //{
        //    pwPB.Password = pwTB.Text;
        //    pwPB.Visibility = Visibility.Visible;
        //    pwTB.Visibility = Visibility.Collapsed;
        //}
        private void SetSelection(PasswordBox passwordBox, int start, int length)
        {
            passwordBox.GetType().GetMethod("Select", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(passwordBox, new object[] { start, length });
        }

        private void pwPB_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwPB.Password.Length > 0)
                ShowHideImg.Visibility = Visibility.Visible;
            else
                ShowHideImg.Visibility = Visibility.Hidden;
        }

        private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ShowHideImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!_passwordIsVisible)
            {
                ShowPassword();
                _passwordIsVisible = true;
                pwTB.Focus();
                pwTB.SelectionStart = pwTB.Text.Length;
            }
            else
            {
                HidePassword();
                _passwordIsVisible = false;
                pwPB.Focus();
                SetSelection(pwPB, pwPB.Password.Length, 0);
            }
        }

        private void cprTB_GotFocus(object sender, RoutedEventArgs e)
        {
            cprTB.SelectAll();
        }


    }
}
