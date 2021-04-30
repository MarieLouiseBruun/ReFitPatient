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
        private ReturnController _returnController;

        public TrainingReminderControl()
        {
            _returnController = new ReturnController();
            _saveDatabase = new SaveDatabase();
        }
        public void SetIntervalBIsPressed()
        {
            _intervalWindow = new SetIntervalWindow(this);
            _intervalWindow.Show();
            _homeWindow.Hide();
        }

        public void IntervalSet(int interval)
        {
            _saveDatabase.SaveInterval(interval);
            _homeWindow.Show();
            _intervalWindow.Close();
        }

        public void CancelIntervalUpdate()
        {
            _returnController.ReturnToHome(_intervalWindow);
        }
    }
}
