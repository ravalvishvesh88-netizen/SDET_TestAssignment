using TestAssignment.Logs;
using TestAssignment.Pages;

namespace TestAssignment.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        private LoginPage loginPage;
        private HomePage homePage;

        [SetUp]
        public void TestSetup()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            loginPage.Navigate();
        }

        [Test]
        public void Login_CorrectCredentials()
        {
            LogManager.Info("Input User Credentials");
            loginPage.Login("Username123", "Password123");
            bool IsDisplayed = homePage.IsLoggedIn();
            Assert.IsTrue(IsDisplayed,"Login failed with valid credentials");

        }

        [Test]
        public void Login_IncorrectCredentials() 
        {
            LogManager.Info("Input Wrong User Credentials");
            loginPage.Login("invalid", "wrong");
            bool ErrorText = homePage.InvalidLogInError();
            Assert.IsTrue(ErrorText, "Login failed with wrong input");
        }

        [Test]
        public void Login_BlankCredentials()
        {
            LogManager.Info("Input Blank User Credentials");
            loginPage.Login("", "");
            Assert.IsTrue(homePage.BlankFieldsError(),"Login failed with blank user credentials");
        }

    }
}
