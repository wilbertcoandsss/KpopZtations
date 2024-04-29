<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="ArtistsDetailsPage.aspx.cs" Inherits="KpopZtations.View.ArtistsDetailsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="../Style/Home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AuthForm" runat="server">
    <h1>Artist Details Page</h1>
    <h1>
        Artist Name: <asp:Label ID="artistNameLbl" runat="server" Text="Label"></asp:Label></h1>
    <h1>You can see their discography on the album!</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
        <h1 class="fw-bold text-center mt-4">Our Artist</h1>
        <div class ="d-flex justify-content-center fw-bold mt-4 mb-5">
            <asp:Button ID="insertAlbum" runat="server" Text="Insert Album" CssClass="insert-album-btn" OnClick="insertAlbum_Click" Visible="<%#ShowElementByAdmin() %>" />
        </div>
        <div class="container d-flex justify-content-around flex-row align-items-center flex-wrap">
            <asp:Repeater runat="server" ID="albumRepeater">
                <ItemTemplate>
                        <div class ="box d-flex justify-content-around align-items-center flex-column mt-4 mb-4">
                            <a href ="/View/AlbumDetailsPage.aspx?id=<%# Eval("AlbumID")%>" class="albums-card">
                            <h2 class="mt-3 mb-3"><%# Eval("AlbumName") %></h2>
                            <img src="../Storage/Albums/<%# Eval("AlbumImage") %>" alt="Albums Image" width="180px" height="180px" style="border-radius: 7px; margin-top:18px; margin-bottom: 15px;"/>
                            <h4 class="mt-3 mb-3"><%# Eval("AlbumDescription") %></h4>
                            <h2 class="mt-3 mb-3">Rp. <%# Eval("AlbumPrice") %></h2>
                            </a>
                            <br />
                            <br />
                           <a href="/View/UpdateAlbumsPage.aspx?id=<%# Eval("AlbumID") %>" class="update-artist-btn text-center" <%# ShowElementByAdmin() ? "" : "style='display: none;'" %>>Update Album</a>
                           <a href="/View/DeleteAlbumsPage.aspx?id=<%# Eval("AlbumID") %>" class="delete-artist-btn text-center" <%# ShowElementByAdmin() ? "" : "style='display: none;'" %>>Delete Album</a>
                        </div>    
                     </a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
</asp:Content>
