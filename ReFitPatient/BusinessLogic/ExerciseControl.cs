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
        private Patient _patient;
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;
        private List<Exercise> _exerciseList;
        private List<ExercisePackage> _exercisePackage;
        public void WatchExerciseIsPressed()
        {
            //ExerciseWindow.Show();
            //HomeWindow.Close();
        }

        public void PackageChosen()
        {
            //Skal vel have et ID med i parameter??
            //_loadDatabase.LoadPackageInfo(ExercisePackageID);
        }

        public void PlayIsPressed(string URL)
        {
            //string link i parameter måske
        }

        public void CommentExerciseIsPressed()
        {
            //ExerciseWindow.OpenCommentBox();
        }

        public void OKIsPressed(int exerciseID, string comment)
        {
            _saveDatabase.SaveComment(comment,exerciseID);
            //ExerciseWindow.CommentSaved();
        }
    }
}
