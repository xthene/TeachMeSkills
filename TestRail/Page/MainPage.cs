using OpenQA.Selenium;

namespace TestRail.Page
{
    public class MainPage : BasePage
    {
        private readonly By addProjectButton = By.XPath("//a[@id='sidebar-projects-add']");

        protected IWebDriver Driver { get; set; }

        public MainPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement AddProjectButton() => Driver.FindElement(addProjectButton);
        public void AddProjectButtonClick() => Driver.FindElement(addProjectButton).Click();
    }
}
