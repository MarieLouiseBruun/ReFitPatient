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
using ReFitPatientBusiness;
using ReFitPatientDomain;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ExerciseWindow : Window
    {
        private ReturnController _returnController;
        private ExerciseControl _exerciseControl;


        private ExerciseWindow _exerciseWindow;
        private HomeWindow _homeWindow;
        private CommentExerciseWindow _commentWindow;
        private Patient _patient;
        private List<Exercise> _exerciseList;
        private List<ExercisePackage> _exercisePackage;
        private int CurrentExerciseID;
        public ExerciseWindow(HomeWindow homewindow)
        {
            _homeWindow = homewindow;
            _returnController = new ReturnController();
            _exerciseControl = new ExerciseControl();


            InitializeComponent();
            Browser.Visibility = Visibility.Collapsed;
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _homeWindow.Show();
            this.Close();
        }

        private void addCommentB_Click(object sender, RoutedEventArgs e)
        {
            _commentWindow = new CommentExerciseWindow();
            _commentWindow.ShowDialog();
            //EXERCISEID = 1 ER BARE FOR AT UNDGÅ FEJL!!!!
        }

        public void CommentSaved()
        {
            MessageBox.Show("Kommentar gemt!");
        }

        private void playB_Click(object sender, RoutedEventArgs e)
        {
            Browser.Visibility = Visibility.Visible;
            playB.Visibility = Visibility.Collapsed;
            //Her skal den navigere til den video, der viser øvelsen
            _exerciseControl.PlayIsPressed();

            //Indsæt string herunder!!
            Browser.Navigate(/*"https://www.youtube.com/v/u0VMfrdbuMw"*/"https://www.youtube.com/v/dQw4w9WgXcQ?start=0"/*http://www.youtube.com/v/FhZ-HsiS8aI&hl=en"*/);


        }
    }
}
