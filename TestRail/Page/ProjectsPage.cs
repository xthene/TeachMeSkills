using OpenQA.Selenium;

namespace TestRail.Page
{
    public class ProjectsPage : BasePage
    {
        private readonly By successMessage = By.XPath("//div[contains(text(), 'Successfully added the new project.')]");
        protected IWebDriver Driver { get; set; }

        public ProjectsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement SuccessMessage() => Driver.FindElement(successMessage);
    }
}
