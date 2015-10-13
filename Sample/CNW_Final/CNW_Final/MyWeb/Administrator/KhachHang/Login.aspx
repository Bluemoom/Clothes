<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="KhachHang1_Login" %>
<%@ Register Src="~/MuaHang/Modul/Login.ascx" TagName="Login" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <UC:Login runat="server" />
</asp:Content>

