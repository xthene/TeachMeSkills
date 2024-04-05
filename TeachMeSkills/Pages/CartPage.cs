using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class CartPage : BasePage
    {
        //private readonly By addToCartBackpackBy = By
        private readonly By continueShoppingButton = By.XPath("//button[@id='checkout']/preceding::button[contains(text(), 'Continue')]");
        private readonly By checkoutButton = By.XPath("//button[@id='continue-shopping']/following::button");

        public IWebDriver Driver { get; set; }

        public CartPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
    }
}
