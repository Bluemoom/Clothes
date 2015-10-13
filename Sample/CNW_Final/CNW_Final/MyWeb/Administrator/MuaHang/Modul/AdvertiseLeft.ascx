<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvertiseLeft.ascx.cs" Inherits="MuaHang_Modul_AdvertiseLeft" %>
<div class ="content-module">
    <asp:Repeater ID="rptAdvertiseLeft" runat="server">
        <HeaderTemplate>
            <marquee direction="up" scrolldelay="100" scrollamount="2" onmouseover="this.stop()" onmouseout="this.start()">           
        </HeaderTemplate>
        <ItemTemplate>
            <a class=""advertiseLink" href='<%#Eval("Link") %>' target='<%#Eval("Tagert") %>'>
                <asp:Image width=180px Height='<%#Unit.Pixel(int.Parse(Eval("Height").ToString())) %>' ImageUrl='<%#Eval("url") %>' runat="server" /></image></a>
        </ItemTemplate>
        <FooterTemplate></marquee></FooterTemplate>
    </asp:Repeater>
</div>
