using NUnit.Framework;
using TeachMeSkills.Utils;

namespace TeachMeSkills.Tests
{
    [TestFixture]
    internal class LoginTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
        }

        [Test]
        public void CorrectLogin()
        {
            LoginPage.Login(Configurator.ReadConfiguration().Username, Configurator.ReadConfiguration().Password);
        }
    }
}
