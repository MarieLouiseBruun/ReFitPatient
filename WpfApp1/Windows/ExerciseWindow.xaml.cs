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
        private ExerciseControl _exerciseControl;
        private HomeWindow _homeWindow;
        private CommentExerciseWindow _commentWindow;
        private Patient _patient;
        private List<Exercise> _exerciseList;
        private int CurrentExerciseID = 0;
        private string videopath;

        public ExerciseWindow(HomeWindow homewindow, Patient patient)
        {
            _patient = patient;
            _homeWindow = homewindow;
            _exerciseControl = new ExerciseControl();
            InitializeComponent();

            welcomeL.Text = "Vælg en øvelsespakke!";
            repNumberL.Content = "";
            setNUmberL.Content = "";
            browserWB.Visibility = Visibility.Collapsed;
            foreach (var item in _patient.ExercisePackages)
            {
                exercisepackageCB.Items.Add(item.Name);
            }
        }

        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _homeWindow.Show();
            browserWB.Navigate("https://www.google.dk"); //det her er en dum måde at gøre det på, men det virker
            Close();
        }

        private void addCommentB_Click(object sender, RoutedEventArgs e)
        {
            _commentWindow = new CommentExerciseWindow();
            _commentWindow.ShowDialog();
        }

        public void CommentSaved()
        {
            MessageBox.Show("Kommentar gemt!");
        }

        private void playB_Click(object sender, RoutedEventArgs e)
        {
            browserWB.Visibility = Visibility.Visible;
            playB.Visibility = Visibility.Collapsed;
            //Her skal den navigere til den video, der viser øvelsen
            _exerciseControl.PlayIsPressed();

            //Indsæt string herunder!!

            //Her skal videopath sættes til den første øvelses path alla exercisePakage.exerciselist[1].
            //Hvornår henter vi nye exercise??
            videopath = "https://www.youtube.com/v/dQw4w9WgXcQ?start=0";
            browserWB.Navigate(videopath);


        }

        private void nextExerciseB_Click(object sender, RoutedEventArgs e)
        {
            //if (_exerciseList[CurrentExerciseID].Hide == false)
            {
                if (CurrentExerciseID < _exerciseList.Count-1)
                {
                    CurrentExerciseID++;
                    welcomeL.Text = _exerciseList[CurrentExerciseID].Description;
                    setNUmberL.Content = _exerciseList[CurrentExerciseID].Sets;
                    repNumberL.Content = _exerciseList[CurrentExerciseID].Repetitions;
                    exercise1L.Content = _exerciseList[CurrentExerciseID].ExerciseID;
                    videopath = _exerciseList[CurrentExerciseID].ExerciseLink;
                }
                else
                {
                    MessageBox.Show("Træning gennemført! Godt gået :-)");
                    this.Close();
                    _homeWindow.Show();
                }
            }
        }

        private void lastExerciseB_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentExerciseID > 0)
            {
                CurrentExerciseID--;
                welcomeL.Text = _exerciseList[CurrentExerciseID].Description;
                setNUmberL.Content = _exerciseList[CurrentExerciseID].Sets;
                repNumberL.Content = _exerciseList[CurrentExerciseID].Repetitions;
                exercise1L.Content = _exerciseList[CurrentExerciseID].ExerciseID;
                videopath = _exerciseList[CurrentExerciseID].ExerciseLink;
            }
        }

        private void exercisepackageCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _exerciseList = new List<Exercise>();
            CurrentExerciseID = 0;
            foreach (var item in _patient.ExercisePackages)
            {
                if (Convert.ToString(exercisepackageCB.SelectedItem) == item.Name)
                {
                    foreach (var itemm in item.Exercises)
                    {
                        _exerciseList.Add(itemm);
                    }
                }
            }
            welcomeL.Text = _exerciseList[CurrentExerciseID].Description;
            setNUmberL.Content = _exerciseList[CurrentExerciseID].Sets;
            repNumberL.Content = _exerciseList[CurrentExerciseID].Repetitions;
            exercise1L.Content = _exerciseList[CurrentExerciseID].ExerciseID;
            videopath = _exerciseList[CurrentExerciseID].ExerciseLink;
        }
    }
}
