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
using ReFitPatient.Domain;

namespace ReFitPatient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddToJournalWindow : Window
    {
        private ReturnController _returnController;
        private JournalWindow _journalWindow;
        private Journal newJournal;
        private UpdateJournalControl _updateJournalControl;
        public AddToJournalWindow(JournalWindow window, UpdateJournalControl journalControl)
        {
            _journalWindow = window;
            _returnController = new ReturnController(window);
            _updateJournalControl = journalControl;
            InitializeComponent();
            if (_journalWindow.journalCB.Text == "Knæalloplastik")
            {
                overskriftL.Content = "Dagbog for knæalloplastik";
                scaleTB.Text = "Hvor meget smerte oplever du i dit knæ på en skala fra 1 - 10 ?";
                vinkelTBL.Text = "Hvor mange grader kan du bøje dit knæ i?";
            }
            else if (_journalWindow.journalCB.Text == "Hofte")
            {
                overskriftL.Content = "Dagbog for hofte";
                scaleTB.Text = "Hvor meget smerte oplever du i din hofte på en skala fra 1 - 10?";
                vinkelTBL.Visibility = Visibility.Collapsed;
            }
            else if (_journalWindow.journalCB.Text == "Albue")
            {
                overskriftL.Content = "Dagbog for albue";
                scaleTB.Text = "Hvor meget smerte oplever du i din albue på en skala fra 1 - 10?";
                vinkelTBL.Text = "Hvor mange grader kan du bøje din albue i?";
            }
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _returnController.ReturnToJournalWindow(this);
        }

        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            newJournal = new Journal(_journalWindow.journalCB.Text, painS.Value, Convert.ToDouble(vinkelTB.Text),medicinTB.Text
                ,generelTB.Text);
            _updateJournalControl.SaveNewJournalData(newJournal);
        }

        private void AnnullerB_OnClick(object sender, RoutedEventArgs e)
        {
            _updateJournalControl.CancelButtonIsPressed();
        }
    }
}
