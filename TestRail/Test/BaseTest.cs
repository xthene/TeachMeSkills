using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using System.Reflection;
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

        [SetUp]
        [AllureBefore("Set up driver")]
        public void Setup()
        {
            Driver = new Browser().Driver;

            NavigationStep = new NavigationStep(Driver);
            UserStep = new UserStep(Driver);
        }

        [TearDown]
        [AllureAfter("Driver quite")]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var screenshotBytes = screenshot.AsByteArray;
                AllureApi.AddAttachment("screenshot", "image/png", screenshotBytes);
            }

            Driver.Dispose();
        }
    }
}
