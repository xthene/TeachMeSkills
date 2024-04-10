using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test.InventoryTests
{
    [TestFixture]
    internal class NegativeTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().SauceDemoUrl);
            LoginPage.Login(Configurator.ReadConfiguration().UserNameSauceDemo,
                Configurator.ReadConfiguration().PasswordSauceDemo);
        }

        [Test]
        public void Test()
        {

        }
    }
}
