﻿using System;
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
using ReFitPatientCore.Domain;

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
        public ExerciseWindow()
        {
            _returnController = new ReturnController();
            _exerciseControl = new ExerciseControl(window);


            InitializeComponent();
            Browser.Visibility = Visibility.Collapsed;
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

        private void playB_Click(object sender, RoutedEventArgs e)
        {
            Browser.Visibility = Visibility.Visible;
            playB.Visibility = Visibility.Collapsed;
            //Her skal den navigere til den video, der viser øvelsen
            
            Browser.Navigate(/*"https://www.youtube.com/v/u0VMfrdbuMw"*/"https://www.youtube.com/v/dQw4w9WgXcQ?start=0"/*http://www.youtube.com/v/FhZ-HsiS8aI&hl=en"*/);


        }
    }
}
