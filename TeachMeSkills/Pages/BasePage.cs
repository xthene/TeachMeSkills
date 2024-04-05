using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    internal class BasePage
    {
        private IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
