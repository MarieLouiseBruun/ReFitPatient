using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatient.DataAccess;
using ReFitPatient.Domain;

namespace ReFitPatient.BusinessLogic
{
    class ExerciseControl
    {
        private ExerciseWindow _exerciseWindow;
        private HomeWindow _homeWindow;
        private Patient _patient;
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        private List<Exercise> _exerciseList;
        private List<ExercisePackage> _exercisePackage;
        public void WatchExerciseIsPressed()
        {
            _exerciseWindow.Show();
            _homeWindow.Close();
            
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

        public void CommentExerciseIsPressed()
        {
            //_exerciseWindow.OpenCommentBox();
        }

        public void OKIsPressed(int exerciseID, string comment)
        {
            _saveDatabase.SaveComment(comment,exerciseID);
            //ExerciseWindow.CommentSaved();
        }
    }
}
