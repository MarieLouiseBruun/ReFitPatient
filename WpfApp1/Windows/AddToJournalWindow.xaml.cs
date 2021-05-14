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
    public partial class AddToJournalWindow : Window
    {
        private UpdateJournalControl _updateJournalControl;
        private JournalWindow _journalWindow;
        private Journal newJournal;
        private Patient _patient;
        public AddToJournalWindow(JournalWindow window, Patient patient, UpdateJournalControl journalControl)
        {
            _journalWindow = window;
            _updateJournalControl = journalControl;
            _patient = patient;
            InitializeComponent();
            if (_journalWindow.journalCB.Text == "Knæalloplastik")
            {
                overskriftL.Content = "Dagbog for knæalloplastik";
                scaleTB.Text = "Hvor meget smerte oplever du i dit knæ på en skala fra 1 - 10 ?";
                vinkelTBL.Text = "Hvor mange grader kan du bøje dit knæ i?";
            }
            else if (_journalWindow.journalCB.Text == "Hofte")
            {
                overskriftL.Content = "Dagbog for hofte";
                scaleTB.Text = "Hvor meget smerte oplever du i din hofte på en skala fra 1 - 10?";
                vinkelTBL.Visibility = Visibility.Collapsed;
            }
            else if (_journalWindow.journalCB.Text == "Albue")
            {
                overskriftL.Content = "Dagbog for albue";
                scaleTB.Text = "Hvor meget smerte oplever du i din albue på en skala fra 1 - 10?";
                vinkelTBL.Text = "Hvor mange grader kan du bøje din albue i?";
            }
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _journalWindow.Show();
        }

        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            newJournal = new Journal();
            newJournal.GeneralComment = generelTB.Text;
            newJournal.PainScale = painS.Value;
            newJournal.BendAngle = Convert.ToDouble(vinkelTB.Text);
            newJournal.Medicine = medicinTB.Text;
            newJournal.JournalDate = DateTime.Now;
            newJournal.JournalType = _journalWindow.journalCB.Text;
            newJournal.Patient = _patient;
            _updateJournalControl.SaveNewJournalData(newJournal);
            this.Close();
            _journalWindow.Show();
            var list = _patient.Journals.OrderBy(x => x.JournalDate.Date).ToList();
            _journalWindow.JournalinfoTB.Text = "";
            foreach (var item in list)
            {
                if ((string)_journalWindow.journalCB.SelectedItem == item.JournalType)
                {
                    //JournalinfoTB skal have textwrapping tror jeg, ellers bliver det grimt
                    _journalWindow.JournalinfoTB.Text += "Dato: " + Convert.ToString(item.JournalDate)
                                                        + "\r\n" + "Generelt: " +
                                                        Convert.ToString(item.GeneralComment) + "\r\n"
                                                        + "Vinkel: " + Convert.ToString(item.BendAngle)
                                                        + "\r\n" + "Smerte: " + Convert.ToString(item.PainScale)
                                                        + "\r\n" + "Medicin: " + Convert.ToString(item.Medicine)
                                                        + "\r\n";
                }
            }
        }

        private void AnnullerB_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Er du sikker på du vil annullere?", "Cancel message", MessageBoxButton.YesNo);
        }
    }
}
