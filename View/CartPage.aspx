<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtations.View.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Style/Cart.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
    <h1>See your cart page below!</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="test">
        <br>
        <h1 class="text-center">My Cart</h1>
        <table style="border-collapse: collapse">
            <thead>
                <tr>
                    <th>Album Cover</th>
                    <th>Album Name</th>
                    <th>Album Qty</th>
                    <th>Album Price</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var cart in carts)          
                    {%>
                <tr>
                    <td>
                        <img class="book-pic-icon" src="../Storage/Albums/<%= cart.Album.AlbumImage%>" alt="Album Image" width="180px" height="180px" style="border-radius: 7px; margin-top: 18px; margin-bottom: 15px;">
                    </td>
                    <td><%= cart.Album.AlbumName %></td>
                    <td><%= cart.Qty %></td>
                    <td><%= cart.Album.AlbumPrice %></td>
                    <td>
                        <div class="remove-cart">
                            <a href ="RemoveCartItems.aspx?id=<%= cart.AlbumID %>">Remove Album</a>
                        </div>
                    </td>
                </tr>
                <%} %>
            </tbody>
        </table>
        <div>
            <asp:Label ID="lblError" Text="" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Button ID="checkOutBtn" runat="server" OnClick="checkOutBtn_Click" Text="Checkout" />
        </div>
    </div>
</asp:Content>
