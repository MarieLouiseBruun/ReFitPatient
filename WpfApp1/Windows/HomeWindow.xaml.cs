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
    /// Interaction logic for HomeWindow.xaml
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

        /// <summary>
        /// constructor for homewindow. opretter alle de nødvendige komponenter til programmet udfra patientens info
        /// </summary>
        /// <param name="patient">som er logget ind</param>
        public HomeWindow(Patient patient)
        {
            _patient = patient;
            _logoutControl = new LogoutControl();
            _patient = patient;
            _updateJournalControl = new UpdateJournalControl(_patient, _journal);
            _exerciseControl = new ExerciseControl();
            _reminderControl = new TrainingReminderControl(patient);

            InitializeComponent();
            welcomeL.Text = "Hej " + _patient.Name + ". Her kan du se dine træningsøvelser eller opdatere din dagbog. God træning :-)";
        }

        /// <summary>
        /// lukker homewindow og åbner et nyt loginwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutB_Click(object sender, RoutedEventArgs e)
        {
            _loginWindow = new LoginWindow();
            _loginWindow.Show();
            this.Close();

            //Den her genstarter programmet. Der er muligvis en bedre måde at gøre det på, så jeg undersøger lige nærmere
            //Application.Current.Shutdown();
            //System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);

            //_logoutControl.LogoutIsPressed();
        }

        /// <summary>
        /// gemmer homewindow og åbner journal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void journalB_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _journalWindow = new JournalWindow(this, _journal, _patient);
            _journalWindow.Show();

        }

        /// <summary>
        /// gemmer homewindow og åbner et nyt exercisewindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewExercisesB_Click(object sender, RoutedEventArgs e)
        {
            _exerciseWindow = new ExerciseWindow(this, _patient);
            _exerciseWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// gemmer homewindow og åbner et nyt sætintervalwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void intervalB_Click(object sender, RoutedEventArgs e)
        {
            _setIntervalWindow = new SetIntervalWindow(this, _patient);
            _setIntervalWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
