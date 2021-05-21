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
    public class UpdateJournalControl
    {
        private ILoadDatabase _loadDatabase;
        private ISaveDatabase _saveDatabase;
        private Journal _journal;
        private Patient _patient;

        public UpdateJournalControl(Patient patient, Journal journal)
        {
            _patient = patient;
            _journal = journal;
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase(_patient);
        }

        public UpdateJournalControl(ISaveDatabase saveDatabase)
        {
            _saveDatabase = saveDatabase;
        }

        public void SaveNewJournalData(Journal journal)
        {
            _saveDatabase.SaveJournal(journal);
        }
    }
}