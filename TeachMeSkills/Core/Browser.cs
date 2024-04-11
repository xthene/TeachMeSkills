﻿using OpenQA.Selenium;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Core
{
    public class Browser
    {
        private IWebDriver Driver { get; set; }

        public Browser()
        {
            Driver = Configurator.ReadConfiguration().BrowserType.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFirefoxDriver(),
                _ => throw new NotSupportedException("This browser type didn't find")
            };

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Configurator.ReadConfiguration().Timeout);
        }
    }
}
