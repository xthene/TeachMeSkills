﻿using NUnit.Allure.Core;
using TestRail.Utils;

namespace TestRail.Test
{
    [AllureNUnit]
    internal class LoginTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
        }

        [Test]
        public void CorrectLogin()
        {
            LoginPage.Login(Configurator.ReadConfiguration().Username, Configurator.ReadConfiguration().Password);

            Assert.That(MainPage.AddProjectButton().Enabled);
        }
    }
}
