<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangKy.ascx.cs" Inherits="MuaHang_Modul_DangKy" %>

<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    .DangNhap {
        width: 411px;
    }
    .auto-style2 {
        width: 296px;
    }
    .auto-style3 {
        height: 23px;
        width: 296px;
    }
    .auto-style4 {
        height: 26px;
    }
    .auto-style5 {
        width: 296px;
        height: 26px;
    }
    .auto-style6 {
        height: 19px;
    }
    .auto-style7 {
        width: 296px;
        height: 19px;
    }
</style>
<div class="Nen">
<div class="DangNhap">
<table>
    <tr>
        <td colspan="2" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
            <asp:Label ID="lbThongBao" runat="server" Text="Label"></asp:Label>
            <asp:HyperLink ID="hlVeTrangChu" runat="server" NavigateUrl="~/KhachHang/TrangChu.aspx">Về trang chủ</asp:HyperLink>
            <asp:HyperLink ID="hlDangNhap" runat="server" NavigateUrl="~/KhachHang/Login.aspx">Đăng nhập</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center; font-weight: bold; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">Đăng ký</td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Tên đăng nhập</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; " class="auto-style2">
            <asp:TextBox ID="txtName" runat="server" Width="143px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Mật khẩu</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; " class="auto-style2">
            <asp:TextBox ID="txtMatKhau" runat="server" Width="141px" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Ngày sinh </td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; " class="auto-style2">
            <asp:TextBox ID="txtNgaySinh" runat="server" Width="138px">yy/dd/mm</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Tỉnh thành</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; " class="auto-style5">
            <asp:TextBox ID="txtTinhThanh" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Địa chỉ</td>
        <td class="auto-style3" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">
            <asp:TextBox ID="txtDiaChi" runat="server" Height="75px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Số điện thoại</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; " class="auto-style2">
            <asp:TextBox ID="txtSoDienThoai" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; ">Email</td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; " class="auto-style2">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="text-align: center">
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;" class="auto-style6">
            <asp:Button ID="Button1" runat="server" BackColor="#FAB599" BorderStyle="None" OnClick="Button1_Click" Text="Đăng ký" Height="30px" Width="80px" />
        </td>
        <td style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;" class="auto-style7">
            <asp:Button ID="Button2" runat="server" BackColor="#FAB599" BorderStyle="None" Text="Thoát" Height="30px" Width="80px" />
        </td>
    </tr>
</table>
</div>
</div>