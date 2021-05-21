using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ReFitPatientDomain;

namespace ReFitPatientData
{
    public class SaveDatabase :ISaveDatabase
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
            _patient.Journals.Add(journal);
            _db.Patients.Attach(_patient);
            _db.Entry(_patient).Collection(x => x.Journals).IsModified = true;
            _db.SaveChanges();
        }

        public void SaveInterval(int invertal)
        {

        }
    }
}
