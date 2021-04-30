using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientBusiness;
using ReFitPatientData;

namespace ReFitPatientBusiness
{
    public class TrainingReminderControl
    {
        private SaveDatabase _saveDatabase;

        public TrainingReminderControl()
        {
            _saveDatabase = new SaveDatabase();
        }

        public void IntervalSet(int interval)
        {
            _saveDatabase.SaveInterval(interval);
        }
    }
}
