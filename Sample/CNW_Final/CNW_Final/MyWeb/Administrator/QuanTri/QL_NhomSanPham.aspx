<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTri/Administrator.master" AutoEventWireup="true" CodeFile="QL_NhomSanPham.aspx.cs" Inherits="QuanTri_QL_NhomSanPham" %>
<%@ Register Src="~/MuaHang/Modul/uploader.ascx" TagName="UpFile" TagPrefix="UC"  %>
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
            <asp:DataGrid ID="grdGroupProduct" runat="server" AllowPaging="true" AutoGenerateColumns="false" CellPadding="5" ForeColor="#33333" Width="100%" Font-Size="10" OnItemCommand="grdGroupProduct_ItemCommand" OnPageIndexChanged="grdGroupProduct_PageIndexChanged">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle CssClass="trHeader" />
                <Columns>
                    <asp:BoundColumn DataField="Name" HeaderText="Tên nhóm"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Content" HeaderText="Nội dung"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Images" HeaderText="Hình ảnh"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Order" HeaderText="Sắp xếp"></asp:BoundColumn>
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

            <table id="table2" style="border-collapse: collapse;" cellpadding="0" width="100%" border="0">
                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label1" Text="Tên nhóm" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" /><asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label4" Text="Nội dung" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtContent" runat="server" Height="84px" TextMode="MultiLine" Width="120px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label5" Text="Hình ảnh" runat="server" />
                    </td>
                    <td>
                        <UC:UpFile runat="server" />
                    </td>
                </tr>

                <tr>
                    <td width="150" class="name_fild_row">
                        <asp:Label ID="label3" Text="Sắp xếp" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtOrder" runat="server" />
                    </td>
                </tr>


                <tr>
                    <td class="name_fild_row" width="150">
                        <asp:Label ID="label2" runat="server" Text="Trạng Thái" />
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
    </form>
</asp:Content>

