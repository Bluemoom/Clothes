using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MuaHang_Modul_GioHang : System.Web.UI.UserControl
{
    bool kt = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["CustomerName"] != null)
        {
            lbNguoiDung.Text = "Khách hàng " + (string)Session["CustomerName"];
            btnDangXuat.Text = "Đăng xuất";
            kt = true;
        }
        else
        {
            lbNguoiDung.Visible = false;
            btnDangXuat.Text = "Đăng nhập";
            Button2.Visible = false;
        }
        txtTotalMoney.Enabled = false;
        if (Session["giohang"] == null)
            txtTotalMoney.Text = "0";
        else
        {
            GioHangMua gh = (GioHangMua)Session["giohang"];
            txtTotalMoney.Text = (gh.GetSoLuong()).ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/KhachHang/Cart.aspx");
    }
    protected void btnDangXuat_Click(object sender, EventArgs e)
    {
        if (kt == true)
        {
            Session.Abandon();
            Response.Redirect("~/KhachHang/TrangChu.aspx");          
        }
        else
            Response.Redirect("~/KhachHang/Login.aspx");  
        //Response.Redirect(Request.RawUrl);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoiMatKhau.aspx");
    }
}