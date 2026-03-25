using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Drivers;

namespace TestAssignment.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WaitHelper wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WaitHelper(driver);
        }

    }
}
