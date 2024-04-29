using Allure.NUnit;
using OpenQA.Selenium;
using TestRail.Core;
using TestRail.Page;

namespace TestRail.Test
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        public LoginPage LoginPage { get; set; }
        public MainPage MainPage { get; set; }
        public AddProjectPage AddProjectPage { get; set; }
        public ProjectsPage ProjectsPage { get; set; }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            LoginPage = new LoginPage(Driver);
            MainPage = new MainPage(Driver);
            AddProjectPage = new AddProjectPage(Driver);
            ProjectsPage = new ProjectsPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
