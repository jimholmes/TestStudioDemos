using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Webdriver.PageObjects
{
    [TestFixture]
    public class When_logging_on_to_system
    {
        IWebDriver browser;

        [TestFixtureSetUp]
        public void run_before_any_tests()
        {
            browser = new FirefoxDriver();

            //WARNING: If using IE driver remember to switch
            // to x86 target. Performance of IE driver in 
            // x64 targets sucks bong water.
            //browser = new InternetExplorerDriver();
        }

        [TestFixtureTearDown]
        public void run_after_all_tests_are_complete()
        {
            browser.Quit();
        }

        [SetUp]
        public void run_once_before_EACH_test()
        {
            browser.Navigate().GoToUrl("http://localhost:3000");        	
        }

        [Test]
        public void providing_incorrect_credentials_returns_error_message()
        {
            LoginPage login = new LoginPage(browser);
            string expected = "Invalid username or password";
            string actual = login.LogonAsExpectingErrorMessage("foo", "bar");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void providing_correct_creds_takes_user_to_home_page()
        {
            LoginPage login = new LoginPage(browser);
            PageFactory.InitElements(browser, login);
            HomePage home = login.LogonAs("testuser", "abc123");
            PageFactory.InitElements(browser, home);
            Assert.AreEqual("Logout", home.LogoutLink.Text);
            string targetUrl = home.LogoutLink.GetAttribute("href");
            Assert.IsTrue(targetUrl.EndsWith("/logout"));          
        }
    }
}
