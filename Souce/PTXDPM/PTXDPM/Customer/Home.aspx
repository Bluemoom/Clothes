<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PTXDPM.Customer.Home" %>
<%--<%@ Register Src="~/UseCotrol/NewClothes.ascx" TagName="NewClothes" TagPrefix="UC" %>--%>
<%@ Register Src="~/UseCotrol/HeadRight.ascx" TagName="HeadRight" TagPrefix="UC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<UC:NewClothes runat="server" />--%>
    <div class="arriv">
	<div class="container">
		<div class="arriv-top">
			<div class="col-md-6 arriv-left">
				<img src="assets/images/1.jpg" class="img-responsive" alt=""> <!-- Load hinh anh tu database vao day-->
				<div class="arriv-info">
					<h3>MỘT NĂM BẢO HÀNH</h3>  <!-- Load tieu de tu database vao day-->
					<p>CÓ GÌ ĐẶC BIỆT</p>  <!-- Load tieu de tu database vao day-->
					<div class="crt-btn">
						<a href="details.html">XEM THÊM</a>   <!-- Thay thang ActionRectiont load bai viet tu database vào day-->
					</div>
				</div>
			</div>
			<div class="col-md-6 arriv-right">
				<img src="assets/images/2.jpg" class="img-responsive" alt="">
				<div class="arriv-info">
					<h3>THỬ GIÀY</h3>
					<p>TẠI NHÀ</p>
					<div class="crt-btn">
						<a href="details.html">XEM NGAY</a> <!-- cai nay phai dung actionto load tu database ra -->
					</div>
				</div>
			</div>
			<div class="clearfix"> </div>
		</div>
		<div class="arriv-bottm">
			<div class="col-md-8 arriv-left1">
				<img src="assets/images/3.jpg" class="img-responsive" alt="">
				<div class="arriv-info1">
					<h3>MIỄN PHÍ ĐỔI TRẢ</h3>
					<p>TRONG VÒNG 365 NGÀY</p>
					<div class="crt-btn">
						<a href="details.html">XEM THÊM</a>
					</div>
				</div>
			</div>
			<div class="col-md-4 arriv-right1">
				<img src="assets/images/4.jpg" class="img-responsive" alt="">
				<div class="arriv-info2">
					<a href="details.html"><h3>Trekking Shoes<i class="ars"></i></h3></a>
				</div>
			</div>
			<div class="clearfix"> </div>
		</div>
		<div class="arriv-las">
			<div class="col-md-4 arriv-left2">
				<img src="assets/images/5.jpg" class="img-responsive" alt="">
				<div class="arriv-info2">
					<a href="details.html"><h3>Casual Glasses<i class="ars"></i></h3></a>
				</div>
			</div>
			<div class="col-md-4 arriv-middle">
				<img src="assets/images/6.jpg" class="img-responsive" alt="">
				<div class="arriv-info3">
					<h3>FRESH LOOK T-SHIRT</h3>
					<div class="crt-btn">
						<a href="details.html">SHOP NOW</a>
					</div>
				</div>
			</div>
			<div class="col-md-4 arriv-right2">
				<img src="assets/images/7.jpg" class="img-responsive" alt="">
				<div class="arriv-info2">
					<a href="details.html"><h3>Elegant Watches<i class="ars"></i></h3></a>
				</div>
			</div>
			<div class="clearfix"> </div>
		</div>
	</div>
</div>
    <div class="special">
    <div class="container">
        <h3>Sản phẩm mới</h3>
    </div>
    <div class="specia-top">
        <asp:DataList ID="listproduct" runat="server" RepeatColumns="3" Width="100%" RepeatDirection="Horizontal" >
            <ItemTemplate>
                 <div class="Productnew">
               <a href="DetailClothes.aspx?ID=<%#Eval("ID") %>"><img src="<%#Eval("Images") %>" class="img-responsive" alt=""></a>   <!-- Load trang chi tiet va hinh anh tu database vao day -->
				<div class="special-info grid_1 simpleCart_shelfItem">
					<h5><%#Eval("Name") %></h5> <!-- Load ten san pham tu database vao day -->
					<div class="item_add"><span class="item_price"><h6><%#Eval("PriceOut").ToString()+" VNĐ" %></h6></span></div>  <!-- Load gia sp tu database vao day -->
					<div class="item_add"><span class="item_price"><a href="BagDetail.aspx?ID=<%#Eval("ID") %>">Thêm vào giỏ</a></span></div>  <!-- Bat su kien sau khi nhan nut-->
				</div>
                 </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <UC:HeadRight runat="server" />
</asp:Content>