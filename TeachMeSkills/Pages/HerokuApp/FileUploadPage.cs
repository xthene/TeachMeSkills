using OpenQA.Selenium;

namespace TeachMeSkills.Pages.HerokuApp
{
    internal class FileUploadPage : BasePage
    {
        private readonly By chooseButton = By.XPath("//button[contains(text(), 'Choose')]");
        private readonly By resetButton = By.XPath("//button[contains(text(), 'Reset')]");
        private readonly By fileUploadInput = By.XPath("//input[@id='file-upload-field']");

        private IWebDriver Driver { get; set; }
        public FileUploadPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ChooseButtonClick() => Driver.FindElement(chooseButton).Click();
        public void ResetButtonClick() => Driver.FindElement(resetButton).Click();
        public IWebElement FileUploadInput() => Driver.FindElement(fileUploadInput);
    }
}
