using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReFitPatientBusiness;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    /// <summary>
    /// controller til UC4 sæt træningsinterval. fører det indtastede fra præsentationslogic videre til dataAccesLogik 
    /// </summary>
    public class TrainingReminderControl
    {
        private ISaveDatabase _saveDatabase;
        private Patient _patient;
        /// <summary>
        /// construktor hvor savedatabase er det medfulgte parameter
        /// </summary>
        /// <param name="patient"></param>
        public TrainingReminderControl(Patient patient)
        {
            _patient = patient;
            _saveDatabase = new SaveDatabase(_patient);
        }
        /// <summary>
        /// construktor hvor savedatabase er det medfulgte parameter
        /// </summary>
        /// <param name="saveDatabase"></param>
        public TrainingReminderControl(ISaveDatabase saveDatabase)
        {
            _saveDatabase = saveDatabase;
        }
        /// <summary>
        /// kalder videre til dataAccesLogic når dagsinterval skal gemmes
        /// </summary>
        /// <param name="interval">det nye dagsintervallet mellem træninger</param>
        public void IntervalSet(int interval)
        {
            _saveDatabase.SaveInterval(interval);
        }
    }
}