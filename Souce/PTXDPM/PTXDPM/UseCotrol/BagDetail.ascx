﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BagDetail.ascx.cs" Inherits="PTXDPM.UseCotrol.Bag" %>
<div class ="BagDetail">
    <asp:GridView ID="grdGioHang" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="MÃ" />
            <asp:BoundField DataField="Name" HeaderText="TÊN HÀNG" />  
            <asp:TemplateField HeaderText="HÌNH ẢNH" HeaderStyle-CssClass="hd_center" ItemStyle-CssClass="center">
            <ItemTemplate>
                <img src='<%#Eval("Images") %>' width="150px" height="225px" alt="" />
            </ItemTemplate>
        </asp:TemplateField>
            <asp:BoundField DataField="Quantity" HeaderText="SỐ LƯỢNG" />
            <asp:BoundField DataField="TotalPrice" HeaderText="THÀNH TIỀN" /> 
            <asp:ButtonField CommandName="CapNhat" Text="Cập nhật" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#F3F4F5" Font-Bold="True" ForeColor="#765C2B" />
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
    
    </div>
<div class ="Order">
    <h2>ĐƠN HÀNG</h2>
    <h4>Tổng tiền</h4><asp:Label ID="lbTongTien" runat="server" Text="0 VNĐ"></asp:Label>
    <h4>Chi phí vận chuyển</h4><asp:Label ID="lb1" runat="server" Text="0 VNĐ"></asp:Label>
     <div class="btn_form">
                    <a href="Order.aspx">ĐẶT HÀNG</a>
     </div>
</div>
   
