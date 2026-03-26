using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestAssignment.Drivers
{
    public class WaitHelper
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public WaitHelper(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver,TimeSpan.FromSeconds(10));
        }

        public IWebElement WaitForElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

    }
}
