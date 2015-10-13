<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Admins_Login" %>


<form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
&nbsp;<p>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassWord" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng nhập" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnThoat" runat="server" Text="Thoát" />
</form>



