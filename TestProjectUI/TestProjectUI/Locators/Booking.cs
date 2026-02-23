using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.Locators
{
    public class Booking
    {
        // Section Ids
        public By sectionBy = By.Id("booking");

        // Section Title
        public By titleBy = By.XPath("//section[@id='booking']//h3");

        // Date Inputs - Format: DD/MM/YYYY
        public By checkInBy = By.XPath("//label[@for='checkin']/following-sibling::div//input");
        public By checkOutBy = By.XPath("//label[@for='checkout']/following-sibling::div//input");

        // Buttons
        public By checkAvailabilityBy = By.XPath("//section[@id='booking']//button");
    }
}
