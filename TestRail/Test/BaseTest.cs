using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using TestRail.Core;
using TestRail.Steps;

namespace TestRail.Test
{
    [AllureNUnit]
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        public NavigationStep NavigationStep { get; set; }
        public UserStep UserStep { get; set; }

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;

            NavigationStep = new NavigationStep(Driver);
            UserStep = new UserStep(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
