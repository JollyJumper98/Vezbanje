using POM3.Driver;
using POM3.Page;

namespace POM3
{
    public class Tests
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();
        }
        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }

        [Test]
        public void TC01_PURCHASEOFBACKPACK()
        {
            Login("standard_user", "secret_sauce");
            _homePage.BackPack.Click();
            _homePage.AddButton.Click();
            _homePage.BackButton.Click();
        }
        public void Login(string name, string pass)
        {
            _loginPage.LoginOnPage(name, pass);
        }
    }
}