using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Webdriver.PageObjects
{
    public class LoginPage
    {
        IWebDriver browser;

        public LoginPage(IWebDriver browser)
        {
            this.browser = browser;

            if (browser.Title != "Telerik Customer Relations Management System")
            {
                throw new ElementNotVisibleException(
                                                     "Current page's title doesn't match expected. Current page: " +
                                                     browser.Title);
            }
        }

        public HomePage LogonAs(string username, string password)
        {
            browser.FindElement(By.Id("login_link")).Click();
            browser.FindElement(By.Id("username")).SendKeys(username);
            browser.FindElement(By.Id("password")).SendKeys(password);
            browser.FindElement(By.Id("login_button")).Click();
            
            return new HomePage(browser);
        }

        public string LogonAsExpectingErrorMessage(string username, string password)
        {
            browser.FindElement(By.Id("login_link")).Click();
            browser.FindElement(By.Id("username")).SendKeys(username);
            browser.FindElement(By.Id("password")).SendKeys(password);
            browser.FindElement(By.Id("login_button")).Click();
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            return browser.FindElement(By.Id("flash_alert")).Text;
        }
    }
}