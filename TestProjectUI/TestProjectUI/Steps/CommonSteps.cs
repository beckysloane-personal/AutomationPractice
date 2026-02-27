using Reqnroll;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectUI.Methods;

namespace TestProjectUI.Steps
{
    [Binding]
    public class CommonSteps
    {      
        [Given("I am on the hotel booking page")]
        public void GivenIAmOnTheHotelBookingPage()
        {
            BaseMethods.NavigeteToUrl();
        }

    }
}
