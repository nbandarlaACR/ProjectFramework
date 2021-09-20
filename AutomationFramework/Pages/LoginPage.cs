using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;


namespace AutomationFramework.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver) { }        
        
        private readonly By _welcomeMessage = By.Id("user_label");
        private readonly By _loginLink = By.LinkText("Login with ACR ID");
        private readonly By _okta_SignIn_Btn = By.XPath("//h2[@class='okta-form-title o-form-head']");


        ////*************** PAGE METHODS ***************////

        public string GetWelcomeMessage() => GetText(_welcomeMessage);
        public void ClickLoginLink() => Click(_loginLink);
        public string GetOktaSignInText() => GetText(_okta_SignIn_Btn);

    }
        
}

