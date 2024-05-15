using OpenQA.Selenium;

namespace TestRail.Page
{
    public class LoginPage : BasePage
    {
        private readonly By usernameInput = By.XPath("//input[@id='name']");
        private readonly By passwordInput = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.XPath("//button[@id='button_primary']");

        protected IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement UsernameInput() => Driver.FindElement(usernameInput);
        public IWebElement PasswordInput() => Driver.FindElement(passwordInput);
        public void LoginButtonClick() => Driver.FindElement(loginButton).Click();

        public void Login(string username, string password)
        {
            UsernameInput().SendKeys(username);
            PasswordInput().SendKeys(password);
            LoginButtonClick();
        }
    }
}
