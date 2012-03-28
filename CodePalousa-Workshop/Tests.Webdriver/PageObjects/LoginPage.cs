using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Webdriver.PageObjects
{
    public class LoginPage
    {
        IWebDriver browser;

        [FindsBy(How = How.XPath, Using = "id('top-menu')/a[3]")]
        IWebElement LoginLink { get; set; }

        [FindsBy(How=How.Id)]
        IWebElement username { get; set; }
        [FindsBy(How=How.Id)]
        IWebElement password { get; set; }
        [FindsBy(How=How.Id)]
        IWebElement login_button { get; set; }


        public LoginPage(IWebDriver browser)
        {
            this.browser = browser;

            if (browser.Title !=
                "Telerik Customer Relations Management System")
            {
                throw new ElementNotVisibleException(
                                                     "Current page's title doesn't match expected. Current page: " +
                                                     browser.Title);
            }
        }

        public HomePage LogonAs(string username, string password)
        {
            Logon_as_a_user(username, password);
            
            return new HomePage(browser);
        }
  
        private void Logon_as_a_user(string username, string password)
        {
            Logout_if_needed();
            LoginLink.Click();
            this.username.SendKeys(username);
            this.password.SendKeys(password);
            login_button.Click();
        }

        private void Logout_if_needed()
        {
            if (LoginLink.Text.Contains("Logout"))
            {
                LoginLink.Click();
            }
        }

        public string LogonAsExpectingErrorMessage(string username, string password)
        {
            Logon_as_a_user(username, password);
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            return browser.FindElement(By.Id("flash_alert")).Text;
        }
    }
}