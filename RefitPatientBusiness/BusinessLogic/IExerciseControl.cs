namespace ReFitPatientBusiness
{
    /// <summary>
    /// interface for excercisecontrol
    /// </summary>
    public interface IExerciseControl
    {
        /// <summary>
        /// sender den indtastede kommentar videre med øvelsensid
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="exerciseID"></param>
        public void SaveIsPressed(string comment, int exerciseID);
    }
}