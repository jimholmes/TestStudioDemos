using System;
using System.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NUnit.Framework;

namespace WebDriver
{
    [TestFixture]
    public class Home_page_displays_correctly
    {
        IWebDriver browser;

        [TestFixtureSetUp]
        public void Run_once_before_anything()
        {
            var profile = new FirefoxProfile();
            profile.Clean();
            var exe = new FirefoxBinary();
            browser = new FirefoxDriver(exe, profile);
            browser.Navigate().GoToUrl("http://growing-planet-634.herokuapp.com/welcome");
        }

        [TestFixtureTearDown]
        public void Run_once_after_everything()
        {
            browser.Quit();
        }

        [Test]
        public void Login_link_is_correct()
        {
            IWebElement loginLink = browser.FindElement(By.Id("login_link"));
            Assert.IsTrue(loginLink.Text.Equals("Login"));
            Assert.IsTrue(loginLink.GetAttribute("href").Contains("/login"));
        }
    }

    [TestFixture]
    public class Can_log_in_to_system
    {
        IWebDriver browser;

        [TestFixtureSetUp]
        public void Run_once_before_anything()
        {
            var profile = new FirefoxProfile();
            var exe = new FirefoxBinary();
            browser = new FirefoxDriver(exe, profile);

            browser.Navigate().GoToUrl("http://growing-planet-634.herokuapp.com/welcome");

            browser.FindElement(By.Id("login_link")).Click();

            browser.FindElement(By.Id("username")).SendKeys("testuser");
            browser.FindElement(By.Id("password")).SendKeys("abc123");
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            browser.FindElement(By.Id("login_button")).Click();

        }

        [TestFixtureTearDown]
        public void Run_once_after_everything()
        {
            browser.Quit();
        }

        [Test]
        public void Logout_link_displays()
        {
            Assert.IsTrue(browser.FindElement(By.LinkText("Logout")).Displayed);
        }
    }
}
