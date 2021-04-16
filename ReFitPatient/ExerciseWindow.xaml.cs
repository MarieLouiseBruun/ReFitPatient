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
    public partial class ExerciseWindow : Window
    {
        private ReturnController _returnController;
        private ExerciseControl _exerciseControl;
        public ExerciseWindow()
        {
            InitializeComponent();
            _returnController = new ReturnController();
            _exerciseControl = new ExerciseControl();
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            //Vi har isoleret return logikken til en klasse, og set, om vi kan lukke det vindue, hvor metoden bliver kaldt fra
            _returnController.ReturnToHome(this);
        }

        private void addCommentB_Click(object sender, RoutedEventArgs e)
        {
            _exerciseControl.CommentExerciseIsPressed();
        }
    }
}
