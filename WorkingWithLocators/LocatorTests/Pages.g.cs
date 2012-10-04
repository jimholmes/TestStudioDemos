//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocatorTests
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : http://localhost/WorkingWithLocators/ 
        /// </summary>
        public DemoPagePage DemoPage
        {
            get
            {
                return new DemoPagePage("http://localhost/WorkingWithLocators/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : D:\projects\Kendo Examples\examples\web\grid\index.html 
        /// </summary>
        public BasicUsagePage BasicUsage
        {
            get
            {
                return new BasicUsagePage("D:\\projects\\Kendo Examples\\examples\\web\\grid\\index.html", _manager.ActiveBrowser.Find);
            }
        }
        public class DemoPagePage : HtmlPage
        {
            public DemoPagePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' html:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl HtmlTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TagIndex=html:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00__1] AND [tagname 'Exact' tr]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridDataItem JayneCobbRow
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridDataItem>("id=RadGrid1_ctl00__1", "tagname=tr");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' Cobb]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridDataCell JayneCobbLNameCell
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridDataCell>("TextContent=Cobb", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00__1][tagIndex 'Exact' td:5]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridDataCell JayneCobbRowEdit
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridDataCell>("id=RadGrid1_ctl00__1", "|", "tagIndex=td:5");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl07_ctl04] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText RadGrid1Text
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=RadGrid1_ctl00_ctl07_ctl04", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl07_ctl03] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText RadGrid1Text0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=RadGrid1_ctl00_ctl07_ctl03", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl07_ctl05] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText RadGrid1Text1
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=RadGrid1_ctl00_ctl07_ctl05", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' Robin]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridDataCell RobinTableCell
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridDataCell>("TextContent=Robin", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ctl00_MainContent_PeopleGrid_ctl00] AND [tagname 'Exact' table]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.RadGrid Contacts_Table
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.RadGrid>("tagname=table", "id=ctl00_MainContent_PeopleGrid_ctl00");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ctl00_MainContent_PeopleGrid] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.RadGrid Content_Grid
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.RadGrid>("id=ctl00_MainContent_PeopleGrid", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ctl00_MainContent_PeopleGrid] AND [tagname 'Exact' div][innertext 'Contains' cobb] AND [tagname 'Exact' tr]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.RadGrid Jayne_Cobb_Row0
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.RadGrid>("tagname=div", "id=ctl00_MainContent_PeopleGrid", "|", "tagname=tr", "innertext=~cobb");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ctl00_MainContent_PeopleGrid] AND [tagname 'Exact' div] THEN UNDER NODE FIND [innertext 'Contains' cobb] AND [tagname 'Exact' tr][tagname 'Exact' a] AND [textcontent 'Exact' Edit]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.RadGrid Dynamic_Jayne_Cobb_Edit_Anchor
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.RadGrid>("tagname=div", "id=ctl00_MainContent_PeopleGrid", "|", "tagname=tr", "innertext=~cobb", "|", "tagname=a", "textcontent=Edit");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ctl00_MainContent_PeopleGrid_ctl00__2] AND [tagname 'Exact' tr]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridDataItem Dynamic_Jayne_Cobb_Row
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridDataItem>("id=ctl00_MainContent_PeopleGrid_ctl00__2", "tagname=tr");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression HtmlTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=html:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression JayneCobbRow = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00__1", "tagname=tr");
                public ArtOfTest.WebAii.Core.HtmlFindExpression JayneCobbLNameCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Cobb", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression JayneCobbRowEdit = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00__1", "|", "tagIndex=td:5");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1Text = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00_ctl07_ctl04", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1Text0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00_ctl07_ctl03", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1Text1 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00_ctl07_ctl05", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RobinTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Robin", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Contacts_Table = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=table", "id=ctl00_MainContent_PeopleGrid_ctl00");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Content_Grid = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=ctl00_MainContent_PeopleGrid", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Jayne_Cobb_Row0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=div", "id=ctl00_MainContent_PeopleGrid", "|", "tagname=tr", "innertext=~cobb");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Dynamic_Jayne_Cobb_Edit_Anchor = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=div", "id=ctl00_MainContent_PeopleGrid", "|", "tagname=tr", "innertext=~cobb", "|", "tagname=a", "textcontent=Edit");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Dynamic_Jayne_Cobb_Row = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=ctl00_MainContent_PeopleGrid_ctl00__2", "tagname=tr");
            }
        }
        public class BasicUsagePage : HtmlPage
        {
            public BasicUsagePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.KendoUI.KendoGrid Kendo_Grid
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.KendoUI.KendoGrid>("id=grid", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid][tagname 'Exact' td] AND [textcontent 'Contains' King]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.KendoUI.KendoGridDataCell Margaret_King_LName_Cell
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.KendoUI.KendoGridDataCell>("id=grid", "|", "tagname=td", "textcontent=~King");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression Kendo_Grid = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Margaret_King_LName_Cell = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "|", "tagname=td", "textcontent=~King");
            }
        }
    }
}
