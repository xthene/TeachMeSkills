﻿using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using TestRail.Core;
using TestRail.Page;

namespace TestRail.Test
{
    [AllureNUnit]
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        public LoginPage LoginPage { get; set; }
        public MainPage MainPage { get; set; }
        public AddProjectPage AddProjectPage { get; set; }
        public ProjectsPage ProjectsPage { get; set; }

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            LoginPage = new LoginPage(Driver);
            MainPage = new MainPage(Driver);
            AddProjectPage = new AddProjectPage(Driver);
            ProjectsPage = new ProjectsPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
