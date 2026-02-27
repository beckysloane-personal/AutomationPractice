using System;
using System.Collections.Generic;
using System.Text;
using TestProjectUI.DriverAndSettings;
using static TestProjectUI.DriverAndSettings.Driver;

namespace TestProjectUI.Methods
{
    public class BaseMethods
    {
        public static void NavigeteToUrl()
        {
            driver.Navigate().GoToUrl(Driver.baseUrl);
        }

    }
}
