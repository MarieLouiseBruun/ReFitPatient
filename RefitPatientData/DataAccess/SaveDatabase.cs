using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ReFitPatientDomain;

namespace ReFitPatientData
{
    /// <summary>
    /// gemmer i databasen
    /// </summary>
    public class SaveDatabase :ISaveDatabase
    {

        private Patient _patient;
        private readonly PatientContext _db;
        /// <summary>
        /// constructor med patient som parameter, for at indikere hvilken patient, der skal gemmes ved.
        /// </summary>
        /// <param name="patient">patienten der er logget ind</param>
        public SaveDatabase(Patient patient)
        {
            _patient = patient;
            _db = new PatientContext();
        }

        /// <summary>
        /// gemmer en kommentar til en specifik øvelse(ikke implementeret) i databasen
        /// </summary>
        /// <param name="comment">kommentar</param>
        /// <param name="exerciseID">hvilken øvelse, der skal knyttes kommentar til</param>
        public void SaveComment(string comment, int exerciseID)
        {

        }

        /// <summary>
        /// gemmer et ny journalnotat i databasen
        /// </summary>
        /// <param name="journal"></param>
        public void SaveJournal(Journal journal)
        {
            _patient.Journals.Add(journal);
            _db.Patients.Attach(_patient);
            _db.Entry(_patient).Collection(x => x.Journals).IsModified = true;
            _db.SaveChanges();
        }

        /// <summary>
        /// gemmer interval mellem træningspåmindelser i databasen(ikke implemnteret)
        /// </summary>
        /// <param name="invertal"></param>
        public void SaveInterval(int invertal)
        {

        }
    }
}
