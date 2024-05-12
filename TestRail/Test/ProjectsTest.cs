using TestRail.Models;
using TestRail.Steps;
using TestRail.Utils;

namespace TestRail.Test
{
    public class ProjectsTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);

            var user = new UserModel()
            {
                UserName = Configurator.ReadConfiguration().Username,
                Password = Configurator.ReadConfiguration().Password
            };
            UserStep.SuccessfulLogin(user);
        }

        [Test]
        [Category("Positive")]
        public void RemoveProjectTest()
        {
            var ProjectsPage = NavigationStep.NavigationToProjectsPage(true);

            ProjectsPage.RemoveProjectButtonClick();
            ProjectsPage.DeleteCheckBoxCheck();
            ProjectsPage.OkDeleteButtonClick();

            Assert.That(ProjectsPage.SuccessDeleteProductMessage().Enabled);
        }
    }
}
