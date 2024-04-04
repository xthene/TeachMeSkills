using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TeachMeSkillsTestProject
{
    public class Checkboxes
    {
        private IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [Test, Order(0)]
        public void FirstCheckboxIsUnchecked()
        {
            var checkboxes = Driver.FindElements(By.CssSelector("[type=checkbox]"));

            Assert.That(checkboxes.First().GetAttribute("checked"), Is.Null);
        }

        [Test, Order(1)]
        public void FirstCheckboxCheckedAfterClick()
        {
            var checkboxes = Driver.FindElements(By.CssSelector("[type=checkbox]"));

            checkboxes.First().Click();

            Assert.IsTrue(checkboxes.First().GetAttribute("checked") == "true");
        }

        [Test, Order(2)]
        public void SecondCheckboxIsChecked()
        {
            var checkboxes = Driver.FindElements(By.CssSelector("[type=checkbox]"));

            Assert.That(checkboxes[1].GetAttribute("checked"), Is.EqualTo("true"));
        }

        [Test, Order(3)]
        public void SecondCheckboxUncheckedAfterClick()
        {
            var checkboxes = Driver.FindElements(By.CssSelector("[type=checkbox]"));

            checkboxes[1].Click();

            Assert.That(checkboxes[1].GetAttribute("checked"), Is.Null);
        }
    }
}
