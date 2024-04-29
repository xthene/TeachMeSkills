using Allure.NUnit;
using TestRail.Utils;

namespace TestRail.Test
{
    [TestFixture]
    [AllureNUnit]
    public class AddProjectTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
            LoginPage.Login(Configurator.ReadConfiguration().Username, Configurator.ReadConfiguration().Password);
            MainPage.AddProjectButtonClick();
        }

        [Test]
        public void AddCorrectProjectTest()
        {
            AddProjectPage.AddProjectWithRequiredFields("ESiniak", "Tester");

            Assert.That(ProjectsPage.SuccessMessage().Enabled);
        }
    }
}
