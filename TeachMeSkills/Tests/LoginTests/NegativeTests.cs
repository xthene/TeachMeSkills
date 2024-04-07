using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test.LoginTests
{
    [TestFixture]
    public class NegativeTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().SauceDemoUrl);
        }

        [Test]
        public void LoginWithIncorrectPassword()
        {
            LoginPage.Login(Configurator.ReadConfiguration().UserNameSauceDemo, Configurator.ReadConfiguration().IncorrectPasswordSauceDemo);

            Assert.That(LoginPage.ErrorTitle().Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        public void LoginWithoutPassword()
        {
            LoginPage.Login(Configurator.ReadConfiguration().UserNameSauceDemo);

            Assert.That(LoginPage.ErrorTitle().Text, Is.EqualTo("Epic sadface: Password is required"));
        }
    }
}
