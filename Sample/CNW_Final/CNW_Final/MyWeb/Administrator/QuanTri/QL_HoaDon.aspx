<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTri/Administrator.master" AutoEventWireup="true" CodeFile="QL_HoaDon.aspx.cs" Inherits="QuanTri_QL_HoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <div class="title">Quản lí hóa đơn</div>
        <asp:Panel ID="pnShow" Width="100%" runat="server">
            <table id="table1" style="border-collapse: collapse; background-color: #DODEFO;">

                <tr>
                    <td>
                        <asp:Button ID="btnThem" runat="server" CssClass="btnThem" Text="Thêm mới" OnClick="btnThem_Click" />
                    </td>
                </tr>
            </table>
            <asp:DataGrid ID="grdOrder" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="4" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdOrder_ItemCommand" OnPageIndexChanged="grdOrder_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Customer_ID" HeaderText="ID khách hàng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Totalmoney" HeaderText="Tổng tiền"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Date" HeaderText="Thời gian mua"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Status" HeaderText="Trạng thái"></asp:BoundColumn>

                    <asp:TemplateColumn>
                        <HeaderTemplate>Chức năng</HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="lbt1" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="Edit" Text="Sửa" />
                            |
                        <asp:LinkButton runat="server" ID="lbt2" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="Delete" Text="Xóa" />
                            |   
                        <asp:LinkButton runat="server" ID="lbt3" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="ViewOrderDetail" Text="Chi tiết hóa đơn" />
                            |
                           <%-- <asp:LinkButton runat="server" ID="LinkButton1" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Customer_ID") %>' CommandName="ViewCustomerDetail" Text="Chi tiết khách hàng" />
                       --%> </ItemTemplate>
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
                        <asp:Label ID="label1" Text="Tên khách hàng" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustomer_ID" runat="server" /><asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label4" Text="Tổng tiền" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtTotalmoney" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label5" Text="Thời gian mua" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label3" Text="Trạng thái" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server" />
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
        <asp:Panel ID="PnCustomerDetail" runat="server">
            <asp:DataGrid ID="grdCustomer" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="6" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdCustomer_ItemCommand" OnPageIndexChanged="grdCustomer_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Username" HeaderText="Tên đăng nhập"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Password" HeaderText="Mật khẩu"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Brithday" HeaderText="Ngày sinh"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Provice" HeaderText="Tỉnh thành"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Address" HeaderText="địa chỉ"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Tell" HeaderText="Số điện thoại"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Email" HeaderText="Email"></asp:BoundColumn>
                </Columns>
                <EditItemStyle BackColor="#2461bF" />
                <HeaderStyle BackColor="#507DC1" Font-Bold="true" ForeColor="White" />
                <ItemStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#F3FBFE" ForeColor="Blue" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="true" ForeColor="#33333" />
            </asp:DataGrid>
        </asp:Panel>
        <asp:Panel ID="PnOrderDetail" runat="server">

            <asp:DataGrid ID="grdOrderDetail" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="3" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdOrderDetail_ItemCommand" OnPageIndexChanged="grdOrderDetail_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Order_ID" HeaderText="ID hóa đơn"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ProductID" HeaderText="ID mặt hàng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Quatity" HeaderText="Số lượng"></asp:BoundColumn>
                </Columns>
                <EditItemStyle BackColor="#2461bF" />
                <HeaderStyle BackColor="#507DC1" Font-Bold="true" ForeColor="White" />
                <ItemStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#F3FBFE" ForeColor="Blue" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="true" ForeColor="#33333" />
            </asp:DataGrid>
        </asp:Panel>
    </form>
</asp:Content>

