<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="MuaHang_Modul_Login" %>

<style type="text/css">
    .auto-style1 {
        width: 177px;
    }
    .DangNhap {
        width: 380px;
    }
</style>
<div class="Nen">
<div class="DangNhap">
<table style="width:380px;">
    <tr>
        <td colspan="2" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-weight: bold; text-align: center;">
                            Đăng nhập</td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
                            <asp:Label ID="Label1" runat="server" Text="Tài khoản "></asp:Label>
                            </td>
        <td class="auto-style1" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
                            <asp:TextBox ID="txtUserName" runat="server" style="margin-top: 9px"></asp:TextBox>
                        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
                            <asp:Label ID="Label2" runat="server" Text="Mật khẩu "></asp:Label>
                            </td>
        <td class="auto-style1" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
                            <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; text-align: center;">
                            <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng nhập" BackColor="#FAB599" BorderStyle="None" Height="30px" Width="80px" />
                        </td>
        <td class="auto-style1" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; text-align: center;">
                            <asp:Button ID="btnThoat" runat="server" OnClick="btnThoat_Click" Text="Thoát" BackColor="#FAB599" BorderStyle="None" Height="30px" Width="80px" />
                        </td>
    </tr>
    <tr>
        <td colspan="2" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
                            <asp:Label ID="Label3" runat="server" Text="Nếu bạn chưa có tài khoản vui lòng "></asp:Label>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/KhachHang/DangKy.aspx">Đăng ký </asp:HyperLink>
                        </td>
    </tr>
</table>
</div>
</div>