<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Authentication.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="KpopZtations.View.Master.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="RegisterForm" ContentPlaceHolderID="AuthForm" runat="server">

    <h1>KpopZtation</h1>
    <h2>Hello!</h2>
    <label>Create a new account</label>

    <div>
        <div><label>Name</label></div>
        <div><asp:TextBox ID="tbName" runat="server"></asp:TextBox></div>
    </div>

    <div>
        <div><label>Email</label></div>
        <div><asp:TextBox ID="tbEmail" runat="server"></asp:TextBox></div>
    </div>

    <div>
        <div><label>Gender</label></div>
        <div>
                <asp:RadioButton ID="rbMale" runat="server" GroupName="radioGender"/>
                <asp:Label ID="lbMale" runat="server" Text="Male"></asp:Label>

                <asp:RadioButton ID="rbFemale" runat="server" GroupName="radioGender"/>
                <asp:Label ID="lbFemale" runat="server" Text="Female"></asp:Label>
        </div>
    </div>

    <div>
        <div><label>Address</label></div>
        <div><asp:TextBox ID="tbAddress" runat="server"></asp:TextBox></div>
    </div>

    <div>
        <div><label>Password</label></div>
        <div><asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox></div>
    </div>

    <div><asp:Label ID="lbError" ForeColor="Red"  runat ="server" Text=""></asp:Label></div>

    <div><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/></div>
    
    <div>
        <asp:Label ID="lbRegister" runat="server" Text="Have an account? "></asp:Label>
        <a href="login.aspx">Login</a>
    </div>
    
</asp:Content>
