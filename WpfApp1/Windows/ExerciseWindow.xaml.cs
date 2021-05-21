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
    /// Interaction logic for ExerciseWindow.xaml
    /// </summary>
    public partial class ExerciseWindow : Window
    {
        private ExerciseControl _exerciseControl;
        private HomeWindow _homeWindow;
        private CommentExerciseWindow _commentWindow;
        private Patient _patient;
        private List<Exercise> _exerciseList;
        private int CurrentExerciseID = 0;
        private int ExerciseNumber = 1;

        private string videopath;
        /// <summary>
        /// constructor til exercisewindow, opretter de ting, der skal bruges og putter exercisepakker ind i comboboxen
        /// </summary>
        /// <param name="homewindow"></param>
        /// <param name="patient"></param>
        public ExerciseWindow(HomeWindow homewindow, Patient patient)
        {
            _patient = patient;
            _homeWindow = homewindow;
            _exerciseControl = new ExerciseControl();
            InitializeComponent();

            DescriptionTB.Text = "Vælg en øvelsespakke!";
            RepititionsTB.Text = "";
            setNumberTB.Text = "";
            browserWB.Visibility = Visibility.Collapsed;
            foreach (var item in _patient.ExercisePackages)
            {
                exercisepackageCB.Items.Add(item.Name);
            }
            exercisepackageCB.SelectedItem = exercisepackageCB.Items[0];
        }

        /// <summary>
        /// navigere tilbage til dagbosvindue når der trykkes på denne knap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backB_Click(object sender, RoutedEventArgs e)
        {
            _homeWindow.Show();
            browserWB.Navigate("https://www.google.dk"); //det her er en dum måde at gøre det på, men det virker
            Close();
        }

        /// <summary>
        /// åbner kommentarboxen til den specifikke video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCommentB_Click(object sender, RoutedEventArgs e)
        {
            _commentWindow = new CommentExerciseWindow();
            _commentWindow.ShowDialog();
        }

        //public void CommentSaved()
        //{
        //    MessageBox.Show("Kommentar gemt!");
        //}

        /// <summary>
        /// gør videoen synlig og afspiller den
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playB_Click(object sender, RoutedEventArgs e)
        {
            browserWB.Visibility = Visibility.Visible;
            playB.Visibility = Visibility.Collapsed;
            //Her skal den navigere til den video, der viser øvelsen

            //Indsæt string herunder!!

            //Her skal videopath sættes til den første øvelses path alla exercisePakage.exerciselist[1].
            //Hvornår henter vi nye exercise??
            //exercises hentes når patienten logger ind. 
            //Når man vælger en ny package i comboboxen indlæser den de nye exercise i en ny liste, hvor links også er i.

            //skal lige undersøge om det virker for real
            //videopath = "https://www.youtube.com/video?v=Xa0Swz3X1cQ"; 
            videopath = _exerciseList[CurrentExerciseID].ExerciseLink;
            browserWB.NavigateToString(NavigateToYoutube(videopath));

        }

        /// <summary>
        /// omskriver linket til videoen så webbrowseren forstår hvad den skal
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string NavigateToYoutube(string url)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html +=
                $"<iframe id='video' src= '{url}'  gesture='media' allow='encrypted - media' width='230' height='228' frameborder='0' allowfullscreen></iframe>";
            html += "</body>>/html>";

            return html;
        }

        /// <summary>
        /// navigere videre til næste øvelse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextExerciseB_Click(object sender, RoutedEventArgs e)
        {
            //if (_exerciseList[CurrentExerciseID].Hide == false)
            {
                if (CurrentExerciseID < _exerciseList.Count - 1)
                {
                    CurrentExerciseID++;
                    ExerciseNumber++;
                    DescriptionTB.Text = _exerciseList[CurrentExerciseID].Description;
                    setNumberTB.Text = Convert.ToString(_exerciseList[CurrentExerciseID].Sets);
                    RepititionsTB.Text = Convert.ToString(_exerciseList[CurrentExerciseID].Repetitions);
                    ExerciseTB.Text = Convert.ToString(ExerciseNumber);
                    browserWB.Visibility = Visibility.Collapsed;
                    playB.Visibility = Visibility.Visible;
                    browserWB.NavigateToString("www.google.com");
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

        /// <summary>
        /// navigere videre til forige øvelse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastExerciseB_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentExerciseID > 0)
            {
                CurrentExerciseID--;
                ExerciseNumber--;
                DescriptionTB.Text = _exerciseList[CurrentExerciseID].Description;
                setNumberTB.Text = Convert.ToString(_exerciseList[CurrentExerciseID].Sets);
                RepititionsTB.Text = Convert.ToString(_exerciseList[CurrentExerciseID].Repetitions);
                ExerciseTB.Text = Convert.ToString(ExerciseNumber);
                browserWB.Visibility = Visibility.Collapsed;
                playB.Visibility = Visibility.Visible;
                browserWB.NavigateToString("www.google.com");
                videopath = _exerciseList[CurrentExerciseID].ExerciseLink;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExerciseWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        /// <summary>
        /// ændrer øvelsespakke alt efter hvilken pakke, der er valgt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercisepackageCB_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            _exerciseList = new List<Exercise>();
            CurrentExerciseID = 0;
            ExerciseNumber = 1;
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
            DescriptionTB.Text = _exerciseList[CurrentExerciseID].Description;
            setNumberTB.Text = Convert.ToString(_exerciseList[CurrentExerciseID].Sets);
            RepititionsTB.Text = Convert.ToString(_exerciseList[CurrentExerciseID].Repetitions);
            ExerciseTB.Text = Convert.ToString(ExerciseNumber);
            videopath = _exerciseList[CurrentExerciseID].ExerciseLink;
            browserWB.Visibility = Visibility.Collapsed;
            playB.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event på hvad der skal ske når vinduet lukkes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExerciseWindow_OnClosed(object? sender, EventArgs e)
        {
            browserWB.Process.Terminate();
        }
    }
}
