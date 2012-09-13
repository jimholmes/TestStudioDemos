using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DemoApp.Tests.PageObjects
{
    public class HomePage
    {
        IWebDriver browser;

        [FindsBy(How = How.XPath, Using = "id('top-menu')/a[3]")]
        public IWebElement LogoutLink { get; set; }
        
        public HomePage(IWebDriver browser)
        {
            this.browser = browser;
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            wait.Until<IWebElement>((d) =>
            {
                return browser.FindElement(By.Id("description"));
            });

            if (! browser.Url.Contains("/contacts"))
            {
                throw new ElementNotVisibleException(
                                                     "Current page's Url doesn't match expected. Current page: " +
                                                     browser.Url);
            }
        }
    }
}
