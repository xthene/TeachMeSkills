﻿using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using TestRail.Core;
using TestRail.Steps;

namespace TestRail.Test
{
    [AllureNUnit]
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        //public LoginPage LoginPage { get; set; }
        //public DashboardPage DashboardPage { get; set; }
        //public AddProjectPage AddProjectPage { get; set; }
        //public AdministrationPage AdministrationPage { get; set; }
        //public ProjectsPage ProjectsPage { get; set; }
        //public OverviewProjectPage OverviewProjectPage { get; set; }

        public NavigationStep NavigationStep { get; set; }
        public UserStep UserStep { get; set; }

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            //LoginPage = new LoginPage(Driver);
            //DashboardPage = new DashboardPage(Driver);
            //AddProjectPage = new AddProjectPage(Driver);
            //AdministrationPage = new AdministrationPage(Driver);
            //ProjectsPage = new ProjectsPage(Driver, true);
            //OverviewProjectPage = new OverviewProjectPage(Driver);

            NavigationStep = new NavigationStep(Driver);
            UserStep = new UserStep(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
