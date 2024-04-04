using OpenQA.Selenium;

namespace TeachMeSkills
{
    internal class CartPage
    {
        private readonly By continueShoppingButton = By.XPath("//button[@id='checkout']/preceding::button[contains(text(), 'Continue')]");
        private readonly By checkoutButton = By.XPath("//button[@id='continue-shopping']/following::button");
    }
}
