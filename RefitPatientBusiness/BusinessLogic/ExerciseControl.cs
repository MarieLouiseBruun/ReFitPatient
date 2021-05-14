using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientData;
using ReFitPatientDomain;
using ReFitPatientBusiness;

namespace ReFitPatientBusiness
{
    public class ExerciseControl
    {
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;


        public ExerciseControl()
        {
            _loadDatabase = new LoadDatabase();
        }


        //public void SaveIsPressed(string comment, int exerciseID)
        //{
        //    _saveDatabase.SaveComment(comment, exerciseID);
        //    _exerciseWindow.CommentSaved();
        //}
    }
}
