<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PTXDPM.Customer.Home" %>
<%@ Register Src="~/UseCotrol/NewClothes.ascx" TagName="NewClothes" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <UC:NewClothes runat="server" />
</asp:Content>
