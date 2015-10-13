<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="SanPhamTheoNhom.aspx.cs" Inherits="KhachHang1_SanPhamTheoNhom" %>
<%@ Register Src="~/MuaHang/Modul/SanPhamTheoNhom.ascx" TagName="SanPhamTheoNhom" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <UC:SanPhamTheoNhom runat="server" />
</asp:Content>

