<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="PTXDPM.Customer.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
                <div class="btn_form">
                    <a href="FinishOrder.aspx">HOÀN TẤT MUA HÀNG</a>
                </div>
            </div>
    </div>
    <%--<input type="submit" value="HOÀN TẤT MUA HÀNG" action="FinishOrder.aspx" id="register-submit">--%>
        </form>
        <!-- /Form -->
    </div>
</asp:Content>
