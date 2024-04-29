<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="KpopZtations.View.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="../Style/Cart.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
        <div class="test">
        <br>
        <h1 class="text-center">Transaction History</h1>
        <table style="border-collapse: collapse">
            <thead>
                <tr>
                    <th>Transaction ID</th>
                    <th>Transacttion Date</th>
                    <th>Customer Name</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var th in trheader)
                    {%>
                <tr>
                    <td><%= th.TransactionID%></td>
                    <td><%= th.TransactionDate %></td>
                    <td><%= th.Customer.CustomerName%></td>
                    <td>
                        <div class="remove-cart">
                            <a href="TransactionDetailPage.aspx?id=<%= th.TransactionID %>">Details</a>
                        </div>
                    </td>
                </tr>
                <%} %>
            </tbody>
        </table>
    </div>
</asp:Content>
