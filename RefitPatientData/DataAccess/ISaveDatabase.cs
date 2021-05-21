using ReFitPatientDomain;

namespace ReFitPatientData
{
    /// <summary>
    /// interface for savedatabase
    /// </summary>
    public interface ISaveDatabase
    {
        /// <summary>
        /// gemmer kommentar til specifik øvelse(ikke implementeret) i databsen
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="exerciseID"></param>
        public void SaveComment(string comment, int exerciseID);

        /// <summary>
        /// gemmer et nyt journalnotat til patienten i databasen
        /// </summary>
        /// <param name="journal">nyt journalnotat</param>
        public void SaveJournal(Journal journal);

        /// <summary>
        /// gemmer det nye interval i databasen
        /// </summary>
        /// <param name="invertal">nyt interval</param>
        public void SaveInterval(int invertal);
    }
}