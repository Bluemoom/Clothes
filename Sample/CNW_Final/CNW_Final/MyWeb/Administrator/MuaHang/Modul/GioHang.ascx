<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioHang.ascx.cs" Inherits="MuaHang_Modul_GioHang" %>
<style type="text/css">
    .auto-style1 {
        width: 365px;
    }
</style>
<div class="hRight" />
<table style="width:62%;">
    <tr>
        <td class="auto-style1" style="background-color: #f6f6f6">
        <asp:Label ID="lbNguoiDung" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
        <asp:Button ID="btnDangXuat" runat="server" Text="Đăng nhập" OnClick="btnDangXuat_Click" BackColor="#F6F6F6" BorderStyle="Solid" BorderColor="#C6CCCC" BorderWidth="1px" />
            <asp:Button ID="Button2" runat="server" Text="Đổi mật khẩu" BackColor="#F6F6F6" BorderStyle="Solid" BorderColor="#C6CCCC" BorderWidth="1px" OnClick="Button2_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
        <asp:Button ID="Button1" CssClass="btnBAG" runat="server" Text="Shopping Bag" OnClick="Button1_Click" />
        <asp:TextBox CssClass="txtTotal" ID="txtTotalMoney" runat="server" Width="16px"></asp:TextBox>
        </td>
    </tr>
</table>
</div>

