using OpenQA.Selenium;
using TestRail.Element;

namespace TestRail.Page
{
    public class ProjectsPage : BasePage
    {
        private readonly By successMessage = By.XPath("//div[contains(text(), 'Successfully added the new project.')]");
        protected IWebDriver Driver { get; set; }
        public override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        public ProjectsPage(IWebDriver driver) : base(driver)
        { }

        public UIElement SuccessMessage() => new(Driver, successMessage);
        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }
    }
}
