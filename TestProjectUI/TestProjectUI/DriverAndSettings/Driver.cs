using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.DriverAndSettings
{
    internal class Driver
    {
        public static IWebDriver driver;

        public IWebDriver CreateDriver()
        {
            var chromeOptions = new ChromeOptions();

            IWebDriver driver = new ChromeDriver(chromeOptions);
            return driver;
        }

    }
}
