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

        [TestFixture]
        public class When_logging_on_successfully
        {

            [Test]
            public void Top_menu_bar_should_show_login_with_correct_target()
            {
                IWebDriver browser = new FirefoxDriver();
                browser.Navigate().GoToUrl("http://localhost:3000");

                browser.FindElement(By.Id("login_link")).Click();

                browser.FindElement(By.Id("username")).SendKeys("testuser");
                browser.FindElement(By.Id("password")).SendKeys("abc123");

                browser.FindElement(By.Id("login_button")).Click();

                WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
                wait.Until<bool>((d) =>
                {
                    return d.FindElement(By.XPath("id('top-menu')/a[3]")).Text.Equals("Logout");
                });

                Assert.IsTrue(browser.FindElement(By.XPath("id('top-menu')/a[3]")).Text.Equals("Logout"));
                Assert.IsTrue(browser.FindElement(By.XPath("id('top-menu')/a[3]"))
                                     .GetAttribute("href")
                                     .Equals("http://localhost:3000/logout"));

                browser.Quit();
            }
        }

    
}
