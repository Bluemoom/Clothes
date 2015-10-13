<%@ Page Title="" Language="C#" MasterPageFile="~/KhachHang/Site1.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="KhachHang_Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="grdGioHang" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grdGioHang_RowCommand" Width="840px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Mã hàng" />
                <asp:BoundField DataField="Name" HeaderText="Tên mặt hàng" />
                <asp:TemplateField HeaderText="Số lượng">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Sl") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="thanhtien" HeaderText="Thành tiền" />
                <asp:ButtonField CommandName="CapNhat"  Text="Cập nhật" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:Literal ID="LiteralTongtien" runat="server"></asp:Literal>
        <br />
    <asp:Button ID="btnDatHang" runat="server" Text="Đặt hàng" OnClick="btnDatHang_Click" />
</asp:Content>

