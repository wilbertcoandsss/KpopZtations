<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="AlbumDetailsPage.aspx.cs" Inherits="KpopZtations.View.AlbumDetailsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="../Style/Home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
   
    <div class ="d-flex justify-content-around flex-row">
        <div>                   
            <img src="../Storage/Albums/<%= CurrentAlbum.AlbumImage %>" alt="Album Image" width="180px" height="180px" style="border-radius: 7px; margin-top:18px; margin-bottom: 15px;" />
        </div>
        <div class="d-flex justify-content-around align-items-center flex-column details">
            <h2>Album Name: <%= CurrentAlbum.AlbumName %></h2>
            <h2>Album Description: <%= CurrentAlbum.AlbumDescription %></h2>
            <h2>Album Price: <%= CurrentAlbum.AlbumPrice %></h2>
            <h2>Album Stock: <%= CurrentAlbum.AlbumStock %></h2>
        </div>
    </div>

    <div class="d-flex justify-content-center align-items-center flex-row" >
        <div class="d-flex flex-column align-items-center">
            <asp:Label runat="server" ID="qtyLbl" Visible="<%# ShowElementByCustomer() %>">Quantity</asp:Label>
            <asp:TextBox ID="qtyTb" runat="server"  Visible="<%# ShowElementByCustomer() %>" ></asp:TextBox>
        </div>
        <asp:Button ID="addToCartBtn" runat="server" Text="Add To Cart" CssClass="insert-artist-btn" OnClick="addToCartBtn_Click" Visible="<%# ShowElementByCustomer() %>"/>
    </div>
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
</asp:Content>
