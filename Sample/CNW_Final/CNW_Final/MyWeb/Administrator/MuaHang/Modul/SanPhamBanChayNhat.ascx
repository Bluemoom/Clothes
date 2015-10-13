<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamBanChayNhat.ascx.cs" Inherits="MuaHang_Modul_SanPhamBanChayNhat" %>
<div class="DanhSachSanPham">
    <div class="TieuDe">
        <h5>SẢN PHẨM BÁN CHẠY NHẤT</h5>
    </div>
    <div class="NoiDungHienThi">
        <asp:DataList ID="listproduct" runat="server" RepeatColumns="4" Width="100%" RepeatDirection="Horizontal" OnItemCommand="listproduct_ItemCommand" OnSelectedIndexChanged="listproduct_SelectedIndexChanged">
            <ItemTemplate>
                <div class="SP">
                    <div class="HinhAnhSP">
                    <asp:ImageButton CommandName="Detail" CommandArgument='<%#Eval("ID") %>' ImageUrl='<%#Eval("Images") %>' Width="100px" Height="133px" runat="server" />
                    </div>
                    <asp:Label CssClass="TenSP" Text='<%#Eval("Name") %>' runat="server"/>
                    <asp:Label CssClass="GiaSP" Text='<%#Eval(("Price"))%>' runat="server" />
                    <div class ="DatMua">
                    <asp:ImageButton CssClass="btnDatMua" CommandName="Order" CommandArgument='<%#Eval("ID") %>' ImageUrl='/Images/ThemVaoGio2.png' runat="server" />
                     </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>
