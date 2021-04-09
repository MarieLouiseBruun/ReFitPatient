using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.DataAccess;

namespace ReFitPatient.BusinessLogic
{
    class TrainingReminderControl
    {
        private SaveDatabase _saveDatabase;
        public void OptionButtonIsPressed()
        {
            //_journalWindow.Show();

        }

        public void IntervalSet(int interval)
        {
            _saveDatabase.SaveInterval(interval);
            //interval i parameter (som int, timer, dage måske?)
            //_journalWindow.Close();
        }
    }
}
