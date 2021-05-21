using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    /// <summary>
    /// interfacet til Logincontrolleren
    /// </summary>
    public interface ILoginControl
    {
        /// <summary>
        /// se loginControl  med samme metodenavn
        /// </summary>
        /// <param name="SSN"></param>
        /// <returns></returns>
        public bool CheckSSN(string SSN);

        /// <summary>
        /// se loginControl  med samme metodenavn
        /// </summary>
        /// <param name="ssr"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        public Patient GetPatientInfo(string ssr, string pw);

        /// <summary>
        /// se loginControl med samme metodenavn
        /// </summary>
        /// <param name="SSN"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool LoginButtonIsPressed(string SSN, string Password);
    }
}