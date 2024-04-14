using OpenQA.Selenium;

namespace TeachMeSkills.Pages.HerokuApp
{
    internal class NewWindowPage : BasePage
    {
        private readonly By text = By.TagName("h3");

        protected IWebDriver Driver { get; set; }
        public NewWindowPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement Text() => Driver.FindElement(text);
    }
}
