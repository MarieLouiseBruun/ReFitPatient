using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReFitPatient.BusinessLogic
{
    class ReturnController
    {
        private HomeWindow _homeWindow;
        public void ReturnToHome(Window window)
        {
            window.Close();
            _homeWindow.Show();
        }
    }
}
