using OpenQA.Selenium;
using TestRail.Element;
using TestRail.Utils;

namespace TestRail.Page
{
    public class ProjectsPage : BasePage
    {
        private readonly By successAddProductMessage = By.XPath("//div[contains(text(), 'Successfully added the new project.')]");
        private readonly By successDeleteProductMessage = By.XPath("//div[contains(text(), 'Successfully deleted the project.')]");

        private readonly By removeProjectButton = By.XPath($"//a[contains(text(), '{Configurator.ReadConfiguration().ProjectName}')]/parent::td/following-sibling::td[2]//div[@data-testid='projectDeleteButton']");
        private readonly By deleteCheckbox = By.XPath("//div[@id='deleteDialog']//descendant::input[@data-testid='deleteCheckBoxTestId']");
        private readonly By okDeleteButton = By.XPath("//div[@id='deleteDialog']//descendant::a[@data-testid='caseFieldsTabDeleteDialogButtonOk']");

        private readonly string _endPoint = "index.php?/admin/projects/overview";

        protected IWebDriver Driver { get; set; }

        public override string GetEndpoint()
        {
            return _endPoint;
        }

        public ProjectsPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            Driver = driver;
        }

        public UIElement SuccessAddProductMessage() => new(Driver, successAddProductMessage);
        public UIElement SuccessDeleteProductMessage() => new(Driver, successDeleteProductMessage);
        public Button RemoveProjectButton() => new(Driver, removeProjectButton);
        public Button OkDeleteButton() => new(Driver, okDeleteButton);
        public Checkbox DeleteCheckBox() => new(Driver, deleteCheckbox);
        public void RemoveProjectButtonClick() => RemoveProjectButton().Click();
        public void DeleteCheckBoxCheck() => DeleteCheckBox().Check();
        public void OkDeleteButtonClick() => OkDeleteButton().Click();

        protected override bool EvaluateLoadedStatus()
        {
            return RemoveProjectButton().Enabled;
        }
    }
}
