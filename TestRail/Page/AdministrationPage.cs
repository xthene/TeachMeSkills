using OpenQA.Selenium;
using TestRail.Element;

namespace TestRail.Page
{
    public class AdministrationPage : BasePage
    {
        private readonly By projectsTab = By.Id("navigation-sub-projects");

        private readonly string _endPoint = "";

        public IWebDriver Driver;

        public AdministrationPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            Driver = driver;
        }

        public UIElement ProjectsTab() => new(Driver, projectsTab);
        public void ProjectsTabClick() => ProjectsTab().Click();

        protected override bool EvaluateLoadedStatus()
        {
            return ProjectsTab().Enabled;
        }

        public override string GetEndpoint()
        {
            return _endPoint;
        }
    }
}
