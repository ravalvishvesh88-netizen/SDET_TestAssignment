using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private By username = By.Name("username");
        private By password = By.Name("password");
        private By loginBtn = By.CssSelector("input[value = 'Log In']");
        private By errorMsg = By.CssSelector(".error");

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
        }

        public void Login(string user, string pass)
        {
            wait.WaitForElement(username).SendKeys(user);
            wait.WaitForElement(password).SendKeys(pass);
            driver.FindElement(loginBtn).Click();

        }

        public string GetError()
        {
            return wait.WaitForElement(errorMsg).Text;
        }


    }
    
}
