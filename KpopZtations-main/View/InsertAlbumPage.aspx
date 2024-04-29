<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="InsertAlbumPage.aspx.cs" Inherits="KpopZtations.View.InsertAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link href="../Style/Home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
    <div class="container d-flex justify-content-center flex-column">
        <h1 class="text-center">Insert Albums</h1>
        <div class ="d-flex box flex-row justify-content-around">
            <h2>Albums Name: </h2>
            <asp:TextBox ID="albumsNameTb" runat="server"></asp:TextBox>
        </div>     
        <div class ="d-flex box flex-row justify-content-around">
            <h2>Albums Description: </h2>
            <asp:TextBox ID="albumsDescriptionTb" runat="server"></asp:TextBox>
        </div>       
        <div class ="d-flex box flex-row justify-content-around">
            <h2>Albums Price: </h2>
            <asp:TextBox ID="albumsPriceTb" runat="server"></asp:TextBox>
        </div>       
        <div class ="d-flex box flex-row justify-content-around">
            <h2>Albums Stock: </h2>
            <asp:TextBox ID="albumsStockTb" runat="server"></asp:TextBox>
        </div>
        <div class ="d-flex box flex-row justify-content-around">   
            <h2>Artist Picture: </h2>
            <asp:FileUpload ID="albums" runat="server" />
        </div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <div class ="d-flex justify-content-center">
            <asp:Button ID="submitBtn" runat="server" Text="Insert Albums" CssClass="insert-albums-btn" OnClick="submitBtn_Click"/>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
</asp:Content>
