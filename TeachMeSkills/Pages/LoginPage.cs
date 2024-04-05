using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By userNameInputBy = By.Id("user-name");
        private readonly By passwordInputBy = By.Name("password");
        private readonly By loginButtonBy = By.Id("login-button");
        private readonly By errorTitleBy = By.TagName("h3");

        private IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement UsernameInput() => Driver.FindElement(userNameInputBy);
        public IWebElement PasswordInput() => Driver.FindElement(passwordInputBy);
        public IWebElement LoginButton() => Driver.FindElement(loginButtonBy);
        public IWebElement ErrorTitle() => Driver.FindElement(errorTitleBy);

        public void Login(string username = "", string password = "")
        {
            UsernameInput().SendKeys(username);
            PasswordInput().SendKeys(password);
            LoginButton().Click();
        }
    }
}
