using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkillsTestProject
{
    public class AddRemoveElements
    {
        private IWebDriver Driver { get; set; }
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void WhenTwoElementsAddedAndOneRemovedRemainsOneElement()
        {
            var addButton = Driver.FindElement(By.XPath("//button[text()='Add Element']"));
            addButton.Click();
            addButton.Click();
            var deleteButton = Driver.FindElement(By.XPath("//button[text()='Delete']"));
            deleteButton.Click();

            var deleteButtons = Driver.FindElements(By.Id("elements"));

            Assert.That(deleteButtons.Count, Is.EqualTo(1));
        }
    }
}
