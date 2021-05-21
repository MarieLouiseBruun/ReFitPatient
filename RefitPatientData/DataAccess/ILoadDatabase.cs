using ReFitPatientDomain;

namespace ReFitPatientData
{
    public interface ILoadDatabase
    {

        public Patient LoadPatientInfo(string SSN, string PW);

        public bool ValidateLogin(string SSN, string Password);
    }
}