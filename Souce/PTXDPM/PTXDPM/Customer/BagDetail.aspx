<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="BagDetail.aspx.cs" Inherits="PTXDPM.Customer.Bag" %>

<%@ Register Src="~/UseCotrol/BagDetail.ascx" TagPrefix="uc1" TagName="BagDetail" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:BagDetail runat="server" id="BagDetail" />
</asp:Content>
