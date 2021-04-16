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
        public ExerciseWindow(HomeWindow window)
        {
            _returnController = new ReturnController(window);
            _exerciseControl = new ExerciseControl(window);


            InitializeComponent();
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            //Vi har isoleret return logikken til en klasse, og set, om vi kan lukke det vindue, hvor metoden bliver kaldt fra
            _returnController.ReturnToHome(this);
        }

        private void addCommentB_Click(object sender, RoutedEventArgs e)
        {
            //EXERCISEID = 1 ER BARE FOR AT UNDGÅ FEJL!!!!
            _exerciseControl.CommentExerciseIsPressed(this,1);
        }

        public void CommentSaved()
        {
            MessageBox.Show("Kommentar gemt!");
        }

        public void OpenCommentBox()
        {
            //DET ER DET SAMME HERNEDE LISSSOMM!!!
            _exerciseControl.CommentExerciseIsPressed(this,2);
            //Den skal åbne en ny textbox eller vindue, hvor man kan skrive I.
            //Når man har skrevet hvad man vil trykker man OK, og SaveIsPressed kaldes fra ExerciseController
            //Her har den exerciseID med samt kommentaren, og dette gemmes i databasen
        }
    }
}
