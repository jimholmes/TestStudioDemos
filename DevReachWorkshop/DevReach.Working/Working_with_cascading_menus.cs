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
    public class Working_with_cascading_menus
    {
        IWebDriver browser;
        WebDriverWait wait;

        [TestFixtureSetUp]
        public void Run_once_before_any_tests()
        {
            browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("http://www.asp.net/ajaxLibrary/AjaxControlToolkitSampleSite/CascadingDropDown/CascadingDropDown.aspx");

            wait =
                new WebDriverWait(browser, TimeSpan.FromSeconds(10));
        }

        [TestFixtureTearDown]
        public void Run_after_all_tests_are_complete()
        {
            browser.Quit();
        }
        [Test]
        public void can_select_make_model_color()
        {
            wait_for_list_to_populate(1,"BMW");
            select_option(1, "BMW");

            wait_for_list_to_populate(2, "7 series");
            select_option(2, "7 series");

            wait_for_list_to_populate(3, "Brown");
            select_option(3, "Brown");

            wait_for_message_to_appear("You have chosen a Brown BMW 7 series. Nice car!");
            //wait_for_message_to_appear("Some other expected");
        	
        }

       
        private void wait_for_message_to_appear(string message)
        {
            wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                                              "//span[@id='ctl00_SampleContent_Label1' and text()='" +
                                              message + "']"));
            });

                
        }

        private void select_option(int listNum, string option)
        {
            var selectionList = 
                browser.FindElement(
                By.Id("ctl00_SampleContent_DropDownList"+listNum));
            var optionsList = new SelectElement(selectionList);
            optionsList.SelectByText(option);
        }
        private void wait_for_list_to_populate(int listNum, string option)
        {
            wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                    "id('ctl00_SampleContent_DropDownList"+
                    listNum+"')/option[text()='" +
                            option + "']"));
            });
        }
    }
}
