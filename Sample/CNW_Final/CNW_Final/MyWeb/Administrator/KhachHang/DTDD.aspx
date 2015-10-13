<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="DTDD.aspx.cs" Inherits="KhachHang1_DTDD" %>
<%@ Register Src="~/MuaHang/Modul/ChiTietHangHoa.ascx" TagName="ChiTietSanPham" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <UC:ChiTietSanPham runat="server" />
</asp:Content>

