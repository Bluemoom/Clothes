<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChiTietHangHoa.ascx.cs" Inherits="MuaHang_Modul_ChiTietHangHoa" %>
<div class="ChiTietSanPham">
    <asp:DataList ID="DLChiTiet" runat="server" RepeatColumns="1" OnItemCommand="DLChiTiet_ItemCommand">
        <ItemTemplate>
            <div class="NenHinhAnh">
                <asp:Image CssClass="HinhAnh" ImageUrl='<%#Eval("Images") %>' Width="200px" Height="266px" runat="server" />
            </div>
            <div class="ChiTiet">
                <div class="ChiTietSP"> 
                    <h3>Chi tiết cấu hình</h3>
                    <asp:Label CssClass="ChiTietSP1" Text='<%#Eval("Detail") %>' runat="server" />
                </div>
                <div class="ChiTietTen">
                    <h3>Tên sản phẩm</h3>
                    <asp:Label Text='<%#Eval("Name") %>' runat="server" />
                </div>
                <div class="ChiTietGia">
                    <h3>Giá sản phẩm</h3>
                    <asp:Label Text='<%#Eval("Price").ToString()+" VNĐ" %>' runat="server" />
                </div>
                
            </div>
            <div class="ChonMua">
                    <asp:ImageButton CssClass="btnDatMua" CommandName="Order" CommandArgument='<%#Eval("ID") %>' ImageUrl='/Images/ThemVaoGio1.png' runat="server" />
                </div>
        </ItemTemplate>

    </asp:DataList>



</div>
