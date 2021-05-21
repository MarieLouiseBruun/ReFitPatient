using ReFitPatientDomain;

namespace ReFitPatientData
{
    /// <summary>
    /// interface for loaddatbase
    /// </summary>
    public interface ILoadDatabase
    {
        /// <summary>
        /// tjekker databasen for om en patient med det indtastede cpr og password findes i databasen
        /// </summary>
        /// <param name="SSN"></param>
        /// <param name="PW"></param>
        /// <returns></returns>
        public Patient LoadPatientInfo(string SSN, string PW);

        /// <summary>
        /// tjekker om de indtastede informationer er valide
        /// </summary>
        /// <param name="SSN"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool ValidateLogin(string SSN, string Password);
    }
}