using OpenQA.Selenium;

namespace TestRail.Element
{
    internal class Checkbox
    {
        private readonly UIElement _uiElement;

        public Checkbox(IWebDriver driver, By locator)
        {
            _uiElement = new UIElement(driver, locator);
        }
    }
}
