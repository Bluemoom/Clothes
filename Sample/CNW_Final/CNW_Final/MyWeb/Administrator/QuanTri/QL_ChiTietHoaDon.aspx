<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTri/Administrator.master" AutoEventWireup="true" CodeFile="QL_ChiTietHoaDon.aspx.cs" Inherits="QuanTri_QL_ChiTietHoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <div class="title">Quản lí nhóm sản phẩm</div>
        <asp:Panel ID="pnShow" Width="100%" runat="server">
            <table id="table1" style="border-collapse: collapse; background-color: #DODEFO;">

                <tr>
                    <td>
                        <asp:Button ID="btnThem" runat="server" CssClass="btnThem" Text="Thêm mới" OnClick="btnThem_Click" />
                    </td>
                </tr>
            </table>
            <asp:DataGrid ID="grdOrderDetail" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="3" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdOrderDetail_ItemCommand" OnPageIndexChanged="grdOrderDetail_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Order_ID" HeaderText="ID hóa đơn"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ProductID" HeaderText="ID mặt hàng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Quatity" HeaderText="Số lượng"></asp:BoundColumn>
                    <asp:TemplateColumn>
                        <HeaderTemplate>Chức năng</HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="lbt1" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="Edit" Text="Sửa" />
                            |
                        <asp:LinkButton runat="server" ID="lbt2" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="Delete" Text="Xóa" OnClientClick="return confirm(B?n có ch?c ch?n mu?n xóa không?)" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
                <EditItemStyle BackColor="#2461bF" />
                <HeaderStyle BackColor="#507DC1" Font-Bold="true" ForeColor="White" />
                <ItemStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#F3FBFE" ForeColor="Blue" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="true" ForeColor="#33333" />
            </asp:DataGrid>
        </asp:Panel>
        <asp:Panel ID="pnUpdate" runat="server">


            <%--doan nhap du lieu--%>

            <table id="table2" style="border-collapse: collapse;" cellpadding="0" width="100%" border="0">
                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label1" Text="ID hóa đơn" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtOrder_ID" runat="server" /><asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label4" Text="ID mặt hàng" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductID" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label5" Text="Số lượng" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuatity" runat="server" />
                    </td>
                </tr>


                <tr>
                    <td class="name_fild_row" width="150"></td>
                    <td>
                        <asp:LinkButton ID="lbtUpdate" CssClass="update" runat="server" OnClick="lbtUpdate_Click">Cập nhập</asp:LinkButton>
                        <asp:LinkButton ID="lbtBack" CssClass="back" runat="server" OnClick="lbtBack_Click">Trở lại</asp:LinkButton>
                    </td>
                </tr>


            </table>
        </asp:Panel>
    </form>
</asp:Content>

