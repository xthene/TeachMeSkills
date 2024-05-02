using OpenQA.Selenium;
using TestRail.Element;
using TestRail.Utils;

namespace TestRail.Page
{
    public class ProjectsOverviewPage : BasePage
    {
        protected IWebDriver Driver { get; set; }

        private readonly By removeProject = By.XPath($"//a[contains(text(), '{Configurator.ReadConfiguration().ProjectName}')]/parent::td/following-sibling::td[2]//div[@data-testid='projectDeleteButton']']");

        private readonly string endPoint = "index.php?/admin/projects/overview";
        

        public ProjectsOverviewPage(IWebDriver driver) : base(driver)
        { }

        public override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        public Button RemoveProjectButton() => new(Driver, removeProject);
        public void RemoveProjectButtonClick() => RemoveProjectButton().Click();
        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        protected override bool EvaluateLoadedStatus()
        {
            return RemoveProjectButton().Displayed;
        }
    }
}
