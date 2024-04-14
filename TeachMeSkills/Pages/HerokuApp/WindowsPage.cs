using OpenQA.Selenium;

namespace TeachMeSkills.Pages.HerokuApp
{
    internal class WindowsPage : BasePage
    {
        private readonly By link = By.XPath("//a[contains(text(), 'Click Here')]");

        private IWebDriver Driver { get; set; }
        public WindowsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ClickByLink() => Driver.FindElement(link).Click();  
    }
}
