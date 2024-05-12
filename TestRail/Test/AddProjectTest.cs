using NUnit.Allure.Core;
using TestRail.Models;
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
            UserStep.SuccessfulLogin(new UserModel() {UserName = Configurator.ReadConfiguration().Username, Password = Configurator.ReadConfiguration().Password})
                .AddProjectButtonClick();
        }

        [Test]
        public void AddCorrectProjectTest()
        {
            var projectName = Configurator.ReadConfiguration().ProjectName;

            var project = new ProjectModel()
            {
                Name = projectName,
                Announcement = "test announcement",
                IsShowAnnouncement = true,
                ProjectType = "Use multiple test suites to manage cases",
                IsEnableTestCase = true,
                DefaultAccessRole = "Tester"
            };

            NavigationStep.NavigationToAddProjectPage().AddProjectWithRequiredFields(project);

            //Assert.That(NavigationStep.NavigationToProjectsPage(false).SuccessAddProductMessage().Enabled);
            Assert.That(NavigationStep.NavigationToProjectsPage(false).ProjectsTitles().Contains(projectName));
        }
    }
}
