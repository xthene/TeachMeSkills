using OpenQA.Selenium;

namespace TeachMeSkills.Pages.HerokuApp
{
    public class ContextMenuPage : BasePage
    {
        private By hotSpot = By.XPath("//div[@id='hot-spot']");

        private IWebDriver Driver { get; set; }
        public ContextMenuPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement HotSpot() => Driver.FindElement(hotSpot);
    }
}
