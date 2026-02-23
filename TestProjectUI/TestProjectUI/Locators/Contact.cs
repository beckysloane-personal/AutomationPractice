using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.Locators
{
    public class Contact
    {
        // Section Ids
        public By sectionBy = By.Id("contact");

        // Section Title
        public By titleBy = By.XPath("//section[@id='contact']//h3");

        // Inputs
        public By nameBy = By.Id("name");
        public By emailBy = By.Id("email");
        public By phoneBy = By.Id("phone");
        public By subjectBy = By.Id("subject");
        public By messageBy = By.Id("description");

        // Buttons
        public By submitBy = By.XPath("//section[@id='contact']//button");
    }
}
