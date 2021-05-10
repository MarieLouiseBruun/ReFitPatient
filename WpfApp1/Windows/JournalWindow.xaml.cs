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

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class JournalWindow : Window
    {
        private AddToJournalWindow _addToJournalWindow;
        public Journal _journal { get; set; }
        private ReturnController _returnController;
        private HomeWindow _homeWindow;
        private Patient _patient;
        private UpdateJournalControl _journalControl;

        public JournalWindow(HomeWindow window, Journal journal, Patient patient)
        {
            _patient = patient;
            _journal = journal;
            _homeWindow = window;
            _returnController = new ReturnController();
            _journalControl = new UpdateJournalControl(patient, journal);
            InitializeComponent();

            foreach (var item in _patient.ExercisePackages)
            {
                journalCB.Items.Add(item.Name);
            }
            journalCB.SelectedItem = journalCB.Items[0];
            //for (int i = _patient.JournalID.Count; i > 0; i--)
            //{
            //    this.JournalinfoTB.Text += _patient.JournalID[i];
            //    i--;
            //}
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            //Her er dobbelt dependency
            this.Close();
            _homeWindow.Show();
        }

        private void editB_Click(object sender, RoutedEventArgs e)
        {

            _addToJournalWindow = new AddToJournalWindow(this,_patient,_journalControl);
            _addToJournalWindow.Show();
        }

        private void journalCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.JournalinfoTB.Text = "";
            foreach (var item in _patient.Journals)
            {
                if ((string)journalCB.SelectedItem == item.JournalType)
                {
                    this.JournalinfoTB.Text += "Dato: "
                                               + Convert.ToString(item.JournalDate)
                                               + "\r\n" + "Generelt: " +
                                               Convert.ToString(item.GeneralComment) + "\r\n"
                                               + "Vinkel: " + Convert.ToString(item.BendAngle)
                                               + "\r\n" + "Smerte: " + Convert.ToString(item.PainScale)
                                               + "\r\n" + "Medicin: " + Convert.ToString(item.Medicine);
                }
            }
        }
    }
}
