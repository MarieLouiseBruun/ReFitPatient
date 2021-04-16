using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ReFitPatient.DataAccess;
using ReFitPatient.Domain;

namespace ReFitPatient.BusinessLogic
{
    class UpdateJournalControl
    {
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        private HomeWindow _homeWindow;
        private JournalWindow _journalWindow;
        private AddToJournalWindow _addToJournalWindow;
        private Journal _journal;

        public UpdateJournalControl(HomeWindow window)
        {
            _homeWindow = window;
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase();
            
        }
        public void UpdateJournalIsPressed(JournalWindow window)
        {
            _journalWindow = window;
            _addToJournalWindow = new AddToJournalWindow(_journalWindow);
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
            _journalWindow = new JournalWindow(_homeWindow, _journal);
            _journalWindow.Show();
        }


        public void CancelButtonIsPressed()
        {
            //_addToJournalWindow.ShowCancelMessage();
        }

        public void ConfirmIsPressed()
        {
            //_addToJournalWindow.Close();

            //Den her show er ikke i sekvensdiagrammet, men tror måske den skal med for at give mening? :)
            //_journalWindow.Show();
        }

        public void DenyIsPressed()
        {
            //_addToJournalWindow.CloseCancelMessage();
        }

        public void SaveNewJournalData()
        {
            //new journal domæneklasse skal laves her
            //_saveDatabase.SaveJournal(den nye journal);
            //_addToJournalWindow.Close();
            //_journalWindow.Show();
        }
    }
}
