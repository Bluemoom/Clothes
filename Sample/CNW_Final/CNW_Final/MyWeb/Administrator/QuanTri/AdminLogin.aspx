<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTri/Administrator.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="QuanTri_AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    #form1 {
        width: 323px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <table style="border: 1px solid #c6c6c6; width: 98%;">
        <tr>
            <td colspan="2" style="border: 1px solid #c6c6c6; font-weight: bold; text-align: center; background-color: #f6f6f6;">Đăng Nhập</td>
        </tr>
        <tr>
            <td>Tên đăng nhập</td>
            <td>
                <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mật khẩu </td>
            <td>
                <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Button ID="btnDangNhap" runat="server" BackColor="#F6F6F6" BorderColor="#F6F6F6" BorderStyle="None" OnClick="btnDangNhap_Click" Text="Đăng nhập" />
            </td>
            <td style="text-align: center">
                <asp:Button ID="btnThoat" runat="server" BackColor="#F6F6F6" BorderColor="#F6F6F6" BorderStyle="None" Text="Thoát" />
            </td>
        </tr>
    </table>
</form>
</asp:Content>

