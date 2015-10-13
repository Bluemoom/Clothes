<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GroupProduct.ascx.cs" Inherits="MuaHang_Modul_GroupProduct" %>
 
<div class=" content-Modul">
    <ul>
        <asp:Repeater ID="rptGroupProduct" runat="server" OnItemCommand="rptGroupProduct_ItemCommand">
            <ItemTemplate>
                <li style="list-style:none"><a href="SanPhamTheoNhom.aspx?IDNHOM=<%#Eval("ID").ToString() %>" ><%#Eval("Name") %></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</div>
