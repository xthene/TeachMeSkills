using OpenQA.Selenium;
using TestRail.Element;

namespace TestRail.Page
{
    public class MainPage : BasePage
    {
        private readonly By addProjectButton = By.XPath("//a[@id='sidebar-projects-add']");

        protected IWebDriver Driver { get; set; }

        public MainPage(IWebDriver driver) : base(driver)
        { }

        public Button AddProjectButton() => new(Driver, addProjectButton);
        public void AddProjectButtonClick() => AddProjectButton().Click();
    }
}
