using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.DriverAndSettings
{
    public class Hooks
    {
        public IWebDriver CreateDriver()
        {
            var chromeOptions = new ChromeOptions();

            IWebDriver driver = new ChromeDriver(chromeOptions);
            return driver;
        }

        [Binding]
        public class GlobalHooks
        {
            protected FeatureContext featureContext;
            protected ScenarioContext scenarioContext;


            public GlobalHooks(FeatureContext featureContext, ScenarioContext scenarioContext)
            {
                this.featureContext = featureContext;
                this.scenarioContext = scenarioContext;
            }
        }

        [BeforeScenario]
        public void InitializeScenario(ScenarioContext scenarioContext)
        {
            var driver = CreateDriver();
            scenarioContext["driver"] = driver;
        }
    }
}
