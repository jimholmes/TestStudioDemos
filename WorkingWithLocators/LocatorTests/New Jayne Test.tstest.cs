using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;

namespace LocatorTests
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class New_Jayne_Test : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion

        [CodedStep(@"New Coded Step")]
        public void New_Jayne_Test_CodedStep()
        {

            //RadGrid grid = Pages.DemoPage.Content_Grid;

            RadGrid grid = Pages.DemoPage.Content_Grid;
                        
            IList<Element> newEarthContacts =
               grid.Find.AllByContent("New Earth");

            Log.WriteLine("Count of rows: " + newEarthContacts.Count);

            Assert.AreEqual(2, newEarthContacts.Count);

        }

        [CodedStep(@"New Coded Step")]
        public void New_Jayne_Test_CodedStep1()
        {
            // RadGrid grid = Pages.DemoPage.Content_Grid;

            RadGrid grid = Find.ById<RadGrid>("ctl00_MainContent_PeopleGrid");
            HtmlTableRow jayne = grid.Find.TableRow("Cobb");
            Assert.IsNotNull(jayne);
            Assert.IsTrue(jayne.InnerText.Contains("Jayne"));

            HtmlAnchor edit = jayne.Find.ByContent<HtmlAnchor>("Edit");
            edit.Click();

            //asserts that edit fields show properly
        }
        
        // Add your test methods here...
    }
}
