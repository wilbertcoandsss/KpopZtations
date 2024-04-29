<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KpopZtations.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="LoginForm" ContentPlaceHolderID="AuthForm" runat="server">
    <h1>KpopZtation</h1>
    <h2>Welcome Back!</h2>
    <label>Login to continue</label>

    <div>
        <div><label>Email</label></div>
        <div><asp:TextBox ID="tbEmail" runat="server"></asp:TextBox></div>
    </div>

    <div>
        <div><label>Password</label></div>
        <div><asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox></div>
    </div>

    <div><asp:Label ID="lbError" ForeColor="Red" runat ="server" Text=""></asp:Label></div>

    <div>
        <asp:CheckBox ID="cbRemember" runat="server" />
        <asp:Label ID="lbRemember" runat="server" Text="Remember Me"></asp:Label>
    </div>

    <div><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/></div>
    
    <div>
        <asp:Label ID="lbRegister" runat="server" Text="Don't have an account? "></asp:Label>
        <a href="register.aspx">Register</a>
    </div>


</asp:Content>
