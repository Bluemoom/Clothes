<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="TrangChu.aspx.cs" Inherits="KhachHang1_KhachHang" %>
<%@ Register Src="~/MuaHang/Modul/SanPhamBanChayNhat.ascx" TagName="SanPhamBanChayNhat" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <UC:SanPhamBanChayNhat runat="server" />
</asp:Content>

