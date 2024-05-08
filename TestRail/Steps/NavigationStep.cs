using OpenQA.Selenium;
using TestRail.Page;

namespace TestRail.Steps
{
    public class NavigationStep : BaseStep
    {
        public NavigationStep(IWebDriver driver) : base(driver)
        {
        }

        public ProjectsPage NavigationToProjectsPage(bool openPageByUrl)
        {
            return new ProjectsPage(_driver, openPageByUrl);
        }

        public AddProjectPage NavigationToAddProjectPage()
        {
            return new AddProjectPage(_driver);
        }
    }
}
