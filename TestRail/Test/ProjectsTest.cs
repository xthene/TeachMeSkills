using TestRail.Utils;

namespace TestRail.Test
{
    public class ProjectsTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
            LoginPage.Login(Configurator.ReadConfiguration().Username, Configurator.ReadConfiguration().Password);
            MainPage.AdministrationButtonClick();
            AdministrationPage.ProjectsTabClick();
        }

        [Test]
        public void RemoveProjectTest()
        {
            ProjectsPage.RemoveProjectButtonClick();
            ProjectsPage.DeleteCheckBoxCheck();
            ProjectsPage.OkDeleteButtonClick();

            Assert.That(ProjectsPage.SuccessDeleteProductMessage().Enabled);
        }
    }
}
