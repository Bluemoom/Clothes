<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamMoi.ascx.cs" Inherits="MuaHang_Modul_SanPhamMoi" %>
<div class=" list-Banner1">
    <div class="header-Banner1">
        <h5>SẢN PHẨM MỚI</h5>
    </div>
    <div class="content-Banner1">
        <asp:DataList ID="listproduct" runat="server" RepeatColumns="3" Width="100%" RepeatDirection="Horizontal" OnItemCommand="listproduct_ItemCommand" OnSelectedIndexChanged="listproduct_SelectedIndexChanged">
            <ItemTemplate>
                <div class="Productnew">
                    <div class="imgProductnew">
                    <asp:Image ImageUrl='<%#Eval("URL") %>' Width="250px" Height="150px" runat="server" />
                    <%--</div>
                    <asp:Label CssClass="NameProduct" Text='<%#Eval("Name") %>' runat="server"/>
                    <asp:Label CssClass="PriceProduct" Text='<%#Eval("Price").ToString()+" VNĐ" %>' runat="server" />
                    <div class ="DatMua">
                    <asp:ImageButton CssClass="btnDatMua" CommandName="Order" CommandArgument='<%#Eval("ID") %>' ImageUrl='/Images/Order.png' runat="server" />
                     </div>--%>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>
