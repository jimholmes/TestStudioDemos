using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Tests.Webdriver
{
    [TestFixture]
    public class When_logging_on_successfully_refactored
    {
        private IWebDriver browser;

        [TestFixtureSetUp]
        public void Run_before_any_tests()
        {
            this.browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("http://localhost:3000");   	
        }

        [TestFixtureTearDown]
        public void Run_after_all_tests_are_complete()
        {
            browser.Quit();        	
        }

        private const string LOGOUT_MENU_ITEM = "id('top-menu')/a[contains(.,'Logout')]";

        [Test]
        public void Top_menu_bar_should_show_login_with_correct_target()
        {
            browser.FindElement(By.Id("login_link")).Click();

            browser.FindElement(By.Id("username")).SendKeys("testuser");
            browser.FindElement(By.Id("password")).SendKeys("abc123");

            browser.FindElement(By.Id("login_button")).Click();

            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            IWebElement menuElement = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(LOGOUT_MENU_ITEM));
            });

            Assert.IsTrue(menuElement
                                 .Text
                                 .Equals("Logout"));
            Assert.IsTrue(menuElement
                                 .GetAttribute("href")
                                 .Equals("http://localhost:3000/logout"));
        }
    }
}