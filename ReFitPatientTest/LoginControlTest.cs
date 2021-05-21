using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using ReFitPatientBusiness;
using ReFitPatientData;
using ReFitPatientDomain;

namespace ReFitPatientTest
{
    public class Tests
    {
        private bool SSRresult;
        private LoginControl uut;
        private ILoadDatabase _loadDatabase;
        [SetUp]
        public void Setup()
        {

            _loadDatabase = Substitute.For<ILoadDatabase>();
            uut = new LoginControl(_loadDatabase);
        }

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


        [TestCase("1234567890")]
        public void CheckSSR_SSRis10_ReturnsTrue(string a)
        {
            SSRresult = uut.CheckSSN(a);
            Assert.That(SSRresult, Is.True);
        }

        [TestCase("12345678901")]
        [TestCase("123456789012")]
        [TestCase("123456789013")]
        public void CheckSSR_SSRtoolong_ReturnsFalse(string a)
        {
            SSRresult = uut.CheckSSN(a);
            Assert.That(SSRresult, Is.False);
        }


        [TestCase("1234567890","abc")]
        public void ValidateLogin_LoginButtonIsPressedCallsValidateLogin_RecievesOne(string a, string b)
        {
            uut.LoginButtonIsPressed(a,b);
            _loadDatabase.Received(1).ValidateLogin(a,b);
        }
        [TestCase("1234567890","abc")]
        public void LoadPatientInfo_GetPatientInfoIsCalled_RecievesOne(string a, string b)
        {
            uut.GetPatientInfo(a, b);
            _loadDatabase.Received(1).LoadPatientInfo(a, b);
        }
        [TestCase("1234567890","abc")]
        public void GetPatientInfo_ReturnsSamePatientAsLoadPatientInfo_IsTrue(string a, string b)
        {
            Patient patient = new Patient();
            _loadDatabase.LoadPatientInfo(a, b).Returns(patient);
            Patient result = uut.GetPatientInfo(a, b);
            Assert.That(result, Is.EqualTo(patient));
        }

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