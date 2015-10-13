<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="LoiDatHang.aspx.cs" Inherits="KhachHang_LoiDatHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
    Bạn phải đăng nhập để có thể đặt hàng</p>
<p>
    Nếu đã có tài khoảng vui lòng
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/KhachHang/Login.aspx">Đăng nhập</asp:HyperLink>
</p>
<p>
    Nếu chưa có tài khoảng vui lòng
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/KhachHang/DangKy.aspx">Đăng ký</asp:HyperLink>
</p>

</asp:Content>

