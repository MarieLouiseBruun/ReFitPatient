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
    /// <summary>
    /// controller til UC3 opdater dagbog
    /// </summary>
    public class UpdateJournalControl
    {
        private ILoadDatabase _loadDatabase;
        private ISaveDatabase _saveDatabase;
        private Journal _journal;
        private Patient _patient;

        /// <summary>
        /// constructor til klassen som får patienten dagbogsinformationerne skal kobles til med
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="journal"></param>
        public UpdateJournalControl(Patient patient, Journal journal)
        {
            _patient = patient;
            _journal = journal;
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase(_patient);
        }
        /// <summary>
        /// constructor, der bruges til test
        /// </summary>
        /// <param name="saveDatabase"></param>
        public UpdateJournalControl(ISaveDatabase saveDatabase)
        {
            _saveDatabase = saveDatabase;
        }
        /// <summary>
        /// Sender journal videre til savedatabase så det nye dagbogsnotat kan blive gemt
        /// </summary>
        /// <param name="journal">nyt dagbogsnotat</param>
        public void SaveNewJournalData(Journal journal)
        {
            _saveDatabase.SaveJournal(journal);
        }
    }
}