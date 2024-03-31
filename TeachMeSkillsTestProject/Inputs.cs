using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TeachMeSkillsTestProject
{
    public class Inputs
    {
        private IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void Input100()
        {
            var input = Driver.FindElement(By.TagName("input"));

            int i = 0;
            while (i < 100)
            {
                i++;
                input.SendKeys(Keys.ArrowUp);
            }

            var text = input.GetAttribute("value");

            Assert.That(text, Is.EqualTo("100"));

        }

        [Test]
        public void InputNegative100()
        {
            var input = Driver.FindElement(By.TagName("input"));

            int i = 0;
            while (i < 100)
            {
                i++;
                input.SendKeys(Keys.ArrowDown);
            }

            var text = input.GetAttribute("value");

            Assert.That(text, Is.EqualTo("-100"));

        }
    }
}
