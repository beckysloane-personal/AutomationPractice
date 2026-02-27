using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Text;
using static TestProjectUI.DriverAndSettings.Driver;

namespace TestProjectUI.DriverAndSettings
{
    public class Hooks
    {
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
            IWebDriver driver = new Driver().CreateDriver();
            scenarioContext["driver"] = driver;
        }

        [AfterScenario] 
        public void TearDownScenario(ScenarioContext scenarioContext)
        {
            var driver = scenarioContext["driver"] as IWebDriver;
            if (driver != null)
            {
                CloseDriver(driver);
            }
        }
        private static void CloseDriver(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
        }
    }
}
