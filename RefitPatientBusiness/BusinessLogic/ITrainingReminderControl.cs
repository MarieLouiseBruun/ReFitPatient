namespace ReFitPatientBusiness
{
    /// <summary>
    /// interface for sæt intervals controller
    /// </summary>
    public interface ITrainingReminderControl
    {
        /// <summary>
        /// sender det indtastede interval videre
        /// </summary>
        /// <param name="interval"></param>
        public void IntervalSet(int interval);
    }
}