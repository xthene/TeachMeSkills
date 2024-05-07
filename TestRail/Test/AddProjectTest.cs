using NUnit.Allure.Core;
using TestRail.Utils;

namespace TestRail.Test
{
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
            string projectName = Configurator.ReadConfiguration().ProjectName;
            AddProjectPage.AddProjectWithRequiredFields(projectName, "Tester");

            Assert.That(ProjectsPage.SuccessAddProductMessage().Enabled);
        }
    }
}
