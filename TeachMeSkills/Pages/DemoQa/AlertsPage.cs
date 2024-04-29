using OpenQA.Selenium;

namespace TeachMeSkills.Pages.DemoQa
{
    public class AlertsPage : BasePage
    {
        private readonly By alertButton = By.XPath("//button[@id='alertButton']");
        private readonly By timerAlertButton = By.XPath("//button[@id='timerAlertButton']");
        private readonly By confirmButton = By.XPath("//button[@id='confirmButton']");
        private readonly By promptButton = By.XPath("//button[@id='promtButton']");
        private readonly By confirmResult = By.XPath("//span[@id='confirmResult']");
        private readonly By promptResult = By.XPath("//span[@id='promptResult']");

        private IWebDriver Driver { get; set; }

        public AlertsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void AlertButtonClick() => Driver.FindElement(alertButton).Click();
        public void TimerAlertButtonClick() => Driver.FindElement(timerAlertButton).Click();
        public void ConfirmButtonClick() => Driver.FindElement(confirmButton).Click();
        public void PromptButtonClick() => Driver.FindElement(promptButton).Click();
        public IWebElement ConfirmResult() => Driver.FindElement(confirmResult);
        public IWebElement PromptResult() => Driver.FindElement(promptResult);
    }
}
