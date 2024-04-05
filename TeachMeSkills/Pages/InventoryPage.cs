using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class InventoryPage : BasePage
    {
        private static readonly By productsTitleBy = By.XPath("//*[.='Products']");
        private static readonly By backpackLink = By.LinkText("Sauce Labs Backpack");
        private static readonly By bikeLightLink = By.PartialLinkText("Bike Light");
        private static readonly By tshirtLink = By.XPath("//button[@id='add-to-cart-sauce-labs-bolt-t-shirt']/ancestor::div[@class='inventory_item_label']/child::a");
        private static readonly By addToCartButtons = By.XPath("//div[@class='inventory_item']/descendant::button");
        private static readonly By priceDivs = By.XPath("//div[@class='pricebar']/child::div[@class='inventory_item_price']");
        private static readonly By backpackPriceBar = By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']/parent::div");

        public IWebDriver Driver { get; set; }

        public InventoryPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement ProductsTitle() => Driver.FindElement(productsTitleBy);


    }
}
