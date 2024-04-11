using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Tests.InventoryTests
{
    [TestFixture]
    public class PositiveTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().SauceDemoUrl);
            LoginPage.Login(Configurator.ReadConfiguration().UserNameSauceDemo,
                Configurator.ReadConfiguration().PasswordSauceDemo);
        }

        [Test]
        public void AddToCartTest()
        {
            InventoryPage.ClickFirstAddToItemButton();

            Assert.Multiple(() =>
            {
                Assert.That(InventoryPage.FirstAddToCartButton().Text, Is.EqualTo("Remove"));
                Assert.That(HeaderPage.ShoppingCartBadge().Displayed, Is.True);
                Assert.That(HeaderPage.ShoppingCartBadge().Text, Is.EqualTo("1"));
            });
        }

        [Test]
        public void RemoveFromCartTest()
        {
            //add to cart
            InventoryPage.ClickFirstAddToItemButton();
            //remove from cart
            InventoryPage.ClickFirstAddToItemButton();

            Assert.That(InventoryPage.FirstAddToCartButton().Text, Is.EqualTo("Add to cart"));
        }

        [Test]
        public void SortByNameAzTest()
        {
            HeaderPage.SelectAZSort();

            var actualResult = InventoryPage.ItemNameDivs();
            var expectedResult = InventoryPage.ItemNameDivs().OrderBy(i => i.Text);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SortByNameZaTest()
        {
            HeaderPage.SelectZASort();

            var actualResult = InventoryPage.ItemNameDivs();
            var expectedResult = InventoryPage.ItemNameDivs().OrderByDescending(i => i.Text);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SortByPriceLoHi()
        {
            HeaderPage.SelectLoHiSort();

            var actualResult = InventoryPage.PriceText();
            var expectedResult = InventoryPage.PriceText().OrderBy(i => i.Text);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SortByPriceHiLo()
        {
            HeaderPage.SelectHiLoSort();

            var actualResult = InventoryPage.PriceText();
            var expectedResult = InventoryPage.PriceText().OrderByDescending(i => i.Text);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
