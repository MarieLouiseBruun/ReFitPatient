using System;
using System.Collections.Generic;
using System.Linq;
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
using ReFitPatient.BusinessLogic;
using ReFitPatient.PresentationLogic;

namespace ReFitPatient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LoginControl _loginControl;
        public LoginWindow()
        {
            _loginControl = new LoginControl(this);

            InitializeComponent();
            cprTB.Focus();
        }

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            _loginControl.LoginButtonIsPressed(cprTB.Text,pwTB.Password);
        }

        public void LoginErrorMessage()
        {
            MessageBox.Show("Fejl i login. Prøv igen");
        }

        public void SSNErrorMessage()
        {
            MessageBox.Show("Fejl i login. Prøv igen");
        }

        private void showPWCB_Checked(object sender, RoutedEventArgs e)
        {
            if (showPWCB.IsChecked == true)
            {
                pwTB.PasswordChar = '\0';
            }

            if (showPWCB.IsChecked == false)
            {
                pwTB.PasswordChar = '*';
            }
        }
    }
}
