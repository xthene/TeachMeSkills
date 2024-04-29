using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class MainPage : BasePage
    {
        protected IWebDriver Driver { get; set; }

        public MainPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
    }
}
