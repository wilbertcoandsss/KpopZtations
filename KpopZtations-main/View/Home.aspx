<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZtations.View.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/Home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
    <div class="d-flex justify-content-center align-items-center flex-column">
        <h1>Welcome to KpopZtation!</h1>
        <h1>Home for every Kpopers!</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <h1 class="fw-bold text-center mt-4">Our Artist</h1>
    <div class ="d-flex justify-content-center fw-bold mt-4 mb-5">
        <asp:Button ID="insertArtist" runat="server" Text="Insert Artist" CssClass="insert-artist-btn" OnClick="insertArtist_Click" Visible="<%#ShowElementByAdmin() %>"/>
    </div>
<div class="container d-flex justify-content-around flex-row align-items-center flex-wrap">
    <asp:Repeater runat="server" ID="artistRepeater">
        <ItemTemplate>
            <div class="box d-flex justify-content-around align-items-center flex-column mt-4 mb-4 artist-card">
                <a href="/View/ArtistsDetailsPage.aspx?id=<%# Eval("ArtistID") %>">
                    <h2 class="mt-3 mb-3"><%# Eval("ArtistName") %></h2>
                    <img src="../Storage/Artists/<%# Eval("ArtistImage") %>" alt="Artist Image" width="180px" height="180px" style="border-radius: 7px; margin-top:18px; margin-bottom: 15px;" />
                </a>
                <br />
                <br />
               <a href="/View/UpdateArtistPage.aspx?id=<%# Eval("ArtistID") %>" class="update-artist-btn text-center" <%# ShowElementByAdmin() ? "" : "style='display: none;'" %>>Update Artist</a>
               <a href="/View/DeleteArtistPage.aspx?id=<%# Eval("ArtistID") %>" class="delete-artist-btn text-center" <%# ShowElementByAdmin() ? "" : "style='display: none;'" %>>Delete Artist</a>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>

</asp:Content>
