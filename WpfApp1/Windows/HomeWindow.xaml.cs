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
using ReFitPatientBusiness;
using ReFitPatientDomain;
using ReFitPatientCore;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {

        private ExerciseWindow _exerciseWindow;
        private JournalWindow _journalWindow;
        private AddToJournalWindow _addToJournalWindow;
        private SetIntervalWindow _setIntervalWindow;
        private CommentExerciseWindow _commentExerciseWindow;
        private LoginWindow _loginWindow;

        private LogoutControl _logoutControl;
        private UpdateJournalControl _updateJournalControl;
        private ExerciseControl _exerciseControl;
        private Patient _patient;
        private Journal _journal;
        private TrainingReminderControl _reminderControl;

        public HomeWindow(Patient patient)
        {
            _patient = patient;
            _logoutControl = new LogoutControl();
            _updateJournalControl = new UpdateJournalControl(_patient);
            _exerciseControl = new ExerciseControl(_patient);
            _reminderControl = new TrainingReminderControl(_patient);
            
            InitializeComponent();
            welcomeL.Text = "Hej " + _patient.Name + ". Her kan du se dine træningsøvelser eller opdatere din dagbog. God træning :-)";
        }

        private void logoutB_Click(object sender, RoutedEventArgs e)
        {
            //_loginWindow = new LoginWindow();
            //_loginWindow.Show();
            //this.Close();

            //Den her genstarter programmet. Der er muligvis en bedre måde at gøre det på, så jeg undersøger lige nærmere
            //Application.Current.Shutdown();
            //System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            
            //_logoutControl.LogoutIsPressed();
        }

        private void journalB_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _journalWindow = new JournalWindow(this, _journal, _patient);
            _journalWindow.Show();

        }

        private void viewExercisesB_Click(object sender, RoutedEventArgs e)
        {
            _exerciseWindow = new ExerciseWindow(this, _patient);
            _exerciseWindow.Show();
            this.Hide();
        }

        private void intervalB_Click(object sender, RoutedEventArgs e)
        {
            _setIntervalWindow = new SetIntervalWindow(this, _patient);
            _setIntervalWindow.Show();
            this.Hide();
        }

        private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
