<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="UpdateAlbumsPage.aspx.cs" Inherits="KpopZtations.View.UpdateAlbumsPage1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
   <div class="container d-flex justify-content-center flex-column">
        <h1 class="text-center">Update Albums</h1>
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
            <asp:Button ID="updateBtn" runat="server" Text="Update Albums" CssClass="insert-albums-btn" OnClick="updateBtn_Click"/>
        </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
</asp:Content>
