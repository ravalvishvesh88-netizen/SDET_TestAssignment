using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Drivers;
using TestAssignment.Pages;

namespace TestAssignment.Pages
{
    public class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver) { }

        //Locators
        private IWebElement FirstName => driver.FindElement(By.Id("customer.firstName"));
        private IWebElement LastName => driver.FindElement(By.Id("customer.lastName"));
        private IWebElement Address => driver.FindElement(By.Id("customer.address.street"));
        private IWebElement City => driver.FindElement(By.Id("customer.address.city"));
        private IWebElement State => driver.FindElement(By.Id("customer.address.state"));
        private IWebElement ZipCode => driver.FindElement(By.Id("customer.address.zipCode"));
        private IWebElement Phone => driver.FindElement(By.Id("customer.phoneNumber"));
        private IWebElement SSN => driver.FindElement(By.Id("customer.ssn"));
        private IWebElement Username => driver.FindElement(By.Id("customer.username"));
        private IWebElement Password => driver.FindElement(By.Id("customer.password"));
        private IWebElement ConfirmPassword => driver.FindElement(By.Id("repeatedPassword"));
        private IWebElement RegisterButton => driver.FindElement(By.CssSelector("input[value='Register']"));

        private IWebElement Register_NewUser => driver.FindElement(By.XPath("//a[text() = \"Register\"]"));

        // Error locators
        public By FirstNameError => By.Id("customer.firstName.errors");
        public By LastNameError => By.Id("customer.lastName.errors");
        public By AddressError => By.Id("customer.address.street.errors");
        public By CityError => By.Id("customer.address.city.errors");
        public By StateError => By.Id("customer.address.state.errors");
        public By ZipError => By.Id("customer.address.zipCode.errors");
        public By SSNError => By.Id("customer.ssn.errors");
        public By UsernameError => By.Id("customer.username.errors");
        public By PasswordError => By.Id("customer.password.errors");
        public By ConfirmPasswordError => By.Id("repeatedPassword.errors");

        public string GetError(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator)).Text;
        }


        //Navigate to Home Page
        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
        }

        public void RegisterLinkClick()
        {
            Register_NewUser.Click();
        }

        // Fill Registration Form
        public void FillRegistrationForm(string fname, string lname, string addr, string city,
                                         string state, string zip, string phone, string ssn,
                                         string username, string password)
        {
            FirstName.SendKeys(fname);
            LastName.SendKeys(lname);
            Address.SendKeys(addr);
            City.SendKeys(city);
            State.SendKeys(state);
            ZipCode.SendKeys(zip);
            Phone.SendKeys(phone);
            SSN.SendKeys(ssn);
            Username.SendKeys(username);
            Password.SendKeys(password);
            ConfirmPassword.SendKeys(password);
        }

        public void ClickRegister()
        {
            RegisterButton.Click();
        }



    }
}
