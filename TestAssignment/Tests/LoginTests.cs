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
            Logs.Logger.Info("Input User Credentials");
            loginPage.Login("Username123", "Password123");
            bool IsDisplayed = homePage.IsLoggedIn();
            Assert.IsTrue(IsDisplayed);

        }

        [Test]
        public void Login_IncorrectCredentials() 
        {
            Logs.Logger.Info("Input Wrong User Credentials");
            loginPage.Login("invalid", "wrong");
            bool ErrorText = homePage.InvalidLogInError();
            Assert.IsTrue(ErrorText);
        }

        [Test]
        public void Login_BlankCredentials()
        {
            Logs.Logger.Info("Input Blank User Credentials");
            loginPage.Login("", "");
            Assert.IsTrue(homePage.BlankFieldsError());
        }

    }
}
