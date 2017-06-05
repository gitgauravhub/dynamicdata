<%@ Control Language="C#" CodeBehind="Enumeration.ascx.cs" Inherits="DynamicDataTest.EnumerationFilter" %>

<%--<asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" CssClass="DDFilter"--%>
<asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" CssClass="form-control input-sm" Width="200"
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
  <asp:ListItem Text="All" Value="" />
</asp:DropDownList>

