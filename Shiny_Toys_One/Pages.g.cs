//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shiny_Toys_One
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
        /// Page : http://localhost:3000/welcome 
        /// </summary>
        public TelerikCustomerRelationsPage TelerikCustomerRelations
        {
            get
            {
                return new TelerikCustomerRelationsPage("http://localhost:3000/welcome", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://localhost:3000/contacts 
        /// </summary>
        public TelerikCustomerRelations0Page TelerikCustomerRelations0
        {
            get
            {
                return new TelerikCustomerRelations0Page("http://localhost:3000/contacts", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://localhost:3000/contacts/new 
        /// </summary>
        public TelerikCustomerRelations1Page TelerikCustomerRelations1
        {
            get
            {
                return new TelerikCustomerRelations1Page("http://localhost:3000/contacts/new", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://localhost:3000/contacts/30/edit 
        /// </summary>
        public TelerikCustomerRelations2Page TelerikCustomerRelations2
        {
            get
            {
                return new TelerikCustomerRelations2Page("http://localhost:3000/contacts/30/edit", _manager.ActiveBrowser.Find);
            }
        }
        public class TelerikCustomerRelationsPage : HtmlPage
        {
            public TelerikCustomerRelationsPage(string url, Find find) : 
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
            /// (Html): [id 'Exact' login_link] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor LoginLinkLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=login_link", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' username] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText UsernameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=username", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' password] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword PasswordPassword
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("id=password", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' login_button] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit LoginButtonSubmit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("id=login_button", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression LoginLinkLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=login_link", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression UsernameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=username", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswordPassword = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=password", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LoginButtonSubmit = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=login_button", "tagname=input");
            }
        }
        public class TelerikCustomerRelations0Page : HtmlPage
        {
            public TelerikCustomerRelations0Page(string url, Find find) : 
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
            /// (Html): [href 'Exact' /contacts/new] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor NewContactLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("href=/contacts/new", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' New]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell NewTableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("tagname=td", "TextContent=New");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' User]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell UserTableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("TextContent=User", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'StartsWith' new.user@foo.co]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell NewUserFooTableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("TextContent=^new.user@foo.co", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'StartsWith' http://linkedin]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell HttpLinkedinTableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("TextContent=^http://linkedin", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [InnerText 'StartsWith' NewUser][alt 'Exact' Neutral]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage New_User_Lead_Type
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("InnerText=^NewUser", "|", "alt=Neutral");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' content] THEN UNDER NODE FIND [InnerText 'StartsWith' New][TextContent 'Exact' View Contact]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor ViewContactLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=content", "|", "InnerText=^New", "|", "TextContent=View Contact");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression NewContactLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("href=/contacts/new", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression NewTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=td", "TextContent=New");
                public ArtOfTest.WebAii.Core.HtmlFindExpression UserTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=User", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression NewUserFooTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^new.user@foo.co", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression HttpLinkedinTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^http://linkedin", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression New_User_Lead_Type = new ArtOfTest.WebAii.Core.HtmlFindExpression("InnerText=^NewUser", "|", "alt=Neutral");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ViewContactLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=content", "|", "InnerText=^New", "|", "TextContent=View Contact");
            }
        }
        public class TelerikCustomerRelations1Page : HtmlPage
        {
            public TelerikCustomerRelations1Page(string url, Find find) : 
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
            /// (Html): [id 'Exact' contact_first_name] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContactFirstNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=contact_first_name", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_last_name] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContactLastNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=contact_last_name", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_linkedin_profile] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContactLinkedinProfileText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=contact_linkedin_profile", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_govt_contract] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox ContactGovtContractCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=contact_govt_contract", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_dod] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox ContactDodCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=contact_dod", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_other] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox ContactOtherCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=contact_other", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [src 'Exact' /assets/NEUTRAL.png] AND [tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage Neutral_Lead_Image
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("tagname=img", "src=/assets/NEUTRAL.png");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' new_contact][tagIndex 'Exact' div:9]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv Lead_Type_Drop_Target
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=new_contact", "|", "tagIndex=div:9");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' commit] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit CommitSubmit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("name=commit", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactFirstNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_first_name", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactLastNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_last_name", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactLinkedinProfileText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_linkedin_profile", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactGovtContractCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_govt_contract", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactDodCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_dod", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactOtherCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_other", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Neutral_Lead_Image = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=img", "src=/assets/NEUTRAL.png");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Lead_Type_Drop_Target = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=new_contact", "|", "tagIndex=div:9");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CommitSubmit = new ArtOfTest.WebAii.Core.HtmlFindExpression("name=commit", "tagname=input");
            }
        }
        public class TelerikCustomerRelations2Page : HtmlPage
        {
            public TelerikCustomerRelations2Page(string url, Find find) : 
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
            /// (Html): [id 'Exact' contact_email] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputEmail ContactEmailEmail
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputEmail>("id=contact_email", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_first_name] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContactFirstNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=contact_first_name", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_last_name] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContactLastNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=contact_last_name", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' contact_linkedin_profile] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText ContactLinkedinProfileText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=contact_linkedin_profile", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'StartsWith' edit_contact][tagIndex 'Exact' img:3]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage LeadTypeImage0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=^edit_contact", "|", "tagIndex=img:3");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactEmailEmail = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_email", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactFirstNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_first_name", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactLastNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_last_name", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ContactLinkedinProfileText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=contact_linkedin_profile", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LeadTypeImage0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=^edit_contact", "|", "tagIndex=img:3");
            }
        }
    }
}
