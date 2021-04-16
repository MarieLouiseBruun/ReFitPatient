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
    public partial class JournalWindow : Window
    {
        public Journal _journal { get; set; }
        private ReturnController _returnController;
        private HomeWindow _homeWindow;
        private UpdateJournalControl _journalControl;
        public JournalWindow(HomeWindow window, Journal journal)
        {
            _journal = journal;
            _homeWindow = window;
            _returnController = new ReturnController(window);
            _journalControl = new UpdateJournalControl(window);
            //journalinfo er bare til at prøve at binde tekst til guien, hvor journalinfoen skal være
            InitializeComponent();

            //Det her er KUN MIDLERTIDIGT!!!
            JournalinfoTB.Text = "Painscale: " +_journal.PainScale + "\r\n" + "Angle: " +_journal.BendAngle + "\r\n" + "Medicine: "+ _journal.Medicine + "\r\n" + "Exercisecomment: " +_journal.ExerciseComment + "\r\n" + "General comment: " + _journal.GeneralComment;
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _returnController.ReturnToHome(this);
        }

        private void editB_Click(object sender, RoutedEventArgs e)
        {
            _journalControl.UpdateJournalIsPressed(this);
        }
    }
}
