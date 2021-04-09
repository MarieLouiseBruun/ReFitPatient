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

        }

        public void PackageChosen()
        {

        }

        public void PlayIsPressed()
        {
            //string link i parameter måske
        }

        public void CommentExerciseIsPressed()
        {

        }

        public void OKIsPressed()
        {
            //string kommentar fra tekstboks some parameter
        }
    }
}
