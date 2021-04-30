using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientCore;
using ReFitPatientCore.DataAccess;

namespace ReFitPatientCore.BusinessLogic
{
    public class TrainingReminderControl
    {
        private SaveDatabase _saveDatabase;
        private SetIntervalWindow _intervalWindow;
        private HomeWindow _homeWindow;
        private ReturnController _returnController;

        public TrainingReminderControl(HomeWindow homeWindow)
        {
            _homeWindow = homeWindow;
            _returnController = new ReturnController(_homeWindow);
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
