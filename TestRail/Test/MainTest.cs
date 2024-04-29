using Allure.NUnit;
using TestRail.Utils;

namespace TestRail.Test
{
    [TestFixture]
    [AllureNUnit]
    internal class MainTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
            LoginPage.Login(Configurator.ReadConfiguration().Username, Configurator.ReadConfiguration().Password);
        }
    }
}
