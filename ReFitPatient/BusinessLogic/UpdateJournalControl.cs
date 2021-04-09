using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.DataAccess;
using ReFitPatient.Domain;

namespace ReFitPatient.BusinessLogic
{
    class UpdateJournalControl
    {
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        public void UpdateJournalIsPressed()
        {
            //_homeWindow.Close();
            //_loadDatabase.GetPreviousJournalInformation();
            //_journalWindow.Show();
        }

        public void ExercisePackageJournalChosen()
        {
            //Tror vi skal kigge på vores sekvensdiagram her..
        }
        public void JournalButtonIsPressed()
        {
            //_addToJournalWindow.Show();
            //_journalWindow.Close();
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
