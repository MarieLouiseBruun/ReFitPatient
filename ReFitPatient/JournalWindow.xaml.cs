using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReFitPatient.BusinessLogic;

namespace ReFitPatient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class JournalWindow : Window
    {
        private ReturnController _returnController;
        private HomeWindow _homeWindow;
        public JournalWindow(HomeWindow window)
        {
            _homeWindow = window;
            _returnController = new ReturnController(window);


            InitializeComponent();
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _returnController.ReturnToHome(this);
        }
    }
}
