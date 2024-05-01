using Allure.Net.Commons;
using Allure.NUnit;
using NLog;
using NLog.Config;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TeachMeSkills.Core;
using TeachMeSkills.Helpers;
using TeachMeSkills.Pages.DemoQa;
using TeachMeSkills.Pages.HerokuApp;

namespace TeachMeSkills.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected Logger logger = LogManager.GetCurrentClassLogger();
        protected AlertsPage AlertsPage { get; set; }
        protected DynamicControlsPage DynamicControlsPage { get; set; }
        protected WindowsPage WindowsPage { get; set; }
        protected NewWindowPage NewWindowPage { get; set; }
        protected ContextMenuPage ContextMenuPage { get; set; }
        protected FileUploadPage FileUploadPage { get; set; }
        protected WaitsHelper _waitsHelper { get; set; }

        [OneTimeSetUp]
        public static void GlobalSetUp()
        {
            new NLogConfig().Config();
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
            FileUploadPage = new FileUploadPage(Driver);
            _waitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.ReadConfiguration().Timeout));
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var textAreaScreenshot = ((ITakesScreenshot)Driver.FindElement(By.TagName("textarea"))).GetScreenshot();
                var screenshotByte = screenshot.AsByteArray;
                var textAreaScreenshotByte = textAreaScreenshot.AsByteArray;
                AllureApi.AddAttachment("screenshot", "image/png", screenshotByte);
                AllureApi.AddAttachment("textArea", "image/png", textAreaScreenshotByte);
            }

            try
            {
                var loggerPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
                    "fileLogger.txt");
                AllureApi.AddAttachment("logger", "text/html", loggerPath);
            }
            catch
            {
                Console.WriteLine("couldnt load file");
            }

            Driver.Dispose();
        }
    }
}
