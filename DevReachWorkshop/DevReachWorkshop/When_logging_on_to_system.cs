using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace DevReachWorkshop
{
    [TestFixture]
    public class When_logging_on_to_system
    {
        [Test]
        public void Correct_credentials_brings_user_to_homepage()
        {
            IWebDriver browser = new FirefoxDriver();

            browser.Navigate().GoToUrl("http://growing-planet-634.herokuapp.com");

            browser.FindElement(By.Id("login_link")).Click();

            browser.FindElement(By.Id("username")).SendKeys("testuser");
            browser.FindElement(By.Id("password")).SendKeys("abc123");
            browser.FindElement(By.Id("login_button")).Click();

            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            IWebElement menu = wait.Until<IWebElement>(ExpectedConditions.ElementExists(By.Id("logout_link")));

            Assert.That(
                browser.FindElement(By.Id("logout_link")).Text.Equals("Logout"));


            browser.Quit();

        }

    }
}
