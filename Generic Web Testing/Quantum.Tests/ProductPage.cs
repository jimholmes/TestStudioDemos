using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Quantum.Tests
{
    public class ProductPage
    {
        IWebDriver browser;

        [FindsBy(How = How.XPath, 
            Using = "id('ctl00_content_C017_ctl00_ctl00_siteMapControl_verticalsimple')//ul")]
        public IWebElement NotebookProductList { get; set; }


        public ProductPage(IWebDriver browser)
        {
            this.browser = browser;

            if (browser.Title !=
                "Products")
            {
                throw new ElementNotVisibleException(
                                                     "Current page's title doesn't match expected. Current page: " +
                                                     browser.Title);
            }
        }
    }
}
