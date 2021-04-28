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
using ReFitPatient.Domain;

namespace ReFitPatient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private LogoutControl _logoutControl;
        private UpdateJournalControl _updateJournalControl;
        private ExerciseControl _exerciseControl;
        private Patient _patient;
        private Journal _journal;
        private TrainingReminderControl _reminderControl;
        public HomeWindow(Patient patient)
        {
            _logoutControl = new LogoutControl(this);
            _patient = patient;
            _updateJournalControl = new UpdateJournalControl(this, _patient, _journal);
            _exerciseControl = new ExerciseControl(this);
            _reminderControl = new TrainingReminderControl(this);

            InitializeComponent();
            welcomeL.Text = "Hej " + _patient.Name+". Her kan du se dine træningsøvelser eller opdatere din dagbog. God træning :-)";
        }

        private void logoutB_Click(object sender, RoutedEventArgs e)
        {
            _logoutControl.LogoutIsPressed();
        }

        private void journalB_Click(object sender, RoutedEventArgs e)
        {
            _updateJournalControl.JournalButtonIsPressed();
        }

        private void viewExercisesB_Click(object sender, RoutedEventArgs e)
        {
            _exerciseControl.WatchExerciseIsPressed();
        }

        private void intervalB_Click(object sender, RoutedEventArgs e)
        {
            _reminderControl.SetIntervalBIsPressed();
        }
    }
}
