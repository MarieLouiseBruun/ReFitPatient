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
    /// <summary>
    /// Bruges ikke pt, men hvis der skal kunne kommenteres på enkelte øvelser, vil gemme-delen gå igennem den her.
    /// </summary>
    public class ExerciseControl
    {
        private LoadDatabase _loadDatabase;
        private SaveDatabase _saveDatabase;

        /// <summary>
        /// constructor til exercisecontrol
        /// </summary>
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