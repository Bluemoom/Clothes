<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PTXDPM.Customer.Register" %>

<%@ Register Src="~/UseCotrol/HeadRight.ascx" TagPrefix="uc1" TagName="HeadRight" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:HeadRight runat="server" ID="HeadRight" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="registration_form">
        <h2>THÔNG TIN KHÁCH HÀNG</h2>
		 <!-- Form -->
        <form id="registration_form" method="post">
            <div>
                <label>
                    <asp:TextBox ID="txtHoTen" placeholder="Họ tên" runat="server" Width="500px" required=""></asp:TextBox>
                </label>
            </div>
            <div>
                <label>
                    <asp:TextBox ID="txtEmail" placeholder="Email" runat="server" Width="500px" required=""></asp:TextBox>
                </label>
            </div>
            <div>
                <label>
                    <asp:TextBox ID="txtDiaChi" placeholder="Địa chỉ" runat="server" Width="500px" required=""></asp:TextBox>
                </label>
            </div>
            <div>
                <label>
                    <asp:TextBox ID="txtSĐT" placeholder="Số điện thoại" runat="server" Width="500px" required=""></asp:TextBox>
                </label>
            </div>


            <div class="sky-form">
                <div class="sky_form1">
                    <ul>
                        <li>
                            <asp:RadioButton ID="RadioButton1" Checked="true" Visible="true" Text="Nam" GroupName="GioiTinh" runat="server" /></li>
                        <li>

                            <asp:RadioButton ID="RadioButton2" Text="Nữ" GroupName="GioiTinh" runat="server" /></li>
                        <div class="clearfix"></div>
                    </ul>
                </div>
            </div>
            <div>

                <div>
                    <label>
                        <asp:TextBox ID="txtTenDangNhap" placeholder="Tên đăng nhập" runat="server" Width="500px" required=""></asp:TextBox>
                    </label>
                </div>
                <label>
                    <asp:TextBox ID="txtMatKhau" placeholder="Mật khẩu" runat="server" TextMode="Password" Width="500px" required=""></asp:TextBox>
                </label>
            </div>
            <div>
                <label>
                    <asp:TextBox ID="txtNhapLaiMatKhau" placeholder="Nhập lại mật khẩu" TextMode="Password" runat="server" Width="500px" required=""></asp:TextBox>
                </label>
            </div>
            <div>
                <input type="submit" value="Tạo tài khoản" id="register-submit">
            </div>
            <div class="sky-form">
                <label class="checkbox">
                    <input type="checkbox" name="checkbox"><i></i>Đồng ý với các điều khoản crazyClothes.com &nbsp;<a class="terms" href="#">Thông tin điều khoản </a>
                </label>
            </div>
        </form>
        <!-- /Form -->
    </div>
</asp:Content>
