<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTXDPM.Customer.Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="registration_left">
		<h2>ĐĂNG NHẬP</h2>
		 <div class="registration_form">
		 <!-- Form -->
			<form id="registration_form" method="post">
				<div>
					<label>
					 <asp:TextBox ID="txtTenDangNhap" placeholder="Tên đăng nhập" runat="server" Width="500px" required=""></asp:TextBox>
					</label>
				</div>
				<div>
					<label>
						 <asp:TextBox ID="txtMatKhau" placeholder="Mật khẩu" runat="server" Width="500px" required=""></asp:TextBox>
					</label>
				</div>						
				<div>
					<input type="submit" value="Đăng nhập" id="register-submit">
				</div>
			</form>
			<!-- /Form -->
			</div>
</asp:Content>
