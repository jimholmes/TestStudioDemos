using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebDriverDemo
{
    [TestFixture]
    class AjaxIssues
    {
        IWebDriver browser;

        [TestFixtureSetUp]
        public void Run_once_before_anything()
        {
            var profile = new FirefoxProfile();
            profile.Clean();
            var exe = new FirefoxBinary();
            browser = new FirefoxDriver(exe, profile);
        }

        [TestFixtureTearDown]
        public void Run_once_after_everything()
        {
            browser.Quit();
        }

        [Test]
        public void Implicit_wait_for_element_to_appear()
        {
            IWebDriver browser = new FirefoxDriver();
            browser.Navigate().GoToUrl(
                "http://localhost/AJAXDemo/DropDown/DropDown.aspx");
            browser.FindElement(
                By.Id("ctl00_SampleContent_TextLabel")).Click();
          
            browser.FindElement(
                By.Id("ctl00_SampleContent_Option1")).Click();

            browser.Manage().Timeouts().
                ImplicitlyWait(TimeSpan.FromSeconds(10));
            
            Assert.IsTrue(browser.FindElement(By.Id("ctl00_SampleContent_lblSelection"))
                                 .Text
                                 .Contains("Mocha Blast"));
            browser.Quit();
        }

        [Test]
        public void Explicit_wait_for_content_to_appear_in_existing_element()
        {
            string make = "Acura";
            string model = "Integra";
            string color = "Sea Green";
            WebDriverWait wait = 
                new WebDriverWait(browser, 
                    TimeSpan.FromSeconds(10));
            string targetURL = "http://www.asp.net/ajaxLibrary/AjaxControlToolkitSampleSite/CascadingDropDown/CascadingDropDown.aspx";
            //string targetURL = "http://localhost/AJAXDemo/CascadingDropDown/CascadingDropDown.aspx";
            browser.Navigate().GoToUrl(targetURL);

            Wait_for_make_option_to_populate(make, wait);
            Select_make_from_list(make);

            Wait_for_model_option_to_populate(model, wait);
            Select_model_from_list(model);

            Wait_for_color_option_to_populate(color, wait);
            Select_color_from_list(color);

            Wait_for_message_to_populate(color, wait);            
        }
  
        private void Select_color_from_list(string color)
        {
            var listOfColors = browser.FindElement(By.Id("ctl00_SampleContent_DropDownList3"));
            var colorOptions = new SelectElement(listOfColors);
            colorOptions.SelectByText(color);
        }
  
        private void Select_model_from_list(string model)
        {
            var listOfModels = browser.FindElement(By.Id("ctl00_SampleContent_DropDownList2"));
            var modelOptions = new SelectElement(listOfModels);
            modelOptions.SelectByText(model);
        }
  
        private void Select_make_from_list(string make)
        {
            var listOfMakes = browser.FindElement(By.Id("ctl00_SampleContent_DropDownList1"));
            var makeOptions = new SelectElement(listOfMakes);
            makeOptions.SelectByText(make);
        }
  
        private void Wait_for_color_option_to_populate(string color, WebDriverWait wait)
        {
            wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                    "id('ctl00_SampleContent_DropDownList3')/option[text()='" + color + "']"));
            });
        }
  
        private void Wait_for_model_option_to_populate(string model, WebDriverWait wait)
        {
            wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                    "id('ctl00_SampleContent_DropDownList2')/option[text()='" + model + "']"));
            });
        }
  
        private void Wait_for_make_option_to_populate(string make, WebDriverWait wait)
        {
            wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                    "id('ctl00_SampleContent_DropDownList1')/option[text()='"+ make + "']"));
            });
        }

        private void Wait_for_message_to_populate(string message, WebDriverWait wait)
        {
            wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                    "id('ctl00_SampleContent_Label1')[contains(.,'" + message + "')]"));
            });
        }

        [Test]
        public void Working_with_no_content_data_driven()
        {
            IList<Car> cars = CarFactory.Return_three_valid_cars();

            browser.Navigate().GoToUrl("http://www.asp.net/ajaxLibrary/AjaxControlToolkitSampleSite/CascadingDropDown/CascadingDropDown.aspx");
                //"http://localhost/AJAXDemo/CascadingDropDown/CascadingDropDown.aspx");
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            foreach (Car car in cars)
            {
                browser.Navigate().Refresh();

                Wait_for_make_option_to_populate(car.Make, wait);
                Select_make_from_list(car.Make);

                Wait_for_model_option_to_populate(car.Model, wait);
                Select_model_from_list(car.Model);

                Wait_for_color_option_to_populate(car.Color, wait);
                Select_color_from_list(car.Color);

                Validate_message(car, wait);
            }
        }
  
        private void Validate_message(Car car, WebDriverWait wait)
        {
            var messageActual = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath(
                                              "id('ctl00_SampleContent_Label1')[contains(.,'" +
                                              car.Message + "')]"));
            });
            Assert.IsTrue(messageActual.Text.Contains(car.Message), "Message: " +
                                                                    messageActual.Text);
        }        
    }

    public static class CarFactory
    {
        public static IList<Car> Return_three_valid_cars()
        {
            return new List<Car>
            {
                new Car
                {
                    Make = "Acura", Model = "Integra", Color = "Sea Green",
                    Message = "Sea Green Acura Integra"
                },
                new Car
                {
                    Make = "Audi", Model = "S4", Color = "Metallic",
                    Message = "Metallic Audi S4"
                },
                new Car
                {
                    Make = "BMW", Model = "7 series", Color = "Brown",
                    Message = "Brown BMW 7 series"
                }
            };
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Message { get; set; }
    }
}