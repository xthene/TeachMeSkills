using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test.InventoryTests
{
    [TestFixture]
    public class PositiveTests : BaseTest
    {
        [SetUp]
        public void Setup()
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
        public void SortByNameAZTest()
        {
            HeaderPage.SelectAZSort();

            var actualResult = InventoryPage.ItemNameDivs();
            var expectedResult = InventoryPage.ItemNameDivs().OrderBy(i => i.Text);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
