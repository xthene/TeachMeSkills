using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Tests.LoginTests
{
    [TestFixture]
    public class PositiveTests : BaseTest
    {
        [SetUp]
        public void SetUp()
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
