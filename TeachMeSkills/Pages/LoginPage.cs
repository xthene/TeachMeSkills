using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    internal class LoginPage : BasePage
    {
        private readonly By userNameInputBy = By.Id("user-name");
        private readonly By passwordInputBy = By.Name("password");
        private readonly By loginButtonBy = By.TagName("input");

        private IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement UsernameInput() => Driver.FindElement(userNameInputBy);
        public IWebElement PasswordInput() => Driver.FindElement(passwordInputBy);
        public IWebElement LoginButton() => Driver.FindElement(loginButtonBy);

        public void Login(string username = "", string password = "")
        {
            UsernameInput().SendKeys(username);
            PasswordInput().SendKeys(password);
            LoginButton().Click();
        }
    }
}
