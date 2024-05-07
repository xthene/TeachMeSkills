﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestRail.Utils;

namespace TestRail.Page
{
    public abstract class BasePage : LoadableComponent<BasePage>
    {
        protected IWebDriver Driver { get; set; }


        public BasePage(IWebDriver driver, bool openPageByUrl = false)
        {
            Driver = driver;
            if (openPageByUrl)
                Load();
        }

        public abstract string GetEndpoint();

        protected override void ExecuteLoad()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url + GetEndpoint());
        }
    }
}
