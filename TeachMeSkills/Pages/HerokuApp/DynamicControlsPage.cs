using OpenQA.Selenium;

namespace TeachMeSkills.Pages.HerokuApp
{
    internal class DynamicControlsPage : BasePage
    {
        private readonly By checkBox = By.XPath("//input[@type='checkbox']");
        private readonly By removeButton = By.XPath("//button[contains(text(), 'Remove')]");
        private readonly By infoMessage = By.XPath("");

        private IWebDriver Driver { get; set; }

        public DynamicControlsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement CheckBox() => Driver.FindElement(checkBox);
        public void RemoveButtonClick() => Driver.FindElement(removeButton).Click();
        public IWebElement Message() => Driver.FindElement(infoMessage);
    }
}
