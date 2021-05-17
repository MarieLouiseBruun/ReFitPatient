using ReFitPatientDomain;

namespace ReFitPatientBusiness
{
    public interface ILoginControl
    {
        public bool CheckSSN(string SSN);

        public Patient GetPatientInfo(string ssr, string pw);

        public bool LoginButtonIsPressed(string SSN, string Password);
    }
}