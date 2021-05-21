using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientBusiness;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    public class TrainingReminderControl
    {
        private ISaveDatabase _saveDatabase;
        private Patient _patient;

        public TrainingReminderControl(Patient patient)
        {
            _patient = patient;
            _saveDatabase = new SaveDatabase(_patient);
        }

        public TrainingReminderControl(ISaveDatabase saveDatabase)
        {
            _saveDatabase = saveDatabase;
        }

        public void IntervalSet(int interval)
        {
            _saveDatabase.SaveInterval(interval);
        }
    }
}