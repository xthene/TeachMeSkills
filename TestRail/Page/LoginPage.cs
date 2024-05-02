using OpenQA.Selenium;
using TestRail.Element;

namespace TestRail.Page
{
    public class LoginPage : BasePage
    {
        private readonly By usernameInput = By.XPath("//input[@id='name']");
        private readonly By passwordInput = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.XPath("//button[@id='button_primary']");

        protected IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        { }

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

        public override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        protected override bool EvaluateLoadedStatus()
        {
            return LoginButton().Displayed;
        }
    }
}
