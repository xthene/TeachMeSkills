using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Test.HerokuApp
{
    internal class WindowsTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().HerokuAppUrl + "windows");
        }

        [Test]
        public void NewWindowTextAreEqualExpected()
        {
            WindowsPage.ClickByLink();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());

            Assert.That(NewWindowPage.Text().Text, Is.EqualTo("New Window"));
        }
    }
}
