using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test.HerokuApp
{
    internal class DynamicControlsTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().HerokuAppUrl + "dynamic_controls");
        }

        [Test]
        public void CheckForCheckboxExists()
        {
            Assert.That(DynamicControlsPage.CheckBox(), Is.Not.Null);
        }

        [Test]
        public void CheckForMessageWhenRemoveButtonClick()
        {
            DynamicControlsPage.RemoveButtonClick();

            _waitsHelper.WaitForElement(DynamicControlsPage.Message());

            Assert.That(DynamicControlsPage.Message().Displayed, Is.True);
        }

        [Test]
        public void CheckForCheckboxDisappears()
        {
            DynamicControlsPage.RemoveButtonClick();

            var res = _waitsHelper.WaitForElementInvisible(DynamicControlsPage.checkBox);

            Assert.That(res, Is.True);
        }
    }
}
