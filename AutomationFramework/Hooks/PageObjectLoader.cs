using BoDi;
using AutomationFramework.ProjectLib;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationFramework.Hooks
{
    [Binding]
    class PageObjectLoader
    {
        private readonly IObjectContainer _container;
        private IWebDriver _driver;

        public PageObjectLoader(IObjectContainer container, IWebDriver iwebDriver)
        {
            _container = container;
            _driver = iwebDriver;
        }

        [BeforeScenario(Order = 1)]
        public void LoadPageObjects()
        {
            var data = new PageObjectManager(_driver);
            _container.RegisterInstanceAs<PageObjectManager>(data);
        }
    }
}
