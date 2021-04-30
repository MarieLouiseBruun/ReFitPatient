using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReFitPatient.BusinessLogic
{
    public class ReturnController
    {
        private HomeWindow _homeWindow;
        private JournalWindow _journalWindow;
        public ReturnController(HomeWindow window)
        {
            _homeWindow = window;
        }

        public ReturnController(JournalWindow window2)
        {
            _journalWindow = window2;
        }
        public void ReturnToHome(Window window)
        {
            window.Close();
            _homeWindow.Show();
        }

        public void ReturnToJournalWindow(Window window)
        {
            window.Close();
            _journalWindow.Show();
        }
    }
}
