using Allure.Net.Commons;
using Allure.NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using TeachMeSkills.Core;
using TeachMeSkills.Helpers;
using TeachMeSkills.Pages.DemoQa;
using TeachMeSkills.Pages.HerokuApp;

namespace TeachMeSkills.Test
{
    [AllureNUnit]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected AlertsPage AlertsPage { get; set; }
        protected DynamicControlsPage DynamicControlsPage { get; set; }
        protected WindowsPage WindowsPage { get; set; }
        protected NewWindowPage NewWindowPage { get; set; }
        protected ContextMenuPage ContextMenuPage { get; set; }
        protected WaitsHelper _waitsHelper { get; set; }

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void SetUp()
        {
            Driver = new Browser().Driver;
            AlertsPage = new AlertsPage(Driver);
            DynamicControlsPage = new DynamicControlsPage(Driver);
            WindowsPage = new WindowsPage(Driver);
            NewWindowPage = new NewWindowPage(Driver);
            ContextMenuPage = new ContextMenuPage(Driver);
            _waitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.ReadConfiguration().Timeout));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
