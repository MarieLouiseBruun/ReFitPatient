using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ReFitPatientDomain;

namespace ReFitPatientData
{
    public class SaveDatabase
    {
        private Patient _patient;
        private readonly PatientContext _db;
        public SaveDatabase(Patient patient)
        {
            _patient = patient;
            _db = new PatientContext();
        }
        public void SaveComment(string comment, int exerciseID)
        {

        }

        public void SaveJournal(Journal journal)
        {
            _patient.JournalID.Add(journal);
            _db.Patients.Update(_patient);
            _db.Journals.Add(journal);
            _db.SaveChanges();
        }

        public void SaveInterval(int invertal)
        {

        }
    }
}
