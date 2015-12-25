<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeadRight.ascx.cs" Inherits="PTXDPM.UseCotrol.HeadRight" %>
<div class="header_right">
    <div class="rgt-bottom">
        <div class="log">
            <div class="login">
                <div id="loginContainer">                    
                </div>
            </div>
        </div>
        <div class="reg">
            <a href="/Customer/Login.aspx"><asp:Label ID="lbLogin" runat="server" Text="ĐĂNG NHẬP"></asp:Label></a> | <a href="/Customer/Register.aspx"><asp:Label ID="lbRegister" runat="server" Text="ĐĂNG KÝ"></asp:Label></a><a href="/Customer/Home.aspx?state=1"><asp:Label ID="lbDangXuat" runat="server" Text="ĐĂNG XUẤT"></asp:Label></a>
        </div>
        <div class="cart box_1">
            <a href="/Customer/BagDetail.aspx"
            <h3>$ <asp:Label ID="lbTongTien" runat="server" Text="Label"></asp:Label>(<asp:Label ID="lbSoLuong" runat="server" Text="Label"></asp:Label>)<img src="assets/images/bag.png" alt=""></h3>
                </a>
            <div class="clearfix"></div>
        </div>
        <div class="create_btn">
            <a href="/Customer/BagDetail.aspx">Xem giỏ</a>
        </div>
        <div class="clearfix"></div>
    </div>
    <div class="search">
            <input type="text" value="" width ="200px" placeholder="search...">
            <div class="create_btn">
            <a href="/Customer/BagDetail.aspx">Search</a>
        </div>

    </div>
    <div class="clearfix"></div>
</div>
