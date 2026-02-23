using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.Locators
{
    public class Location
    {
        // Section Ids
        public By sectionBy = By.Id("location");

        // Section Title
        public By titleBy = By.XPath("//section[@id='location']//h2");

        // Read Only Text Fields
        public By addressBy = By.XPath("//section[@id='location']//h5[text()='Address']/following-sibling::p");
        public By phoneBy = By.XPath("///section[@id='location']//h5[text()='Phone']/following-sibling::p"); 
        public By emailBy = By.XPath("//section[@id='location']//h5[text()='Email']/following-sibling::p");

    }
}
