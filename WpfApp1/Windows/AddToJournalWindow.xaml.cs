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
    /// Interaction logic for AddToJournalWindow.xaml
    /// </summary>
    public partial class AddToJournalWindow : Window
    {
        private UpdateJournalControl _updateJournalControl;
        private JournalWindow _journalWindow;
        private Journal newJournal;
        private Patient _patient;
        /// <summary>
        /// constructor til addToJournalWindow
        /// </summary>
        /// <param name="window">det journalwindow man kom fra</param>
        /// <param name="patient">patientinformaitoner på den der er logget ind</param>
        /// <param name="journalControl">controller, så der kan sendes videre</param>
        public AddToJournalWindow(JournalWindow window, Patient patient, UpdateJournalControl journalControl)
        {
            _journalWindow = window;
            _updateJournalControl = journalControl;
            _patient = patient;
            InitializeComponent();
            if (_journalWindow.journalCB.Text == "Knæ")
            {
                overskriftL.Content = "Dagbog for knæ";
                scaleTB.Text = "Hvor meget smerte oplever du i dit knæ på en skala fra 1 - 10 ?";
                vinkelTBL.Text = "Hvor mange grader kan du bøje dit knæ i?";
            }
            else if (_journalWindow.journalCB.Text == "Hofte")
            {
                overskriftL.Content = "Dagbog for hofte";
                scaleTB.Text = "Hvor meget smerte oplever du i din hofte på en skala fra 1 - 10?";
                vinkelTBL.Visibility = Visibility.Collapsed;
                vinkelTB.Visibility = Visibility.Collapsed;
                vinkelL.Visibility = Visibility.Collapsed;
            }
            else if (_journalWindow.journalCB.Text == "Albue")
            {
                overskriftL.Content = "Dagbog for albue";
                scaleTB.Text = "Hvor meget smerte oplever du i din albue på en skala fra 1 - 10?";
                vinkelTBL.Text = "Hvor mange grader kan du bøje din albue i?";
            }
        }
        /// <summary>
        /// navigere tilbage til dagbosvindue når der trykkes på denne knap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _journalWindow.Show();
        }
        /// <summary>
        /// opretter en ny journal, sender denne videre til dataAcces og lukker dette vindue, for at vise dagbogsvinduet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            newJournal = new Journal();
            newJournal.GeneralComment = generelTB.Text;
            newJournal.PainScale = painS.Value;
            if (_journalWindow.journalCB.Text == "Knæ" || (string)_journalWindow.journalCB.SelectedItem == "Albue")
            {
                newJournal.BendAngle = Convert.ToDouble(vinkelTB.Text);
            }
            else newJournal.BendAngle = 0;
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
                    if ((string) _journalWindow.journalCB.SelectedItem == "Knæ" || (string)_journalWindow.journalCB.SelectedItem == "Albue")
                    {
                        //JournalinfoTB skal have textwrapping tror jeg, ellers bliver det grimt
                        _journalWindow.JournalinfoTB.Text += "Dato: " + Convert.ToString(item.JournalDate)
                                                                      + "\r\n" + "Generelt: " +
                                                                      Convert.ToString(item.GeneralComment) + "\r\n"
                                                                      + "Vinkel: " + Convert.ToString(item.BendAngle)
                                                                      + "\r\n" + "Smerte: " +
                                                                      Convert.ToString(item.PainScale)
                                                                      + "\r\n" + "Medicin: " +
                                                                      Convert.ToString(item.Medicine)
                                                                      + "\r\n";
                    }
                    else
                    {
                        _journalWindow.JournalinfoTB.Text += "\r\nDato: " + Convert.ToString(item.JournalDate)
                                                                      + "\r\n" + "Generelt: " +
                                                                      Convert.ToString(item.GeneralComment)
                                                                      + "\r\n" + "Smerte: " +
                                                                      Convert.ToString(item.PainScale)
                                                                      + "\r\n" + "Medicin: " +
                                                                      Convert.ToString(item.Medicine)
                                                                      + "\r\n";
                        }
                }
            }
        }

        /// <summary>
        /// når der trykkes på annullere kommer der et popupvindue om patienten er sikker, hvorfra han kan sige ja eller nej. hvis han trykker nej lukker popupvinduet. hvis han trykker ja lukker addtojournalvinduet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnullerB_OnClick(object sender, RoutedEventArgs e)
        {
            String dialogResult = Convert.ToString(MessageBox.Show("Er du sikker på du vil annullere?", "Cancel message", MessageBoxButton.YesNo));
            if (dialogResult == "Yes")
            {
                this.Hide();
            }
            else if (dialogResult == "No")
            {
                //do something else
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToJournalWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
