using OpenQA.Selenium;

namespace TeachMeSkills
{
    internal class InventoryPage
    {
        private readonly By backpackLink = By.LinkText("Sauce Labs Backpack");
        private readonly By bikeLightLink = By.PartialLinkText("Bike Light");
        private readonly By tshirtLink = By.XPath("//div[contains(text(), 'T-Shirt')]/parent::a");
        private readonly By tshirtDescriptionDiv = By.XPath("//button[@id='add-to-cart-sauce-labs-bolt-t-shirt']/ancestor::div[2]");
        private readonly By addToCartButtons = By.XPath("//div[@class='inventory_item']/descendant::button");
        private readonly By priceDivs = By.XPath("//div[@class='pricebar']/child::div[@class='inventory_item_price']");
        private readonly By backpackPriceBar = By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']/parent::div");
    }
}
