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
    public partial class AddToJournalWindow : Window
    {
        private ReturnController _returnController;
        private JournalWindow _journalWindow;
        private UpdateJournalControl _updateJournalControl;
        public AddToJournalWindow(JournalWindow window, UpdateJournalControl journalControl)
        {
            _journalWindow = window;
            _returnController = new ReturnController(window);
            _updateJournalControl = journalControl;
            InitializeComponent();
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _returnController.ReturnToJournalWindow(this);
        }

        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            _updateJournalControl.SaveNewJournalData();
        }

        private void AnullerB_OnClick(object sender, RoutedEventArgs e)
        {
            _updateJournalControl.CancelButtonIsPressed();
        }
    }
}
