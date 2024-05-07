using OpenQA.Selenium;
using TestRail.Element;

namespace TestRail.Page
{
    public class OverviewProjectPage : BasePage
    {
        private readonly By projectTitle = By.XPath("//div[data-testid='testCaseContentHeaderTitle']");

        private readonly string _endPoint = "";

        public UIElement ProjectTitle() => new(Driver, projectTitle);
        public string GetProjectTtileText() => ProjectTitle().Text;

        protected IWebDriver Driver;

        public OverviewProjectPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            Driver = driver;
        }

        protected override bool EvaluateLoadedStatus()
        {
            return ProjectTitle().Displayed;
        }

        public override string GetEndpoint()
        {
            return _endPoint;
        }
    }
}
