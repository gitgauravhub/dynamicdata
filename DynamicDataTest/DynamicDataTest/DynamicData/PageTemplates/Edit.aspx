<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="Edit.aspx.cs" Inherits="DynamicDataTest.Edit" %>


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
            <h2 class="DDSubHeader">Edit entry from table <%= table.DisplayName %></h2>
        </div>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                    HeaderText="List of validation errors" CssClass="DDValidator" />
                <asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="FormView1" Display="None" CssClass="DDValidator" />

                <asp:FormView runat="server" ID="FormView1" DataSourceID="DetailsDataSource" DefaultMode="Edit"
                    OnItemCommand="FormView1_ItemCommand" OnItemUpdated="FormView1_ItemUpdated" RenderOuterTable="false">
                    <EditItemTemplate>
                        <table id="detailsTable" class="table" cellpadding="6">
                            <asp:DynamicEntity runat="server" Mode="Edit" />
                            <tr class="td">
                                <td colspan="2">
                                    <asp:LinkButton runat="server" CommandName="Update" Text="Update" />
                                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                                </td>
                            </tr>
                        </table>
                    </EditItemTemplate>
                    <EmptyDataTemplate>
                        <div class="DDNoItem">No such item.</div>
                    </EmptyDataTemplate>
                </asp:FormView>

                <asp:EntityDataSource ID="DetailsDataSource" runat="server" EnableUpdate="true" />

                <asp:QueryExtender TargetControlID="DetailsDataSource" ID="DetailsQueryExtender" runat="server">
                    <asp:DynamicRouteExpression />
                </asp:QueryExtender>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

