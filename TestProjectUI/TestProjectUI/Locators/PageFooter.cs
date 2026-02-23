using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectUI.Locators
{
    public class PageFooter
    {
        // Buttons
        public By facebookBy = By.ClassName("bi bi-facebook");
        public By instagramBy = By.ClassName("bi bi-instagram");
        public By twitterBy = By.ClassName("bi bi-twitter");

        // QuickLinks
        public static By GenerateQuickLinkXPath(string pageName)
        {
            // Possible options for the quick links: [Home, Rooms, Booking, Contact]
            string quickLinkXPath = String.Format("//footer//a[text()='{0}']", pageName);
            By quickLinkBy;
            return quickLinkBy = By.XPath(quickLinkXPath);
        }
    }
}
