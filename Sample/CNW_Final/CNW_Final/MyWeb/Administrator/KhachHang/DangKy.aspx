<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="DangKy.aspx.cs" Inherits="KhachHang_DangKy" %>
<%@ Register Src="~/MuaHang/Modul/DangKy.ascx" TagName="DangKy" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <UC:DangKy runat="server" />
</asp:Content>

