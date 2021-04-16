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
            InitializeComponent();
            _loginControl = new LoginControl(this);
        }

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            _loginControl.LoginButtonIsPressed(cprTB.Text,pwTB.Text);
        }

        public void LoginErrorMessage()
        {
            MessageBox.Show("Fejl i login. Prøv igen");
        }

        public void SSNErrorMessage()
        {
            MessageBox.Show("Fejl i login. Prøv igen");
        }
    }
}
