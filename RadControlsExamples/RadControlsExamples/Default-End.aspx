<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="RadControlsExamples._Default" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h2>
    <telerik:RadGrid ID="PeopleGrid" runat="server" CellSpacing="0" 
    DataSourceID="ContactsDataSource" GridLines="None">
<MasterTableView autogeneratecolumns="False" datasourceid="ContactsDataSource">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
 
        
         
                   
     
        <telerik:GridBoundColumn DataField="Region" 
            FilterControlAltText="Filter Region column" HeaderText="Region" 
            SortExpression="Region" UniqueName="Region">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Company" 
            FilterControlAltText="Filter Company column" HeaderText="Company" 
            SortExpression="Company" UniqueName="Company">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="LastName" 
            FilterControlAltText="Filter LastName column" HeaderText="LastName" 
            SortExpression="LastName" UniqueName="LastName">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FirstName" 
            FilterControlAltText="Filter FirstName column" HeaderText="FirstName" 
            SortExpression="FirstName" UniqueName="FirstName">
        </telerik:GridBoundColumn>
                  
  <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" 
            FilterControlAltText="Filter Id column" HeaderText="Id" SortExpression="Id" 
            UniqueName="Id">
        </telerik:GridBoundColumn>        
        <telerik:GridEditCommandColumn FilterControlAltText="Filter EditCommandColumn column">
        </telerik:GridEditCommandColumn>    
       
 
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</HeaderContextMenu>
</telerik:RadGrid>
<asp:ObjectDataSource ID="ContactsDataSource" runat="server" 
    SelectMethod="ContactList" TypeName="RadControlsExamples.Contacts">
</asp:ObjectDataSource>
</asp:Content>
