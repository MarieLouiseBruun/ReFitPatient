﻿using System;
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
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        private Journal _journal;
        private Patient _patient;

        public UpdateJournalControl(Patient patient, Journal journal)
        {
            _patient = patient;
            _journal = journal;
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase(_patient);
        }

        public void ExercisePackageJournalChosen()
        {
            //Tror vi skal kigge på vores sekvensdiagram her..
        }


      


        public void SaveNewJournalData(Journal journal)
        {
            _saveDatabase.SaveJournal(journal);

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
