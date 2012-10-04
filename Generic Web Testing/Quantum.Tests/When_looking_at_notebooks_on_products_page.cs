using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace Quantum.Tests
{
    [TestFixture]
    public class When_looking_at_notebooks_on_products_page
    {
        IWebDriver browser;
        ProductPage products;

        [TestFixtureSetUp]
        public void run_before_any_tests()
        {
            browser = new FirefoxDriver();

            //WARNING: If using IE driver remember to switch
            // to x86 target. Performance of IE driver in 
            // x64 targets sucks bong water.
            //browser = new InternetExplorerDriver();
        }

        [TestFixtureTearDown]
        public void run_after_all_tests_are_complete()
        {
            browser.Quit();
        }

        [SetUp]
        public void run_once_before_EACH_test()
        {
            browser.Navigate().GoToUrl("http://quantum.sitefinity.com/products");
            products = new ProductPage(browser);
            PageFactory.InitElements(browser, products);
        }

        [Test]
        public void list_of_notebooks_should_show_proper_results()
        {
            IWebElement list = products.NotebookProductList;
            IList<IWebElement> contents = list.FindElements(By.TagName("li"));
            
            Assert.AreEqual(6, contents.Count);

            IList<string> itemNames = new List<string>();
            foreach (var item in contents)
            {
                itemNames.Add(item.Text);
            }

        }
    }
}
