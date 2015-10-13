<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="DoiMatKhau.aspx.cs" Inherits="KhachHang_DoiMatKhau" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style3 {
        height: 22px;
    }
    .auto-style4 {
        height: 28px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="Nen">
    <div class="DangNhap">
    <table style="width: 100%; padding-top: auto;">
    <tr>
        <td colspan="2" style="font-weight: bold; text-align: center; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">Đổi mật khẩu&nbsp;</td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">Mật khẩu hiện tại</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
            <asp:TextBox ID="txtMatKhauCu" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">Mật khẩu mới</td>
        <td class="auto-style3" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
            <asp:TextBox ID="txtMatKhauMoi1" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">Nhập lại mật khẩu mới</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
            <asp:TextBox ID="txtMatKhauMoi2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align: center; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;" class="auto-style4">
            <asp:Button ID="Button1" runat="server" Text="Tiếp tục" OnClick="Button1_Click" BackColor="#FAB599" BorderStyle="None" Height="30px" Width="80px" />
        </td>
        <td style="text-align: center; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;" class="auto-style4">
            <asp:Button ID="Button2" runat="server" Text="Thoát" BackColor="#FAB599" BorderStyle="None" Height="30px" Width="80px" />
        </td>
    </tr>
</table>
</div>
</div>
</asp:Content>
