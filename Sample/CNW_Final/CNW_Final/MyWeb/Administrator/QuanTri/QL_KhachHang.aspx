<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTri/Administrator.master" AutoEventWireup="true" CodeFile="QL_KhachHang.aspx.cs" Inherits="QuanTri_QL_KhachHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <div class="title">QUẢN LÍ KHÁCH HÀNG</div>
        <asp:Panel ID="pnShow" Width="100%" runat="server">
            <table id="table1" style="border-collapse: collapse; background-color: #DODEFO;">

                <tr>
                    <td>
                        <asp:Button ID="btnThem" runat="server" CssClass="btnThem" Text="Thêm mới" OnClick="btnThem_Click" />
                    </td>
                </tr>
            </table>
            <asp:DataGrid ID="grdCustomer" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="6" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdCustomer_ItemCommand" OnPageIndexChanged="grdCustomer_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Username" HeaderText="Tên đăng nhập"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Password" HeaderText="Mật khẩu"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Brithday" HeaderText="Ngày sinh"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Provice" HeaderText="Tỉnh thành"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Address" HeaderText="Địa chỉ"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Tell" HeaderText="Số điện thoại"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Email" HeaderText="Email"></asp:BoundColumn>
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
                        <asp:Label ID="label1" Text="Tên Đăng nhập" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" /><asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label7" Text="Mật khẩu" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtMatKhau" runat="server" /><asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label4" Text="Ngày sinh" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgaysinh" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label5" Text="Tỉnh thành" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtTinhThanh" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label3" Text=" Địa chỉ" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtDiaChi" runat="server" />
                    </td>
                </tr>


                <tr>
                    <td class="name_fild_row" width="150">
                        <asp:Label ID="label2" runat="server" Text="Số điện thoại" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtSDT" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label6" Text="Email" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" />
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

