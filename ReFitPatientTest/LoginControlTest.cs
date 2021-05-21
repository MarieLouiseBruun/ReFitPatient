using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using ReFitPatientBusiness;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientTest
{
    /// <summary>
    /// testes til logincontrolleren
    /// </summary>
    public class Tests
    {
        private bool SSRresult;
        private LoginControl uut;
        private ILoadDatabase _loadDatabase;
       /// <summary>
       /// sætter testsenariet op
       /// </summary>
        [SetUp]
        public void Setup()
        {
            _loadDatabase = Substitute.For<ILoadDatabase>();
            uut = new LoginControl(_loadDatabase);
        }

       /// <summary>
       /// tester om logincontrolleren siger at cprnummeret er for kort
       /// </summary>
       /// <param name="a">cprnummer</param>
        [TestCase("1")]
        [TestCase("12")]
        [TestCase("123")]
        [TestCase("1234")]
        [TestCase("12345")]
        [TestCase("1234567")]
        [TestCase("1234567")]
        [TestCase("12345678")]
        [TestCase("123456789")]
        public void CheckSSR_SSRtooshort_ReturnsFalse(string a)
        {
            SSRresult = uut.CheckSSN(a);
            Assert.That(SSRresult, Is.False);
        }

        /// <summary>
        /// tester at det indtastede er 10 tegn præcist
        /// </summary>
        /// <param name="a">cprnummer</param>
        [TestCase("1234567890")]
        public void CheckSSR_SSRis10_ReturnsTrue(string a)
        {
            SSRresult = uut.CheckSSN(a);
            Assert.That(SSRresult, Is.True);
        }

        /// <summary>
        /// tester at det indtastede er for langt og metoden returnere derfor false
        /// </summary>
        /// <param name="a"></param>
        [TestCase("12345678901")]
        [TestCase("123456789012")]
        [TestCase("123456789013")]
        public void CheckSSR_SSRtoolong_ReturnsFalse(string a)
        {
            SSRresult = uut.CheckSSN(a);
            Assert.That(SSRresult, Is.False);
        }

        /// <summary>
        /// tester om loaddatabase modtager cpr som den første og password som den anden
        /// </summary>
        /// <param name="a">cpr</param>
        /// <param name="b">password</param>
        [TestCase("1234567890","abc")]
        public void ValidateLogin_LoginButtonIsPressedCallsValidateLogin_RecievesOne(string a, string b)
        {
            uut.LoginButtonIsPressed(a,b);
            _loadDatabase.Received(1).ValidateLogin(a,b);
        }
        /// <summary>
        /// tjekker om getpatientinfo bliver kaldt en gang
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [TestCase("1234567890","abc")]
        public void LoadPatientInfo_GetPatientInfoIsCalled_RecievesOne(string a, string b)
        {
            uut.GetPatientInfo(a, b);
            _loadDatabase.Received(1).LoadPatientInfo(a, b);
        }
        /// <summary>
        /// tjekker om der bliver retuneret en patient
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [TestCase("1234567890","abc")]
        public void GetPatientInfo_ReturnsSamePatientAsLoadPatientInfo_IsTrue(string a, string b)
        {
            Patient patient = new Patient();
            _loadDatabase.LoadPatientInfo(a, b).Returns(patient);
            Patient result = uut.GetPatientInfo(a, b);
            Assert.That(result, Is.EqualTo(patient));
        }

        /// <summary>
        /// tester om det er den samme patient der bliver returneret
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase("1234567890", "abc","1234567891")]
        public void GetPatientInfo_ReturnsSamePatientAsLoadPatientInfo_IsFalse(string a, string b,string c)
        {
            Patient patient = new Patient();
            _loadDatabase.LoadPatientInfo(a, b).Returns(patient);
            Patient result = uut.GetPatientInfo(c, b);
            Assert.That(result, Is.Not.EqualTo(patient));
        }
    }
}