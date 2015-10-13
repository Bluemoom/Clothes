<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TimKiem.ascx.cs" Inherits="MuaHang_Modul_TimKiem" %>

<div class="NhapTimKiem" style="border:1px solid #c6cccc; width:173px; margin-top:10px; text-align:center; background-color:#ffffff; ">
<asp:TextBox ID="txtTimKiem" runat="server" BorderStyle="None" ToolTip="Nhập từ khóa " Width="130px" Height="23px"></asp:TextBox>
    <asp:ImageButton ID="btnTimKiem" ImageUrl="~/Images/TimKiem.png" Width="23px" Height="23px" runat="server" OnClick="btnTimKiem_Click" />
</div>
<div class="TuyChonTimKiem">
    <div>
        <h5>Tìm giá trong khoảng</h5>
    </div>
    <div>
        <asp:RadioButtonList ID="rblTimGiaTrongKhoan" runat="server">
            <asp:ListItem Value="1">0 - 5.000.000</asp:ListItem>
            <asp:ListItem Value="2">5.000.000 - 8.000.000</asp:ListItem>
            <asp:ListItem Value="3">8.000.000-10.000.000</asp:ListItem>
            <asp:ListItem Value="4">10.000.000-15.000000</asp:ListItem>
            <asp:ListItem Value="5">Trên 15.000.000</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#F6F6F6" BorderColor="#F6F6F6" BorderStyle="Solid" BorderWidth="1px" OnClick="Button1_Click" Text="Tìm kiếm" />
    </div>
</div>
