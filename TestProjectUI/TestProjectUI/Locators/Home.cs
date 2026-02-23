using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.Locators
{
    internal class Home
    {
        // Section Title
        public By titleBy = By.XPath("//h1");

        // Buttons
        public By bookNowBy = By.XPath("//a[text()='Book Now']");

        // QuickLinks
        public static By GenerateQuickLinkXPath(string pageName)
        {
            // Possible options for the quick links: [Rooms, Booking, Amenities, Location, Contact, Admin]
            string quickLinkXPath = String.Format("//nav//a[text()='{0}']", pageName);
            By quickLinkBy;
            return quickLinkBy = By.XPath(quickLinkXPath);
        }
    }
}
