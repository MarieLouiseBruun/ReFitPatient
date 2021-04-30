using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using ReFitPatientCore;
using ReFitPatientCore.DataAccess;
using ReFitPatientCore.Domain;

namespace ReFitPatientCore.BusinessLogic
{
    public class UpdateJournalControl
    {
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        private HomeWindow _homeWindow;
        private JournalWindow _journalWindow;
        private AddToJournalWindow _addToJournalWindow;
        private Journal _journal;
        private Patient _patient;

        public UpdateJournalControl(HomeWindow window, Patient patient, Journal journal)
        {
            _homeWindow = window;
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase();
            _patient = patient;
            _journal = journal;

        }
        public void UpdateJournalIsPressed(JournalWindow window)
        {
            _journalWindow = window;
            _addToJournalWindow = new AddToJournalWindow(_journalWindow, this);
            _journalWindow.Hide();
            _addToJournalWindow.Show();
            
        }

        public void ExercisePackageJournalChosen()
        {
            //Tror vi skal kigge på vores sekvensdiagram her..
        }
        public void JournalButtonIsPressed()
        {
            _homeWindow.Hide();
            _journal = _loadDatabase.GetPreviousJournalInformation();
            _journalWindow = new JournalWindow(_homeWindow, _journal, _patient);

            //Her skal vi have indlæst data fra journalen i databasen, og sat det korrekt ind i vinduet med nyeste først
            PrintJournal();

            _journalWindow.Show();
        }


        public void CancelButtonIsPressed()
        {
            MessageBox.Show("Er du sikker på du vil annullere?","Cancel message",MessageBoxButton.YesNo);
        }


        public void SaveNewJournalData(Journal journal)
        {
            //new journal domæneklasse skal laves her
            //string tempJournalString = "Generelt kommentar: " + _addToJournalWindow.generelTB.Text + "Medicinifo: " + _addToJournalWindow.medicinTB.Text + "Smerteskala fra 1-10: " +
            //                           _addToJournalWindow.painS.Value + "Vinkel i grader: " + _addToJournalWindow.vinkelTB.Text;

            //Gemer både i den lokale _journal og i databasen
            //_journal.JournalList.Add(tempJournalString);
            //_saveDatabase.SaveJournal(tempJournalString);
            //_addToJournalWindow.Close();
            //_journalWindow.Show();
        }


        //Skal måske være en ny klasse!
        public void PrintJournal()
        {
            //Vi tror at den her udskriver den ældste først, da i = det største tal, det vil sige det ældste input i listen
            //for (int i = _patient.Journal.JournalList.Count; i > 0; i--)
            //{
            //    _journalWindow.JournalinfoTB.Text += _patient.Journal.JournalList[i];
            //    i--;
            //}
            //foreach (var item in _patient.Journal.JournalList)
            //{
            //    _journalWindow.JournalinfoTB.Text += item;
            //}
        }
    }
}
