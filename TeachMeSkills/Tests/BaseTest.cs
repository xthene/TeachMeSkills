using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TeachMeSkills.Pages;

namespace TeachMeSkills.Test
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }
        public LoginPage LoginPage { get; set; }
        public InventoryPage InventoryPage { get; set; }
        public CartPage CartPage { get; set; }
        public HeaderPage HeaderPage { get; set; }

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
