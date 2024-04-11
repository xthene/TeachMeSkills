using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TeachMeSkills.Pages;

namespace TeachMeSkills.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected LoginPage LoginPage { get; private set; }
        protected InventoryPage InventoryPage { get; private set; }
        public CartPage? CartPage { get; set; }
        protected HeaderPage HeaderPage { get; private set; }

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            LoginPage = new LoginPage(Driver);
            InventoryPage = new InventoryPage(Driver);
            CartPage = new CartPage(Driver);
            HeaderPage = new HeaderPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
