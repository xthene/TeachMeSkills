using OpenQA.Selenium;

namespace TeachMeSkills
{
    internal class MainPage
    {
        private readonly By userNameInput = By.Id("user-name");
        private readonly By passwordInput = By.Name("password");
        private readonly By loginCredentialsDiv = By.ClassName("login_credentials");
        private readonly By loginButton = By.TagName("button");
        private readonly By loginForm = By.XPath("//input[@type='submit']/ancestor::form");
    }
}
