using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class InventoryPage : BasePage
    {
        private static readonly By productsTitleBy = By.XPath("//*[.='Products']");
        private static readonly By addToCartButtons = By.XPath("//div[@class='inventory_item']/descendant::button");
        private static readonly By itemNameDivs = By.XPath("//div[@class='inventory_item_name ']");
        private static readonly By priceDivs = By.XPath("//div[@class='pricebar']/child::div[@class='inventory_item_price']");

        public IWebDriver Driver { get; set; }

        public InventoryPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement ProductsTitle() => Driver.FindElement(productsTitleBy);
        public IEnumerable<IWebElement> AddToCartButtons() => Driver.FindElements(addToCartButtons);
        public IEnumerable<IWebElement> ItemNameDivs() => Driver.FindElements(itemNameDivs);
        public IEnumerable<IWebElement> PriceDivs() => Driver.FindElements(priceDivs);
        public IWebElement FirstAddToCartButton() => AddToCartButtons().FirstOrDefault();
        public void ClickFirstAddToItemButton() => FirstAddToCartButton().Click();
        
    }
}
