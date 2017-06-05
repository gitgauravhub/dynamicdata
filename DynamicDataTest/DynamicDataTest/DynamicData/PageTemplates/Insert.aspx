﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="Insert.aspx.cs" Inherits="DynamicDataTest.Insert" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="FormView1" />
        </DataControls>
    </asp:DynamicDataManager>

   
    <div class="panel panel-default">
        <div class="panel-heading"> <h2 class="DDSubHeader">Add new entry to table <%= table.DisplayName %></h2> </div>
        </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
            
                <div class="container">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                            HeaderText="List of validation errors" CssClass="DDValidator" />
                        <asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="FormView1" Display="None" CssClass="DDValidator" />

                        <asp:FormView runat="server" ID="FormView1" DataSourceID="DetailsDataSource" DefaultMode="Insert"
                            OnItemCommand="FormView1_ItemCommand" OnItemInserted="FormView1_ItemInserted" RenderOuterTable="false">
                            <InsertItemTemplate>
                                <table id="detailsTable" class="table" cellpadding="6">
                                    <asp:DynamicEntity runat="server" Mode="Insert" />
                                    <tr class="td">
                                        <td colspan="2">
                                            <asp:LinkButton runat="server" CommandName="Insert" Text="Insert" />
                                            <asp:LinkButton runat="server" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                                        </td>
                                    </tr>
                                </table>
                            </InsertItemTemplate>
                        </asp:FormView>

                        <asp:EntityDataSource ID="DetailsDataSource" runat="server" EnableInsert="true" />
                   </div>
                
        </ContentTemplate>

    </asp:UpdatePanel>

</asp:Content>
