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
    public class ExerciseControl : IExerciseControl
    {
        private SaveDatabase _saveDatabase;
        private Patient _patient;

        public ExerciseControl(Patient patient)
        {
            _patient = patient;
            _saveDatabase = new SaveDatabase(_patient);
        }

        //Her skulle muligheden for at gemme en konkret kommentar til en øvelses implementeres
        public void SaveIsPressed(string comment, int exerciseID)
        {
            _saveDatabase.SaveComment(comment, exerciseID);
        }
    }
}
