<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Products_Management.aspx.cs" Inherits="PTXDPM.Admin.Products_Management" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 151px;
        }
        .auto-style2 {
            width: 151px;
            height: 318px;
            left: 0px;
            top: 22px;
        }
        .auto-style8 {
            font-size: 12pt;
        }
        .auto-style17 {
            height: 37px;
            font-size: 11pt;
        }
        .auto-style18 {
            width: 328px;
            font-size: 11pt;
            height: 39px;
        }
        .auto-style19 {
            height: 39px;
            width: 139px;
        }
        .auto-style20 {
            height: 39px;
            width: 328px;
        }
        .auto-style21 {
            height: 39px;
            width: 100px;
        }
        .auto-style22 {
            height: 39px;
        }
        .auto-style23 {
            height: 40px;
            width: 139px;
        }
        .auto-style24 {
            height: 40px;
            width: 328px;
        }
        .auto-style25 {
            height: 40px;
            width: 100px;
        }
        .auto-style26 {
            height: 40px;
        }
        .auto-style27 {
            height: 37px;
            width: 139px;
        }
        .auto-style28 {
            height: 37px;
            width: 328px;
        }
        .auto-style29 {
            height: 37px;
            width: 100px;
        }
        .auto-style30 {
            text-align: center;
            height: 77px;
        }
        .auto-style32 {
            text-align: left;
            height: 51px;
        }
        .auto-style33 {
            height: 140px;
        }
        .auto-style34 {
            width: 100%;
            height: 560px;
        }
        .auto-style35 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style30" colspan="2" style="background-color: #f5f5f5"><strong style="font-size: 24px">QUẢN LÝ HÀNG HÓA</strong><br />
            </td>
        </tr>
        <tr >
            <td class="auto-style2" style="border: thick solid #f5f5f5; font-size: 14px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/Products_Management.aspx">QUẢN LÝ HÀNG HÓA</asp:HyperLink>
            </td>
            <td rowspan="2" style="font-size: 14px">
                <table class="auto-style34">
                    <tr>
                        <td class="auto-style19" style="border: thin solid #f5f5f5">
                            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                        </td>
                        <td class="auto-style20" style="border: thin solid #f5f5f5">
                            <asp:TextBox ID="txtID" runat="server" Width="46px" Enabled="False"></asp:TextBox>
                        </td>
                        <td class="auto-style21" style="border: thin solid #f5f5f5">MÀU ID</td>
                        <td class="auto-style22" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:DropDownList ID="drcolorid" runat="server" DataSourceID="SqlDataSource3" Height="22px" Width="101px">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ClothesConnectionString %>" SelectCommand="SELECT [ID] FROM [Color] ORDER BY [ID]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style23" style="border: thin solid #f5f5f5">TÊN</td>
                        <td class="auto-style24" style="border: thin solid #f5f5f5">
                            <asp:TextBox ID="txtname" runat="server" Width="191px"></asp:TextBox>
                        </td>
                        <td class="auto-style25" style="border: thin solid #f5f5f5">SIZE ID</td>
                        <td class="auto-style26" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:DropDownList ID="drsizeid" runat="server" DataSourceID="SqlDataSource4" Height="22px" Width="101px">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ClothesConnectionString %>" SelectCommand="SELECT [ID] FROM [Size] ORDER BY [ID]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style27" style="border: thin solid #f5f5f5">NHÓM SẢN PHẨM</td>
                        <td class="auto-style28" style="border: thin solid #f5f5f5">
                            <asp:DropDownList ID="drgroupclothes" runat="server" DataSourceID="SqlDataSource2" DataTextField="ID" Height="22px" Width="118px">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ClothesConnectionString %>" SelectCommand="SELECT [ID] FROM [GroupClothes] ORDER BY [ID]"></asp:SqlDataSource>
                        </td>
                        <td class="auto-style29" style="border: thin solid #f5f5f5">HÌNH ẢNH</td>
                        <td class="auto-style17" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:FileUpload ID="uphinh" runat="server" Width="258px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" style="border: thin solid #f5f5f5">MÔ TẢ</td>
                        <td class="auto-style20" style="border: thin solid #f5f5f5">
                            <asp:TextBox ID="txtdescription" runat="server" Width="255px"></asp:TextBox>
                        </td>
                        <td class="auto-style21" style="border: thin solid #f5f5f5">CHẤT LIỆU ID</td>
                        <td class="auto-style22" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:DropDownList ID="drmaterialid" runat="server" DataTextField="ID" DataSourceID="SqlDataSource5" Height="22px">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:ClothesConnectionString %>" SelectCommand="SELECT [ID] FROM [Material] ORDER BY [ID]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" style="border: thin solid #f5f5f5">GIÁ NHẬP</td>
                        <td class="auto-style20" style="border: thin solid #f5f5f5">
                            <asp:TextBox ID="txtpricein" runat="server" Width="79px"></asp:TextBox>
                        </td>
                        <td class="auto-style21" style="border: thin solid #f5f5f5">SỐ LƯỢNG</td>
                        <td class="auto-style22" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:TextBox ID="txtquantity" runat="server" Width="55px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" style="border: thin solid #f5f5f5">GIÁ BÁN</td>
                        <td class="auto-style20" style="border: thin solid #f5f5f5">
                            <asp:TextBox ID="txtpriceout" runat="server" Width="79px"></asp:TextBox>
                        </td>
                        <td class="auto-style21" style="border: thin solid #f5f5f5">TRẠNG THÁI</td>
                        <td class="auto-style22" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:TextBox ID="txtstatus" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" style="border: thin solid #f5f5f5">GIÁ MỚI</td>
                        <td class="auto-style20" style="border: thin solid #f5f5f5">
                            <asp:TextBox ID="txtnewprice" runat="server" Width="79px"></asp:TextBox>
                        </td>
                        <td class="auto-style21" style="border: thin solid #f5f5f5">ĐẶT HÀNG</td>
                        <td class="auto-style22" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:TextBox ID="txtorder" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" style="border: thin solid #f5f5f5">GIỚI TÍNH</td>
                        <td class="auto-style18" style="border: thin solid #f5f5f5">
                            <asp:DropDownList ID="drsex" runat="server" Height="22px" Width="101px">
                                <asp:ListItem Value="Nam"></asp:ListItem>
                                <asp:ListItem Value="Nữ"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style21" style="border: thin solid #f5f5f5">NEW</td>
                        <td class="auto-style22" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:TextBox ID="txtnew" runat="server" Width="42px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style32" colspan="4" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;"><span class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>&nbsp;&nbsp;
                            <asp:Button ID="btnluu" runat="server" Text="LƯU" Width="80px" OnClick="btnluu_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnhuy" runat="server" Text="HỦY" Width="80px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style33" colspan="4" style="border-style: solid; border-width: thin thick thin thin; border-color: #f5f5f5;">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" PageSize="5">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                                    <asp:BoundField DataField="Name" HeaderText="Tên" SortExpression="Name" />
                                    <asp:BoundField DataField="GroupClothesID" HeaderText="Nhóm hàng hóa" SortExpression="GroupClothesID" />
                                    <asp:BoundField DataField="Description" HeaderText="Mô tả" SortExpression="Description" />
                                    <asp:BoundField DataField="PriceIN" HeaderText="Giá nhập" SortExpression="PriceIN" />
                                    <asp:BoundField DataField="PriceOUT" HeaderText="Giá bán" SortExpression="PriceOUT" />
                                    <asp:BoundField DataField="NewPrice" HeaderText="Giá mới" SortExpression="NewPrice" />
                                    <asp:BoundField DataField="Sex" HeaderText="Giới tính" SortExpression="Sex" />
                                    <asp:BoundField DataField="ColorID" HeaderText="Nhóm màu" SortExpression="ColorID" />
                                    <asp:BoundField DataField="SizeID" HeaderText="Nhóm size" SortExpression="SizeID" />
                                    <asp:BoundField DataField="Images" HeaderText="Hình ảnh" SortExpression="Images" />
                                    <asp:BoundField DataField="MaterialID" HeaderText="Nhóm chất liệu" SortExpression="MaterialID" />
                                    <asp:BoundField DataField="Quantity" HeaderText="Số lượng" SortExpression="Quantity" />
                                    <asp:BoundField DataField="Status" HeaderText="Trạng thái" SortExpression="Status" />
                                    <asp:BoundField DataField="Order" HeaderText="Đặt hàng" SortExpression="Order" />
                                    <asp:BoundField DataField="New" HeaderText="New" SortExpression="New" />
                                </Columns>
                                <FooterStyle BackColor="#CCCC99" />
                                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F7DE" />
                                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                <SortedAscendingHeaderStyle BackColor="#848384" />
                                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                <SortedDescendingHeaderStyle BackColor="#575357" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ClothesConnectionString %>" 
                                SelectCommand="SELECT * FROM [Clothes] ORDER BY [ID]"
                                UpdateCommand="Update [Clothes] SET Name=@Name,GroupClothesID=@GroupClothesID,Description=@Description,PriceIN=@PriceIN,PriceOUT=@PriceOUT,NewPrice=@NewPrice,Sex=@Sex,ColorID=@ColorID,SizeID=@SizeID,Images=@Images,MaterialID=@MaterialID,Quantity=@Quantity,Status=@Status,[Order]=@Order,New=@New  where ID = @ID"
                                DeleteCommand="Delete From [Clothes] where ID = @ID "
                                >

                                <UpdateParameters>
                                    <asp:Parameter Name="ID" Type ="int32" />
                                    <asp:Parameter Name="Name" Type ="String" />
                                    <asp:Parameter Name="GroupClothesID" Type ="int32" />
                                    <asp:Parameter Name="Description" Type ="String" />
                                    <asp:Parameter Name="PriceIN" Type ="Double" />
                                    <asp:Parameter Name="PriceOUT" Type ="Double" />
                                    <asp:Parameter Name="NewPrice" Type ="Double" />
                                    <asp:Parameter Name="Sex" Type ="string" />
                                    <asp:Parameter Name="ColorID" Type ="int32" />
                                    <asp:Parameter Name="SizeID" Type ="int32" />
                                    <asp:Parameter Name="Images" Type ="string" />
                                    <asp:Parameter Name="MaterialID" Type ="int32" />
                                    <asp:Parameter Name="Quantity" Type ="int32" />
                                    <asp:Parameter Name="Status" Type ="int32" />
                                    <asp:Parameter Name="Order" Type ="int32" />
                                    <asp:Parameter Name="New" Type ="int32" />
                                </UpdateParameters>

                                <DeleteParameters>
                                    <asp:Parameter Name="ID" Type ="String" />
                                </DeleteParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" class="auto-style35" style="border-style: solid; border-width: thin thick thick thin; border-color: #f5f5f5;">
                            <asp:Label ID="lblerror" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="border: thick solid #f5f5f5; font-size: 14px">
                <asp:HyperLink ID="HyperLink2" runat="server">QUẢN LÝ ĐẶT HÀNG</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
