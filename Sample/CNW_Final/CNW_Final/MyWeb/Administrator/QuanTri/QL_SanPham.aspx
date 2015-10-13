<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTri/Administrator.master" AutoEventWireup="true" CodeFile="QL_SanPham.aspx.cs" Inherits="QuanTri_QL_SanPham" %>
<%@ Register Src="~/MuaHang/Modul/uploader.ascx" TagPrefix="UC" TagName="Upfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <div class="title">Quản lí hóa đơn</div>
        <asp:Panel ID="pnShow" Width="100%" runat="server">
            <table id="table1" style="bProduct-collapse: collapse; background-color: #DODEFO;">

                <tr>
                    <td>
                        <asp:Button ID="btnThem" runat="server" CssClass="btnThem" Text="Thêm mới" OnClick="btnThem_Click" />
                    </td>
                </tr>
            </table>
            <asp:DataGrid ID="grdProduct" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="9" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdProduct_ItemCommand" OnPageIndexChanged="grdProduct_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Name" HeaderText="mặt hàng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Detail" HeaderText="Chi tiết"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Price" HeaderText="Gía"></asp:BoundColumn>
                    <asp:TemplateColumn HeaderText ="Hình ảnh">
                    <ItemTemplate>
                        <asp:Image ImageUrl='<%#Eval("Images") %>' Width="100px" Height="133px" runat="server" />
                    </ItemTemplate>
                        </asp:TemplateColumn>
                    <asp:BoundColumn DataField="Price_new" HeaderText="Gía mới"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Date" HeaderText="Ngày tạo"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Order" HeaderText="Thứ tự"></asp:BoundColumn>
                    <asp:BoundColumn DataField="GroupProductID" HeaderText="ID nhóm"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Status" HeaderText="Trạng thái"></asp:BoundColumn>

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

            <table id="table2" style="bProduct-collapse: collapse;" cellpadding="0" width="100%" bProduct="0">
                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label1" Text="Mặt hàng" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" /><asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label4" Text="Chi tiết" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtDetail" runat="server" Height="63px" TextMode="MultiLine" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label5" Text="Gía" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label3" Text="Hình ảnh" runat="server" />
                    </td>
                    <td>
                        <UC:Upfile runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label2" Text="Gía mới" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrice_new" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label7" Text="Ngày tạo" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server" >mm/dd/yy</asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label8" Text="Thứ tự" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtOrder" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label9" Text="ID nhóm" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlIdNhom" runat="server" OnSelectedIndexChanged="ddlIdNhom_SelectedIndexChanged" AppendDataBoundItems="True">
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label10" Text="Trạng thái" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="DdlStatus" runat="server">
                            <asp:ListItem Value="1">Hoạt động</asp:ListItem>
                            <asp:ListItem Value="0">Không hoạt động</asp:ListItem>
                        </asp:DropDownList>
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

