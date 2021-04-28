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
            pwTB.Visibility = Visibility.Collapsed;
        }

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            _loginControl.LoginButtonIsPressed(cprTB.Text,pwPB.Password);
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
            pwTB.Text = pwPB.Password;
            pwPB.Visibility = Visibility.Collapsed;
            pwTB.Visibility = Visibility.Visible;
        }

        private void showPWCB_UnChecked(object sender, RoutedEventArgs e)
        {
            pwPB.Password = pwTB.Text;
            pwPB.Visibility = Visibility.Visible;
            pwTB.Visibility = Visibility.Collapsed;
        }
    }
}
