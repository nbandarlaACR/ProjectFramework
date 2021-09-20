using BoDi;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Enterprise.Framework.GenericLib;
using AutomationFramework.ProjectLib;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelizable(ParallelScope.Fixtures)]
//[assembly: Parallelizable(ParallelScope.Self)]
//[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]
namespace AutomationFramework.Hooks
{
    [Binding]
    public class LoadConfig
    {
        private readonly IObjectContainer _container;

        public LoadConfig(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(Order = -100)]
        public void Load()
        {
            XmlConfigurator.Configure();
            var data = new RunData();
            _container.RegisterInstanceAs<IRunData>(data);
        }
    }
}
