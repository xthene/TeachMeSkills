using NUnit.Framework;
using OpenQA.Selenium;
using TeachMeSkills.Core;
using TeachMeSkills.Pages;

namespace TeachMeSkills.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        public LoginPage LoginPage { get; set; }
        public MainPage MainPage { get; set; }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            LoginPage = new LoginPage(Driver);
            MainPage = new MainPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
