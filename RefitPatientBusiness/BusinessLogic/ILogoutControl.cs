namespace ReFitPatientBusiness
{
    /// <summary>
    /// interface til logoutcontroller
    /// </summary>
    public interface ILogoutControl
    {
        /// <summary>
        /// skal (senere) sørge for at den patient, der har været logget inds informationer ikke er med
        /// </summary>
        public void LogoutIsPressed();
    }
}