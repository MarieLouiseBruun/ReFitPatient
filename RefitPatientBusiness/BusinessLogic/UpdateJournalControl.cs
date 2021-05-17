using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ReFitPatientBusiness;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    public class UpdateJournalControl :IUpdateJournalControl
    {
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        private Patient _patient;

        public UpdateJournalControl(Patient patient)
        {
            _patient = patient;
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase(_patient);
        }

        public void SaveNewJournalData(Journal journal)
        {
            _saveDatabase.SaveJournal(journal);
        }
    }
}
