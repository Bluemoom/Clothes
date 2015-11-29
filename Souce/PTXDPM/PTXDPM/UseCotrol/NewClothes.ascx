<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewClothes.ascx.cs" Inherits="PTXDPM.UseCotrol.NewClothes" %>
<div class="special">
    <div class="container">
        <h3>Sản phẩm mới</h3>
    </div>
    <div class="specia-top">
        <asp:DataList ID="listproduct" runat="server" RepeatColumns="3" Width="100%" RepeatDirection="Horizontal" OnItemCommand="listproduct_ItemCommand" OnSelectedIndexChanged="listproduct_SelectedIndexChanged">
            <ItemTemplate>
                <div class="Productnew">
                    <div class="imgProductnew">
                    <a href="details.html"><img src="'<%#Eval("URL") %>'" class="img-responsive" alt=""></a>
                   <%-- <asp:Image ImageUrl='<%#Eval("URL") %>' Width="250px" Height="150px" runat="server" />--%>
                    </div>
                    <%--<asp:Label CssClass="NameProduct" Text='<%#Eval("Name") %>' runat="server"/>--%>
                    <h5>'<%#Eval("Name") %>'</h5>
                    <div class="item_add"><span class="item_price"><h6>'<%#Eval("Price").ToString()+" VNĐ" %>'</h6></span></div>  <!-- Load gia sp tu database vao day -->
                    <div class ="DatMua">
                    <%--<asp:ImageButton CssClass="btnDatMua" CommandName="Order" CommandArgument='<%#Eval("ID") %>' ImageUrl='/Images/Order.png' runat="server" />--%>
                    <div class="item_add"><span class="item_price"><asp:ImageButton CssClass="btnDatMua" CommandName="Order" CommandArgument='<%#Eval("ID") %>' ImageUrl='/Images/Order.png' runat="server" /></span></div>  <!-- Bat su kien sau khi nhan nut-->
                     </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>
