using Microsoft.Win32;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Pages;
using TestAssignment.Tests;
using TestAssignment.Logs;


namespace TestAssignment.Tests
{
    public class RegisterTests : BaseTest
    {
        private RegisterPage registerPage;
        //Runs before every test
        [SetUp]
        public void TestSetup()
        {
            registerPage = new RegisterPage(driver);
            registerPage.Navigate();
            registerPage.RegisterLinkClick();
        }

        [Test]
        public void Registration_Successful()
        {
            //var registerPage = new RegisterPage(driver);

            registerPage.Navigate();
            LogManager.Info("Click on the Register");
            registerPage.RegisterLinkClick();
            LogManager.Info("Fill registration Form");

            registerPage.FillRegistrationForm("FirstName",
                "LastName",
                "Sector 20",
                "Airoli",
                "Navi Mumbai",
                "400708",
                "123456789",
                "123456789",
                "Username123",
                "Password123");

            registerPage.ClickRegister();
        }

        [Test]
        public void Register_WithEmptyFields_ShouldShowValidationErrors()
        {
            LogManager.Info("Test Register User with all blank input fields");
           // var registerPage = new RegisterPage(driver);
            registerPage.Navigate();
            registerPage.RegisterLinkClick();
            registerPage.ClickRegister();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(registerPage.GetError(registerPage.FirstNameError), Is.EqualTo("First name is required."));
                Assert.That(registerPage.GetError(registerPage.LastNameError), Is.EqualTo("Last name is required."));
                Assert.That(registerPage.GetError(registerPage.AddressError), Is.EqualTo("Address is required."));
                Assert.That(registerPage.GetError(registerPage.CityError), Is.EqualTo("City is required."));
                Assert.That(registerPage.GetError(registerPage.StateError), Is.EqualTo("State is required."));
                Assert.That(registerPage.GetError(registerPage.ZipError), Is.EqualTo("Zip Code is required."));
                Assert.That(registerPage.GetError(registerPage.SSNError), Is.EqualTo("Social Security Number is required."));
                Assert.That(registerPage.GetError(registerPage.UsernameError), Is.EqualTo("Username is required."));
                Assert.That(registerPage.GetError(registerPage.PasswordError), Is.EqualTo("Password is required."));
                Assert.That(registerPage.GetError(registerPage.ConfirmPasswordError), Is.EqualTo("Password confirmation is required."));
            });


        }


    }
}
