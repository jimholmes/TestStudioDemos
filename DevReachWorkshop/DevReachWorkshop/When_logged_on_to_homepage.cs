using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace DevReachWorkshop
{
    [TestFixture]
    public class When_logged_on_to_homepage
    {
        IWebDriver browser;
        WebDriverWait wait;

        private const string URL = "http://growing-planet-634.herokuapp.com";

        [TestFixtureSetUp]
        public void Run_once_before_any_tests()
        {
            FirefoxProfile profile = new FirefoxProfile();
            //FirefoxProfile profile = new FirefoxProfile(@"D:\temp\FirefoxProfile");
            profile.SetPreference("browser.download.dir", @"D:\temp\");
            //profile.SetPreference("browser.download.folderList", 2);
            //profile.SetPreference("browser.helperApps.neverAsk.saveToDisk",
            //    "application/pdf"); 


            browser = new FirefoxDriver(profile);
            //browser = new FirefoxDriver();    
            browser.Navigate().GoToUrl(URL);
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            log_on_to_system();
        }

        [TestFixtureTearDown]
        public void Run_once_after_all_tests_are_completed()
        {
            //browser.Quit();
        }

        [Test]
        public void can_download_pdf()
        {
            IWebElement button = browser.FindElement(By.LinkText("Export to PDF"));
            button.Click();
        }

        private void log_on_to_system()
        {
            browser.FindElement(By.Id("login_link")).Click();

            browser.FindElement(By.Id("username")).SendKeys("testuser");
            browser.FindElement(By.Id("password")).SendKeys("abc123");
            browser.FindElement(By.Id("login_button")).Click();

            wait.Until<IWebElement>(ExpectedConditions.ElementExists(By.Id("logout_link")));

            Assert.That(
                browser.FindElement(By.Id("logout_link")).Text.Equals("Logout"));
        }
    }
}