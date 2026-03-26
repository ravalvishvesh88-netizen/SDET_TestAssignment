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
        //private IWebElement FirstName => driver.FindElement(By.Id("customer.firstName"));

        private By FirstName = By.Id("customer.firstName");
        private By LastName = By.Id("customer.lastName");
        private By Address = By.Id("customer.address.street");
        private By City = By.Id("customer.address.city");
        private By State = By.Id("customer.address.state");
        private By ZipCode = By.Id("customer.address.zipCode");
        private By Phone = By.Id("customer.phoneNumber");
        private By SSN = By.Id("customer.ssn");
        private By Username = By.Id("customer.username");
        private By Password = By.Id("customer.password");
        private By ConfirmPassword = By.Id("repeatedPassword");
        private By RegisterButton = By.CssSelector("input[value='Register']");
        private By Register_NewUser = By.XPath("//a[text()='Register']");

        // Error locators
        public By FirstNameError =>  By.Id("customer.firstName.errors");
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
            return wait.WaitForElement(locator).Text;

        }


        //Navigate to Home Page
        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
        }


        public void RegisterLinkClick()
        {
            wait.WaitForElement(Register_NewUser).Click();
        }

        // Fill Registration Form
        public void FillRegistrationForm(string fname, string lname, string addr, string city,
                                         string state, string zip, string phone, string ssn,
                                         string username, string password)
        {
            wait.WaitForElement(FirstName).SendKeys(fname);
            wait.WaitForElement(LastName).SendKeys(lname);
            wait.WaitForElement(Address).SendKeys(addr);
            wait.WaitForElement(City).SendKeys(city);
            wait.WaitForElement(State).SendKeys(state);
            wait.WaitForElement(ZipCode).SendKeys(zip);
            wait.WaitForElement(Phone).SendKeys(phone);
            wait.WaitForElement(SSN).SendKeys(ssn);
            wait.WaitForElement(Username).SendKeys(username);
            wait.WaitForElement(Password).SendKeys(password);
            wait.WaitForElement(ConfirmPassword).SendKeys(password);
        }

        public void ClickRegister()
        {
            wait.WaitForElement(RegisterButton).Click();
        }



    }
}
