using BoDi;
using Enterprise.Framework.GenericLib;
using AutomationFramework.Constants;
using AutomationFramework.Pages;
using AutomationFramework.ProjectLib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static Enterprise.Framework.Actions.BaseActions;

namespace AutomationFramework.Steps
{
    [Binding]
    public class LoginSteps : BaseSteps
    {
      
        //LandingPage homePage => new LandingPage(Driver);       
        public LoginSteps(IWebDriver webDriver, ScenarioContext scenarioContext, IRunData runData, PageObjectManager pageObjectManager) : base(webDriver, scenarioContext, runData, pageObjectManager)
        {
            loginPage = pageObjectManager.GetLoginPage();
          
        }

        [Given(@"User is in welcome page of the application")]
        public void GivenILaunchTheApplication(Table table) => Assert.AreEqual(table.Rows[0]["WelcomeUserMessage"], loginPage.GetWelcomeMessage());

        [When(@"User clicks login link")]
        public void ClickLoginLink() => loginPage.ClickLoginLink();

        [Then(@"User should see okta signin button")]
        public void GetSignInText(Table table) => Assert.AreEqual(table.Rows[0]["SignInMessage"], loginPage.GetOktaSignInText());


    }
}
