using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    /// <summary>
    /// interface til updatejournalcontrol
    /// </summary>
    public interface IUpdateJournalControl
    {
        /// <summary>
        /// se updatejournalcontrols metode med samme navn
        /// </summary>
        /// <param name="journal"></param>
        public void SaveNewJournalData(Journal journal);
    }
}