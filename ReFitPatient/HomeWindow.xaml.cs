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
        public HomeWindow()
        {
            InitializeComponent();
            _logoutControl = new LogoutControl();
            _updateJournalControl = new UpdateJournalControl();
            _exerciseControl = new ExerciseControl();
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
    }
}
