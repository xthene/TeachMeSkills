using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class BasePage
    {
        private IWebDriver Driver { get; set; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
