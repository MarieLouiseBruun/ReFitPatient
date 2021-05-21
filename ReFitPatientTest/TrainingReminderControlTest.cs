using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;
using ReFitPatientBusiness;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientTest
{
    class TrainingReminderControlTest
    {
        private ISaveDatabase _saveDatabase;
        private TrainingReminderControl uut;
        [SetUp]
        public void Setup()
        {
            _saveDatabase = Substitute.For<ISaveDatabase>();
            uut = new TrainingReminderControl(_saveDatabase);
        }

        [TestCase(2)]
        public void SaveInterval_IntervalSetIsCalled_RecievesOne(int a)
        {
            uut.IntervalSet(a);
            _saveDatabase.Received(1).SaveInterval(a);
        }
        [TestCase(2,3)]
        public void SaveInterval_IntervalSetHasOtherInterval_DoesntRecieveSameInterval(int a, int b)
        {
            uut.IntervalSet(a);
            _saveDatabase.Received(0).SaveInterval(b);
        }
    }
}
