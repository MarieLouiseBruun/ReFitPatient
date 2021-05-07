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
using System.Windows.Shapes;
using ReFitPatientBusiness;
using ReFitPatientDomain;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for SetIntervalWindow.xaml
    /// </summary>
    public partial class SetIntervalWindow : Window
    {
        private TrainingReminderControl _reminderControl;
        private HomeWindow _homeWindow;
        private Patient _patient;
        public SetIntervalWindow(HomeWindow homewindow, Patient patient)
        {
            _homeWindow = homewindow;
            _patient = patient;
            _reminderControl = new TrainingReminderControl(_patient);
            InitializeComponent();
        }

        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(intervalTB.Text, out value))
            {
                _reminderControl.IntervalSet(Convert.ToInt32(intervalTB.Text));
                MessageBox.Show("Nyt interval gemt!");
                this.Close();
                _homeWindow.Show();
            }
            else
            {
                MessageBox.Show("Indtast venligst et heltal!");
            }
        }

        private void annullerB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _homeWindow.Show();
        }
    }
}
