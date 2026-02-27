using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using static TestProjectUI.DriverAndSettings.Driver;

namespace TestProjectUI.DriverAndSettings
{
    public class ElementUtils
    {
        // Find element with a default timeout of 5000ms
        public IWebElement FindElement(By by)
        {
            TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
            var wait = new WebDriverWait(driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            return wait.Until(d => d.FindElement(by));
        }

        // Check if an element is present on the page
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
