using AutomationFramework.Pages;
using AutomationFramework.ProjectLib;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationFramework.Steps
{
    [Binding]
    public class BaseSteps
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public IWebDriver Driver;
        public ScenarioContext ScenarioContext;
        public readonly IRunData Rundata;
        public LoginPage loginPage;

        public BaseSteps(IWebDriver webDriver, ScenarioContext scenarioContext, IRunData runData, PageObjectManager pageObjectManager)
        {
            ScenarioContext = scenarioContext;
            Driver = webDriver;
            Rundata = runData;

        }

    }
}
