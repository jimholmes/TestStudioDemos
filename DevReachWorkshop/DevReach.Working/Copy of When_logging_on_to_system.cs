using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace DevReach.Working
{
    [TestFixture]
    public class Refactored_when_logging_on_to_system
    {
        IWebDriver browser;
        WebDriverWait wait;

        [TestFixtureSetUp]
        public void Run_once_before_any_tests()
        {
            browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("http://growing-planet-634.herokuapp.com/welcome");

            wait =
                new WebDriverWait(browser, TimeSpan.FromSeconds(10));
        }

        [TestFixtureTearDown]
        public void Run_after_all_tests_are_complete()
        {
            browser.Quit();        	
        }

        private const string LOGOUTLINKID = "logout_link";

        [Test]
        public void providing_correct_credentials_logs_user_on()
        {

            Log_on_to_system("testuser", "abc123");          

            wait.Until(ExpectedConditions.ElementExists(
                By.LinkText("Logout")));

            string actual =
                browser.FindElement(By.Id(LOGOUTLINKID)).Text;

            Assert.AreEqual("Logout", actual);
        }

        [Test]
        public void invalid_credentials_cause_error_message()
        {
            Log_on_to_system("testuser", "badpassword");

            wait.Until(ExpectedConditions.ElementIsVisible(
                By.Id("flash_alert")));

            string actual =
                browser.FindElement(By.Id("flash_alert")).Text;

            Assert.AreEqual("Invalid username or password", actual);

           
        }

        private const string LOGINLINKID = "login_link";

        private void Log_on_to_system(string username, string password)
        {
            browser.FindElement(By.Id(LOGINLINKID)).Click();

            //browser.FindElement(By.Id("username")).SendKeys(username);
            browser.FindElement(
                By.XPath("//label[text()='Username']/../input"))
                .SendKeys(username);
            browser.FindElement(By.Id("password")).SendKeys(password);

            browser.FindElement(By.Id("login_button")).Click();
        }
    }
}
