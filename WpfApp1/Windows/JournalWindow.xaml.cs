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
using ReFitPatientCore.BusinessLogic;
using ReFitPatientCore.Domain;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class JournalWindow : Window
    {
        public Journal _journal { get; set; }
        public string laaaaangjournalstring { get; set; }
        private ReturnController _returnController;
        private HomeWindow _homeWindow;
        private Patient _patient;
        private UpdateJournalControl _journalControl;

        public JournalWindow(HomeWindow window, Journal journal, Patient patient)
        {
            _patient = patient;
            _journal = journal;
            _homeWindow = window;
            _returnController = new ReturnController(window);
            _journalControl = new UpdateJournalControl(window, patient, journal);

            InitializeComponent();
            _journalControl.PrintJournal();
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _returnController.ReturnToHome(this);
        }

        private void editB_Click(object sender, RoutedEventArgs e)
        {
            _journalControl.UpdateJournalIsPressed(this);
        }
    }
}
