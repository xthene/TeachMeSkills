using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using TestRail.Core;
using TestRail.Page;

namespace TestRail.Test
{
    [AllureNUnit]
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        public LoginPage LoginPage { get; set; }
        public MainPage MainPage { get; set; }
        public AddProjectPage AddProjectPage { get; set; }
        public AdministrationPage AdministrationPage { get; set; }
        public ProjectsPage ProjectsPage { get; set; }
        public OverviewProjectPage OverviewProjectPage { get; set; }

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            LoginPage = new LoginPage(Driver);
            MainPage = new MainPage(Driver);
            AddProjectPage = new AddProjectPage(Driver);
            AdministrationPage = new AdministrationPage(Driver);
            ProjectsPage = new ProjectsPage(Driver);
            OverviewProjectPage = new OverviewProjectPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
