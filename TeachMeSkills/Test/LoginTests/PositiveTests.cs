using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test.LoginTests
{
    [TestFixture]
    public class PositiveTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().SauceDemoUrl);
        }

        [Test]
        public void LoginTest()
        {
            LoginPage.Login(Configurator.ReadConfiguration().UserNameSauceDemo, 
                Configurator.ReadConfiguration().PasswordSauceDemo);

            Assert.That(InventoryPage.ProductsTitle().Displayed, Is.True);
        }

    }
}
