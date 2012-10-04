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
    public class WorkingWithTables
    {
        IWebDriver browser;
        WebDriverWait wait;

        private const string RADGRID = "RadGrid1_ctl00";

        [TestFixtureSetUp]
        public void Run_once_before_any_tests()
        {
            browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("http://demos.telerik.com/aspnet-ajax/grid/examples/programming/webmail/defaultcs.aspx");
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
        }

        [TestFixtureTearDown]
        public void Run_once_after_all_tests_are_completed()
        {
            //browser.Quit();
        }

        [Test]
        public void Outlook_grid_has_two_sharepoint_mails()
        {
            int numHits = 0;

            wait.Until(ExpectedConditions.ElementExists(By.Id(RADGRID)));
            IWebElement table = browser.FindElement(By.Id(RADGRID));
            IList<IWebElement> rows = 
                table.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                if (row.Text.Contains("Sharepoint"))
                {
                    numHits++;
                }
            }

            Assert.AreEqual(3, numHits);
        }


        [Test]
        public void Can_check_mail_from_tsholl()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id(RADGRID)));
            IWebElement table = browser.FindElement(By.Id(RADGRID));

            IWebElement tshollRow = null;
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                if (row.Text.Contains("TSholl@web.com"))
                {
                    tshollRow = row;
                }
            }

            IWebElement checkbox = 
                tshollRow.FindElement(By.TagName("input"));
            checkbox.Click();

            Assert.AreEqual(true, checkbox.Selected);

        }
    }
}
