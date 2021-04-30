using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientData;
using ReFitPatientCore.Domain;
using ReFitPatientBusiness;

namespace ReFitPatientBusiness
{
    public class ExerciseControl
    {
        //private ExerciseWindow _exerciseWindow;
        //private HomeWindow _homeWindow;
        //private CommentExerciseWindow _commentWindow;
        //private Patient _patient;
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        //private List<Exercise> _exerciseList;
        //private List<ExercisePackage> _exercisePackage;
        //private int CurrentExerciseID;

        public ExerciseControl()
        {
            _loadDatabase = new LoadDatabase();
            _saveDatabase = new SaveDatabase();
        }
        public void WatchExerciseIsPressed()
        {
            //Her skal der hentes ExercisePackesIDs fra patienten der er logget ind

            //_exerciseWindow.ShowPackageIDs();;
            //Den skal vel have noget med som parameter?
        }

        public void PackageChosen()
        {
            //Skal vel have et ID med i parameter??
            //_loadDatabase.LoadPackageInfo(ExercisePackageID);
            
            //ny exercisePackage domæneklasse oprettes her - denne nye package skal løbes igennem for exercises og oprette domæne exercises

            //foreach (var Exercise in ExercisePackage)
            //{
            //    _loadDatabase.GetExercise(ExerciseID);
            //    ny exercise domæneklasse 
            //}

            //_exerciseWindow.ShowExerciseInformation();
        }

        public void PlayIsPressed(string URL)
        {
            //string link i parameter måske
            //_exerciseWindow.PlayVideo();
        }

        public void CommentExerciseIsPressed(ExerciseWindow exerciseWindow, int exerciseID)
        {
            _exerciseWindow = exerciseWindow;
            CurrentExerciseID = exerciseID;
            _commentWindow = new CommentExerciseWindow(this);
            _commentWindow.ShowDialog();
        }

        public void SaveIsPressed(string comment)
        {
            _saveDatabase.SaveComment(comment, CurrentExerciseID);
            _exerciseWindow.CommentSaved();
        }
    }
}
