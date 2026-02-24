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

        public static By GenerateTVXPath(string roomSize)
        {
            string tvXPath = String.Format("//h5[text()='{0}']/following-sibling::div//i[@class='bi bi-tv me-1']", roomSize);
            By tvBy;
            return tvBy = By.XPath(tvXPath);
        }

        public static By GenerateWifiXPath(string roomSize)
        {
            string wifiXPath = String.Format("//h5[text()='{0}']/following-sibling::div//i[@class='bi bi-wifi me-1']", roomSize);
            By wifiBy;
            return wifiBy = By.XPath(wifiXPath);
        }

        public static By GenerateSafeXPath(string roomSize)
        {
            string safeXPath = String.Format("//h5[text()='{0}']/following-sibling::div//i[@class='bi bi-safe me-1']", roomSize);
            By safeBy;
            return safeBy = By.XPath(safeXPath);
        }

        public static By GenerateRadioXPath(string roomSize)
        {
            string radioXPath = String.Format("//h5[text()='{0}']/following-sibling::div//i[@class='bi bi-speaker me-1']", roomSize);
            By radioBy;
            return radioBy = By.XPath(radioXPath);
        }

        public static By GeneratePriceXPath(string roomSize)
        {
            string priceXPath = String.Format("//h5[text()='{0}']/parent::div/following-sibling::div/div", roomSize);
            By priceBy;
            return priceBy = By.XPath(priceXPath);
        }

        public static By GenerateBookNowXPath(string roomSize)
        {
            string bookNowXPath = String.Format("//h5[text()='{0}']/parent::div/following-sibling::div/a[text()='Book now']", roomSize);
            By bookNowBy;
            return bookNowBy = By.XPath(bookNowXPath);
        }
    }
}
