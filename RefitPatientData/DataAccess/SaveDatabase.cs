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
        private readonly PatientContext _db;
        public SaveDatabase()
        {
            _db = new PatientContext();
        }
        public void SaveComment(string comment, int exerciseID)
        {

        }

        public void SaveJournal(Journal journal)
        {
            _db.Journals.Add(journal);
            _db.SaveChanges();
        }

        public void SaveInterval(int invertal)
        {

        }
    }
}
