using OpenQA.Selenium;
using TestRail.Element;

namespace TestRail.Page
{
    public class LoginPage : BasePage
    {
        private readonly By usernameInput = By.XPath("//input[@id='name']");
        private readonly By passwordInput = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.XPath("//button[@id='button_primary']");

        private readonly string _endPoint = "";

        protected IWebDriver Driver { get; set; }

        public override string GetEndpoint()
        {
            return _endPoint;
        }

        public LoginPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            Driver = driver;
        }

        public UIElement UsernameInput() => new(Driver, usernameInput);
        public UIElement PasswordInput() => new(Driver, passwordInput);
        public Button LoginButton() => new(Driver, loginButton);
        public void LoginButtonClick() => LoginButton().Click();

        public void Login(string username, string password)
        {
            UsernameInput().SendKeys(username);
            PasswordInput().SendKeys(password);
            LoginButtonClick();
        }

        protected override bool EvaluateLoadedStatus()
        {
            return LoginButton().Enabled;
        }
    }
}
