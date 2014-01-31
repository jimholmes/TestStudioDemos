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

namespace TestStudioTests
{
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
            RadGrid grid = Pages.HomePage.Content_Grid;
            IList<Element> newEarthContacts =
               grid.Find.AllByContent("New Earth");
            Assert.AreEqual(2, newEarthContacts.Count);

        }

        [CodedStep(@"New Coded Step")]
        public void New_Jayne_Test_CodedStep1()
        {
                RadGrid grid = 
                    Find.ById<RadGrid>("ctl00_MainContent_PeopleGrid");
                HtmlTableRow jayne = grid.Find.TableRow("Cobb");
                Assert.IsNotNull(jayne);
                Assert.IsTrue(jayne.InnerText.Contains("Jayne"));

                HtmlAnchor edit = jayne.Find.ByContent<HtmlAnchor>("Edit");
                edit.Click();

            //asserts that edit fields show properly    
        }

        [CodedStep(@"New Coded Step")]
        public void CodedExamples_CodedStep()
        {
            //RadGrid grid = Pages.HomePage.Content_Grid;
            IList<HtmlTableRow> rows = Find.AllByXPath<HtmlTableRow>("//tbody/tr");
            Assert.AreEqual(9, rows.Count);

        }
        
        // Add your test methods here...
    }
}
