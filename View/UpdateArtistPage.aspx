<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="UpdateArtistPage.aspx.cs" Inherits="KpopZtations.View.UpdateArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
    <div class="container d-flex justify-content-center flex-column">
        <h1 class="text-center">Update Artist</h1>
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
            <asp:Button ID="updateBtn" runat="server" Text="Update Artist" CssClass="insert-artist-btn" OnClick="updateBtn_Click"/>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
</asp:Content>
