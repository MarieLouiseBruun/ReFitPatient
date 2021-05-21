using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;
using ReFitPatientCore;
using ReFitPatientData;
using ReFitPatientBusiness;
using ReFitPatientDomain;

namespace ReFitPatientTest
{
    class UpdateJournalControlTest
    {
        private UpdateJournalControl uut;
        private ISaveDatabase _saveDatabase;
        private Journal _journal;
        [SetUp]
        public void Setup()
        {
            _journal = new Journal(){BendAngle=20,GeneralComment = "Hej",JournalDate = DateTime.Now,JournalID = 10,JournalType = "Knæ",Medicine = "Ingen",PainScale = 5};
            _saveDatabase = Substitute.For<ISaveDatabase>();
            uut = new UpdateJournalControl(_saveDatabase);
        }
        [Test]
        public void SaveJournal_SaveNewJournalDateIsCalled_RecievesOne()
        {
            uut.SaveNewJournalData(_journal);
            _saveDatabase.Received(1).SaveJournal(_journal);
        }
    }
}
