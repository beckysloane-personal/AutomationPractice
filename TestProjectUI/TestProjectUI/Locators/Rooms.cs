using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.Locators
{
    public class Rooms
    {
        // Section Ids
        public By sectionBy = By.Id("rooms");

        // Room Types - Text
        public By singleBy = By.XPath("//h5[text()='Single']");
        public By doubleBy = By.Id("//h5[text()='Double']");
        public By suiteBy = By.Id("//h5[text()='Suite']");
        
    }
}
