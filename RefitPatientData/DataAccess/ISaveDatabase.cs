using ReFitPatientDomain;

namespace ReFitPatientData
{
    public interface ISaveDatabase
    {

        public void SaveComment(string comment, int exerciseID);

        public void SaveJournal(Journal journal);
        public void SaveInterval(int invertal);
    }
}