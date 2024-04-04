using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TeachMeSkillsTestProject
{
    internal class Dropdown
    {
        private IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void AllDropdownElementsExists()
        {
            var dropdown = Driver.FindElement(By.Id("dropdown"));
            var options = dropdown.FindElements(By.TagName("option"));

            Assert.That(options.Count, Is.EqualTo(2));
        }

        [Test]
        public void WhenFirstOptionSelectedItsSelected()
        {
            var dropdown = Driver.FindElement(By.Id("dropdown"));
            var options = dropdown.FindElements(By.TagName("option"));

            options.First().Click();

            Assert.IsTrue(options.First().GetAttribute("checked") == "true");
        }

        [Test]
        public void WhenSecondOptionSelectedItsSelected()
        {
            var dropdown = Driver.FindElement(By.Id("dropdown"));
            var options = dropdown.FindElements(By.TagName("option"));

            options[1].Click();

            Assert.IsTrue(options[1].GetAttribute("checked") == "true");
        }
    }
}
