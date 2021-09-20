using Enterprise.Framework.Actions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Pages
{    
    public class BasePage : WebActions
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IWebDriver _driver { get; }

        public BasePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }


    }
}
