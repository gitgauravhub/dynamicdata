<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="Details.aspx.cs" Inherits="DynamicDataTest.Details" %>


<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="FormView1" />
        </DataControls>
    </asp:DynamicDataManager>
    <div class="panel panel-default">
        <div class="panel-heading">
            <h2 class="DDSubHeader">Entry from table <%= table.DisplayName %></h2>
        </div>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                    HeaderText="List of validation errors" CssClass="DDValidator" />
                <asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="FormView1" Display="None" CssClass="DDValidator" />

                <asp:FormView runat="server" ID="FormView1" DataSourceID="DetailsDataSource" OnItemDeleted="FormView1_ItemDeleted" RenderOuterTable="false">
                    <ItemTemplate>
                        <table id="detailsTable" class="table" cellpadding="6">
                            <asp:DynamicEntity runat="server" />
                            <tr class="td">
                                <td colspan="2">
                                    <asp:DynamicHyperLink runat="server" Action="Edit" Text="Edit" />
                                    <asp:LinkButton runat="server" CommandName="Delete" Text="Delete"
                                        OnClientClick='return confirm("Are you sure you want to delete this item?");' />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <div class="DDNoItem">No such item.</div>
                    </EmptyDataTemplate>
                </asp:FormView>

                <asp:EntityDataSource ID="DetailsDataSource" runat="server" EnableDelete="true" />

                <asp:QueryExtender TargetControlID="DetailsDataSource" ID="DetailsQueryExtender" runat="server">
                    <asp:DynamicRouteExpression />
                </asp:QueryExtender>

                <br />

                <div>
                    <asp:DynamicHyperLink ID="ListHyperLink" runat="server" CssClass="btn btn-default" Action="List">Show all items</asp:DynamicHyperLink>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

