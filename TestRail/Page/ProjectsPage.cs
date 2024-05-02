using OpenQA.Selenium;
using TestRail.Element;
using TestRail.Utils;

namespace TestRail.Page
{
    public class ProjectsPage : BasePage
    {
        private readonly By successMessage = By.XPath("//div[contains(text(), 'Successfully added the new project.')]");
        private readonly By removeProjectButton = By.XPath($"//a[contains(text(), '{Configurator.ReadConfiguration().ProjectName}')]/parent::td/following-sibling::td[2]//div[@data-testid='projectDeleteButton']");

        protected IWebDriver Driver { get; set; }

        public ProjectsPage(IWebDriver driver) : base(driver)
        { }

        public UIElement SuccessMessage() => new(Driver, successMessage);
        public Button RemoveProjectButton() => new(Driver, removeProjectButton);
        public void RemoveProjectButtonClick() => RemoveProjectButton().Click();
    }
}
