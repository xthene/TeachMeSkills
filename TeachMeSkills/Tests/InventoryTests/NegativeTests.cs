using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Tests.InventoryTests
{
    [TestFixture]
    internal class NegativeTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().SauceDemoUrl);
            LoginPage.Login(Configurator.ReadConfiguration().UserNameSauceDemo,
                Configurator.ReadConfiguration().PasswordSauceDemo);
        }
    }
}
