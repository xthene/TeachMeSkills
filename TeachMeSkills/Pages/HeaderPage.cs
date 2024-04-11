using OpenQA.Selenium;

namespace TeachMeSkills.Pages
{
    public class HeaderPage : BasePage
    {
        private readonly By shoppingCartBadgeBy = By.XPath("//div[@id='shopping_cart_container']/descendant::span");
        private readonly By sortSelectBy = By.XPath("//select[@class='product_sort_container']");
        private readonly By sortSelectAzOptionBy = By.XPath("//select[@class='product_sort_container']/option[@value='az']");
        private readonly By sortSelectZaOptionBy = By.XPath("//select[@class='product_sort_container']/option[@value='za']");
        private readonly By sortSelectLohiOptionBy = By.XPath("//select[@class='product_sort_container']/option[@value='lohi']");
        private readonly By sortSelectHiloOptionBy = By.XPath("//select[@class='product_sort_container']/option[@value='hilo']");

        private IWebDriver Driver { get; set; }
        public HeaderPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement ShoppingCartBadge() => Driver.FindElement(shoppingCartBadgeBy);
        public IWebElement SortSelect() => Driver.FindElement(sortSelectBy);
        public IWebElement SortSelectAzOption() => Driver.FindElement(sortSelectAzOptionBy);
        public IWebElement SortSelectZaOption() => Driver.FindElement(sortSelectZaOptionBy);
        public IWebElement SortSelectLohiOption() => Driver.FindElement(sortSelectLohiOptionBy);
        public IWebElement SortSelectHiloOption() => Driver.FindElement(sortSelectHiloOptionBy);

        public void SelectAZSort() => SortSelectAzOption().Click();
        public void SelectZASort() => SortSelectZaOption().Click();
        public void SelectLoHiSort() => SortSelectLohiOption().Click();
        public void SelectHiLoSort() => SortSelectHiloOption().Click();

    }
}
