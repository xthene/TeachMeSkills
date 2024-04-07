using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkillsTestProject
{
    public class Typos
    {
        private IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void TextIsEqualToExpected()
        {
            var p = Driver.FindElements(By.TagName("p"));
            var text = p[1].Text;

            Assert.That(text, Is.EqualTo("Sometimes you'll see a typo, other times you won't."));
        }
    }
}
