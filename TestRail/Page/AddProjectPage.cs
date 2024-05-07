using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestRail.Element;

namespace TestRail.Page
{
    public class AddProjectPage : BasePage
    {
        private readonly By nameInput = By.XPath("//input[@id='name']");
        private readonly By roleSelect = By.XPath("//select[@id='access']");

        private readonly By accessTab = By.XPath("//div[@class='tab-header']/a[contains(text(), 'Access')]");

        private readonly By addProjectButton = By.XPath("//button[@id='accept']");

        private readonly string _endPoint = "";

        protected IWebDriver Driver { get; set; }

        public override string GetEndpoint()
        {
            return _endPoint;
        }

        public AddProjectPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            Driver = driver;
        }

        public void SendProjectName(string projectName) => Driver.FindElement(nameInput).SendKeys(projectName);
        public void AccessTabClick() => Driver.FindElement(accessTab).Click();
        public void AddProjectButtonClick() => Driver.FindElement(addProjectButton).Click();
        public UIElement AddProjectButton() => new(Driver, addProjectButton);
        public SelectElement RoleSelectElement() => new SelectElement(Driver.FindElement(roleSelect));

        public void AddProjectWithRequiredFields(string name, string role)
        {
            SendProjectName(name);
            AccessTabClick();
            RoleSelectElement().SelectByText(role);
            AddProjectButtonClick();
        }

        protected override bool EvaluateLoadedStatus()
        {
            return AddProjectButton().Enabled;
        }
    }
}
