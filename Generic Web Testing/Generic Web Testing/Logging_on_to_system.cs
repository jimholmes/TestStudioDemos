using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace DemoApp.Tests
{
    public class Logging_on_to_system
    {
        
        [Test]
        public void Providing_correct_credentials_logs_user_on()
        {
            IWebDriver browser = new FirefoxDriver();

            browser.Navigate().GoToUrl("http://localhost:3000");

            browser.FindElement(By.Id("login_link")).Click();
            browser.FindElement(By.XPath("//label[contains(.,'Username')]/../input")).SendKeys("testuser");
            //browser.FindElement(By.Id("username")).SendKeys("testuser");
            browser.FindElement(By.Id("password")).SendKeys("abc123");
            browser.FindElement(By.Id("login_button")).Click();

            WebDriverWait wait =
                new WebDriverWait(browser,
                    TimeSpan.FromSeconds(10));
            IWebElement menuElement =
                wait.Until<IWebElement>((d) =>
                {
                    return d.FindElement(
                        By.XPath("id('description')"));
                });

            string text = browser.FindElement(By.XPath("id('top-menu')/a[3]")).Text;
            Assert.AreEqual("Logout", text);

            Assert.IsTrue(
                browser.FindElement(
                    By.XPath("id('top-menu')/a[3]")).GetAttribute("href").EndsWith("/logout"));



            browser.Quit();
        }
    }

}
