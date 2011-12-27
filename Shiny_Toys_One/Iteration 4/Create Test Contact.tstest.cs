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
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using Telerik.WebAii.Controls.Xaml.Wpf;

namespace Shiny_Toys_One.Iteration_4
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
	//		// Custom code goes here
	//      ActiveBrowser.NavigateTo("http://www.google.com");
	//
	//		// Or
	//		ActiveBrowser.NavigateTo(Data["url"]);
	// }
	//
		

    public class Create_Test_Contact : BaseWebAiiTest
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

        [CodedStep(@"@\New Coded Step")]
        public void Create_Test_Contact_CodedStep()
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"d:\temp\sqlite3.exe";
            proc.StartInfo.Arguments = "development.sqlite3 \"delete from contacts"+
                "where email like '%foo.com';insert into contacts "+
                "(first_name, last_name,email, linkedin_profile, lead_type) "+
                "values "+
                "('New', 'User', 'new.user@foo.com', 'http://linkedin.com/newuser','NEUTRAL');"+
                "\"";
            proc.StartInfo.WorkingDirectory = @"D:\projects\Telerik-Demo\db";
            proc.Start();
            proc.WaitForExit();
        }

    }
}
