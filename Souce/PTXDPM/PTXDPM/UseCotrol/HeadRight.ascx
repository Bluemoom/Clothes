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
            <a href="register.html"><asp:Label ID="lbLogin" runat="server" Text="ĐĂNG NHẬP"></asp:Label></a> | <a href="register.html"><asp:Label ID="lbRegister" runat="server" Text="ĐĂNG KÝ"></asp:Label></a>
        </div>
        <div class="cart box_1">
<%--            <a href="checkout.html">
                <h3><span class="simpleCart_total"><asp:Label ID="lbTongTien" runat="server" Text="Label"></asp:Label>1234567</span> (<span id="simpleCart_quantity" class="simpleCart_quantity">0</span> items)<img src="assets/images/bag.png" alt=""></h3>
            </a>--%>
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
        <form>
            <input type="text" value="" placeholder="search...">
            <input type="submit" value="">
        </form>
    </div>
    <div class="clearfix"></div>
</div>
