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

        protected IWebDriver Driver { get; set; }
        public override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        public AddProjectPage(IWebDriver driver) : base(driver)
        { }

        public void SendProjectName(string projectName) => Driver.FindElement(nameInput).SendKeys(projectName);
        public void AccessTabClick() => Driver.FindElement(accessTab).Click();
        public Button AddProjectButton() => new(Driver, addProjectButton);
        public void AddProjectButtonClick() => AddProjectButton().Click();
        public SelectElement RoleSelectElement() => new(Driver.FindElement(roleSelect));

        public void AddProjectWithRequiredFields(string name, string role)
        {
            SendProjectName(name);
            AccessTabClick();
            RoleSelectElement().SelectByText(role);
            AddProjectButtonClick();
        }

        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        protected override bool EvaluateLoadedStatus()
        {
            return AddProjectButton().Displayed;
        }
    }
}
