<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Administrator.Master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Admins_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title">Quản lí người dùng </div>
    <asp:Panel ID="pnShow" Width="100%" runat="server">
        <table id="table1" style="border-collapse: collapse; background-color: #DODEFO;">

            <tr>
                <td>
                    <asp:Button ID="btnThem" runat="server" CssClass="btnThem" Text="Thêm mới" OnClick="btnThem_Click" />
                </td>
            </tr>
        </table>
        <asp:DataGrid ID="grdUser" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="4" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdUser_ItemCommand" OnPageIndexChanged="grdUser_PageIndexChanged">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle CssClass="trHeader" />
            <Columns>
                <asp:BoundColumn DataField="UserName" HeaderText="Tài khoản"></asp:BoundColumn>
                <asp:BoundColumn DataField="Name" HeaderText="Tên người dùng"></asp:BoundColumn>
                <asp:BoundColumn DataField="Rule" HeaderText="Quyền"></asp:BoundColumn>
                <asp:BoundColumn DataField="Status" HeaderText="Trạng thái"></asp:BoundColumn>

                <asp:TemplateColumn>
                    <HeaderTemplate>Chức năng</HeaderTemplate>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbt1" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="Edit" CssClass="edit" ToolTip="Sửa" />|
                        <asp:LinkButton runat="server" ID="lbt2" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID") %>' CommandName="Delete" CssClass="delete" ToolTip="Xóa" OnClientClick="return confirm(Bạn có chắc chắn muốn xóa không?)" />
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
        <table id="table2" style="border-collapse: collapse;" cellpadding="0" width="100%" border="0">
            <tr>
                <td width="150" class="name_fild_row">
                    <asp:Label ID="label1" Text="Tên đăng nhập" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" /><asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="name_fild_row" width="150">
                    <asp:Label ID="label3" runat="server" Text="Tên người dùng" />
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" />
                </td>
            </tr>

            <tr>
                <td class="name_fild_row" width="150">
                    <asp:Label ID="label2" runat="server" Text="Mật khẩu" />
                </td>
                <td>
                    <asp:TextBox ID="txtMatKhau" runat="server" />
                </td>
            </tr>

            <tr>
                <td class="name_fild_row" width="150">
                    <asp:Label runat="server" Text="Quyền hạn" />
                </td>
                <td>
                    <asp:DropDownList ID="DdlRole" runat="server">
                        <asp:ListItem Value="1">Admin</asp:ListItem>
                        <asp:ListItem Value="2">User</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox1" runat="server" />
                </td>
            </tr>

            <tr>
                <td class="name_fild_row" width="150">
                    <asp:Label runat="server" Text="Trạng thái" />
                </td>
                <td>
                    <asp:DropDownList ID="DdlStatus" runat="server">
                        <asp:ListItem Value="1">Sử dụng</asp:ListItem>
                        <asp:ListItem Value="2">Cấm sử dụng</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox2" runat="server" />
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
</asp:Content>

