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
    public class When_logging_on_to_system
    {
        [Test]
        public void providing_correct_credentials_logs_user_on()
        {
            IWebDriver browser = new FirefoxDriver();

            browser.Navigate().GoToUrl("http://growing-planet-634.herokuapp.com/welcome");

            browser.FindElement(By.Id("login_link")).Click();

            browser.FindElement(By.Id("username")).SendKeys("testuser");
            browser.FindElement(By.Id("password")).SendKeys("abc123");

            browser.FindElement(By.Id("login_button")).Click();

            WebDriverWait wait = 
                new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementExists(
                By.LinkText("Logout")));

            string actual = 
                browser.FindElement(By.Id("logout_link")).Text;

            Assert.AreEqual("Logout", actual);

            browser.Quit();

        }
    }
}
