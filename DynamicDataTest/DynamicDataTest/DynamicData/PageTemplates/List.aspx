<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="List.aspx.cs" Inherits="DynamicDataTest.List" %>

<%@ Register Src="~/DynamicData/Content/GridViewPager.ascx" TagName="GridViewPager" TagPrefix="asp" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="panel panel-default">
        <div class="panel-heading"><%= table.DisplayName%> </div>
        <div class="panel-body">

            <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
                <DataControls>
                    <asp:DataControlReference ControlID="GridView1" />
                </DataControls>
            </asp:DynamicDataManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <div class="panel panel-default">
                        <div class="container">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                                HeaderText="List of validation errors" CssClass="DDValidator" />
                            <asp:DynamicValidator runat="server" ID="GridViewValidator" ControlToValidate="GridView1" Display="None" CssClass="DDValidator" />

                            <asp:QueryableFilterRepeater runat="server" ID="FilterRepeater">
                                <ItemTemplate>
                                    <div class="col-sm-3">
                                        <asp:Label runat="server" Text='<%# Eval("DisplayName") %>' OnPreRender="Label_PreRender" />
                                        <asp:DynamicFilter runat="server" ID="DynamicFilter" OnFilterChanged="DynamicFilter_FilterChanged" />
                                        <br />
                                    </div>
                                </ItemTemplate>
                            </asp:QueryableFilterRepeater>
                            <br />
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-12">
                            <div class="table-responsive">
                                <asp:GridView ID="GridView1" runat="server" DataSourceID="GridDataSource" EnablePersistedSelection="true"
                                    AllowPaging="True" AllowSorting="True" CssClass="table table-striped table-bordered table-hover datatable"
                                    CellPadding="6">
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:DynamicHyperLink runat="server" Action="Edit" Text="Edit" />&nbsp;<asp:LinkButton runat="server" CommandName="Delete" Text="Delete"
                                                    OnClientClick='return confirm("Are you sure you want to delete this item?");' />&nbsp;<asp:DynamicHyperLink runat="server" Text="Details" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>

                                    <PagerStyle CssClass="DDFooter" />
                                    <PagerTemplate>
                                        <asp:GridViewPager runat="server" />
                                    </PagerTemplate>
                                    <EmptyDataTemplate>
                                        There are currently no items in this table.
                                    </EmptyDataTemplate>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <asp:EntityDataSource ID="GridDataSource" runat="server" EnableDelete="true" />

                    <asp:QueryExtender TargetControlID="GridDataSource" ID="GridQueryExtender" runat="server">
                        <asp:DynamicFilterExpression ControlID="FilterRepeater" />
                    </asp:QueryExtender>

                    <br />

                    <div >
                        <asp:DynamicHyperLink ID="InsertHyperLink" runat="server" Action="Insert" CssClass="btn btn-default"><img runat="server" src="~/DynamicData/Content/Images/plus.gif" alt="Insert new item" />Insert new item</asp:DynamicHyperLink>
                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>

