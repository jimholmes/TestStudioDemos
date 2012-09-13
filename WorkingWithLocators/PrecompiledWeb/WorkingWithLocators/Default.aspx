<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" %> <!-- Inherits="Default" %> -->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<telerik:RadStyleSheetManager id="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
	<telerik:RadScriptManager ID="RadScriptManager1" runat="server">
		<Scripts>
			<%--Needed for JavaScript IntelliSense in VS2010--%>
			<%--For VS2008 replace RadScriptManager with ScriptManager--%>
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
		</Scripts>
	</telerik:RadScriptManager>
	<script type="text/javascript">
		//Put your JavaScript code here.
    </script>
	<telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
	</telerik:RadAjaxManager>
	<div>

	</div>
	<telerik:RadGrid ID="RadGrid1" runat="server" AllowSorting="True" 
        CellSpacing="0" DataSourceID="Contacts" GridLines="None" PageSize="5">
        <ClientSettings>
            <Resizing AllowColumnResize="True" />
        </ClientSettings>
<MasterTableView AutoGenerateColumns="False" 
            DataSourceID="Contacts">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="Company" 
            FilterControlAltText="Filter Company column" HeaderText="Company" 
            SortExpression="Company" UniqueName="Company">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="LastName" 
            FilterControlAltText="Filter LastName column" HeaderText="LastName" 
            SortExpression="LastName" UniqueName="LastName">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FirstName" 
            FilterControlAltText="Filter FirstName column" HeaderText="FirstName" SortExpression="FirstName" 
            UniqueName="FirstName">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Region" 
            FilterControlAltText="Filter Region column" HeaderText="Region" 
            SortExpression="Region" UniqueName="Region">
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

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
	<asp:ObjectDataSource ID="Contacts" runat="server" SelectMethod="ContactList" 
        TypeName="WorkingWithLocators.Contacts"></asp:ObjectDataSource>
	</form>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
