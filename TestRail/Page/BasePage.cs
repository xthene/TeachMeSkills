using OpenQA.Selenium;

namespace TestRail.Page
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }


        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
