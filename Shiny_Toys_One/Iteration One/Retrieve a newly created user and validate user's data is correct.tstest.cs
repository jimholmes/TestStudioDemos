using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using Telerik.WebAii.Controls.Xaml.Wpf;
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

namespace Shiny_Toys_One
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
        

    public class Retrieve_a_newly_created_user_and_validate_user_s_data_is_correct : BaseWebAiiTest
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
        
        // Add your test methods here...
    
        [CodedStep(@"Connect to pop-up window : 'http://localhost:3000/contacts/7', ConnectToPopup=True")]
        public void Retrieve_a_newly_created_user_and_validate_users_data_is_correct_CodedStep()
        {
            // Connect to pop-up window : 'http://localhost:3000/contacts/7'
            Manager.WaitForNewBrowserConnect("http://localhost:3000" + GetExtractedValue("ContactLinkUrl"), true, 5000);
            Manager.ActiveBrowser.WaitUntilReady();
            
        }
    
        [CodedStep(@"New Coded Step")]
        public void Retrieve_a_newly_created_user_and_validate_users_data_is_correct_CodedStep1()
        {
            string url = GetExtractedValue("ContactLinkUrl").ToString();
            string newUrl = "http://localhost:3000" + url;
            //SetExtractedValue("ContactLinkUrl", newUrl);
            Log.WriteLine("ContactLinkUrl: " + url + " New ContactLinkUrl: " + newUrl );
        }
    
        //[CodedStep(@"New Coded Step")]
        //public void Refresh_Page()
        //{
            
        //}
    }
}
