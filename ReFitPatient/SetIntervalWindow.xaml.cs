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
using ReFitPatient.BusinessLogic;

namespace ReFitPatient
{
    /// <summary>
    /// Interaction logic for SetIntervalWindow.xaml
    /// </summary>
    public partial class SetIntervalWindow : Window
    {
        private TrainingReminderControl _reminderControl;
        public SetIntervalWindow(TrainingReminderControl reminderControl)
        {
            _reminderControl = reminderControl;
            InitializeComponent();
        }

        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(intervalTB.Text, out value))
            {
                _reminderControl.IntervalSet(Convert.ToInt32(intervalTB.Text));
                MessageBox.Show("Nyt interval gemt!");
            }
            else
            {
                MessageBox.Show("Indtast venligst et heltal!");
            }
        }

        private void annullerB_Click(object sender, RoutedEventArgs e)
        {
            _reminderControl.CancelIntervalUpdate();
        }
    }
}
