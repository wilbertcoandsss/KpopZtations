<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="InsertArtistPage.aspx.cs" Inherits="KpopZtations.View.InsertArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <link href="../Style/Home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
    <div class="container d-flex justify-content-center flex-column">
        <h1 class="text-center">Insert Artist</h1>
        <div class ="d-flex box flex-row justify-content-around">
            <h2>Artist Name: </h2>
            <asp:TextBox ID="artistNameTb" runat="server"></asp:TextBox>
        </div>
        <div class ="d-flex box flex-row justify-content-around">   
            <h2>Artist Picture: </h2>
            <asp:FileUpload ID="artistImageFile" runat="server" />
        </div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <div class ="d-flex justify-content-center">
            <asp:Button ID="submitBtn" runat="server" Text="Insert Artist" CssClass="insert-artist-btn" OnClick="submitBtn_Click"/>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
</asp:Content>
