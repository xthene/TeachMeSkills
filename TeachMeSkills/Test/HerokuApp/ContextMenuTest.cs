using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace TeachMeSkills.Test.HerokuApp
{
    internal class ContextMenuTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Helpers.Configurator.ReadConfiguration().HerokuAppUrl + "context_menu");
        }

        [Test]
        public void CheckAlertsText()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(ContextMenuPage.HotSpot())
                .ContextClick()
                .Build()
                .Perform();

            var alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
        }
    }
}
