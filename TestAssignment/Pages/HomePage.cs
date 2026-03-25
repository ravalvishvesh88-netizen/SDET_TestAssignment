using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        private By logoutLink = By.LinkText("Log Out");
        private By ErrorText = By.ClassName("error");
        private By BlankFields = By.XPath("//p[text()='Please enter a username and password.']");

        public bool IsLoggedIn()
        {
            return driver.FindElement(logoutLink).Displayed;
        }

        public bool InvalidLogInError()
        {
            return driver.FindElement(ErrorText).Displayed;
        }

        public bool BlankFieldsError()
        {
            return driver.FindElement(BlankFields).Displayed;
        }
    }
}
