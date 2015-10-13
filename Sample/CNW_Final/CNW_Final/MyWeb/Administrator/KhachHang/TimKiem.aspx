<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="TimKiem.aspx.cs" Inherits="KhachHang_TimKiem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class=" DanhSachSanPham">
    <div class="TieuDe">
        <h5><%#Eval("") %></h5>
    </div>
    <div class="NoiDungHienThi">
        <asp:DataList ID="listproduct" runat="server" RepeatColumns="4" Width="100%" RepeatDirection="Horizontal" OnItemCommand="listproduct_ItemCommand" OnSelectedIndexChanged="listproduct_SelectedIndexChanged">
            <ItemTemplate>
                <div class="SP">
                    <div class="HinhAnhSP">
                    <asp:ImageButton CommandName="Detail" CommandArgument='<%#Eval("ID") %>' ImageUrl='<%#Eval("Images") %>' Width="100px" Height="133px" runat="server" />
                    </div>
                    <asp:Label CssClass="TenSP" Text='<%#Eval("Name") %>' runat="server"/>
                    <asp:Label CssClass="GiaSP" Text='<%#Eval("Price").ToString()+" VNĐ" %>' runat="server" />
                    <div class ="DatMua">
                    <asp:ImageButton CssClass="btnDatMua" CommandName="Order" CommandArgument='<%#Eval("ID") %>' ImageUrl='/Images/ThemVaoGio.png' Width="100px" Height="33px" runat="server" />
                     </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>
</asp:Content>

