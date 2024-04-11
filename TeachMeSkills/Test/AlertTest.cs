using NUnit.Framework;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test
{
    internal class AlertTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().DemoQaUrl + "alerts");
        }

        [Test]
        public void ClickForAlert()
        {
            AlertsPage.AlertButtonClick();

            var alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text.Trim(), Is.EqualTo("You clicked a button"));
        }

        [Test]
        public void ClickForTimerAlert()
        {
            AlertsPage.TimerAlertButtonClick();

            var timerAlert = _waitsHelper.WaitForAlertIsPresent();

            Assert.That(timerAlert.Text.Trim(), Is.EqualTo("This alert appeared after 5 seconds"));
        }

        [Test]
        public void ClickForConfirmButtonAlertAccept()
        {
            AlertsPage.ConfirmButtonClick();

            var alert = Driver.SwitchTo().Alert();
            alert.Accept();

            Assert.That(AlertsPage.ConfirmResult().Text.Contains("Ok"));
        }

        [Test]
        public void ClickForConfirmButtonAlertDismiss()
        {
            AlertsPage.ConfirmButtonClick();

            var alert = Driver.SwitchTo().Alert();
            alert.Dismiss();

            Assert.That(AlertsPage.ConfirmResult().Text.Contains("Cancel"));
        }

        [Test]
        public void ClickForPromptButton()
        {
            var name = "Vasya";

            AlertsPage.PromptButtonClick();

            var alert = Driver.SwitchTo().Alert();
            alert.SendKeys(name);
            alert.Accept();

            Assert.That(AlertsPage.PromptResult().Text.Contains(name));
        }
    }
}
