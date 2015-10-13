using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;
using MyWeb.Common;

public partial class QuanTri_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        int qh = UserService.db.User_ChẹckLogin(txtTenDangNhap.Text, txtMatKhau.Text);
            if (qh < 3 && qh > -1)
            {
                Session["Role"] = qh;
                Session["Username"] = txtTenDangNhap.Text.Trim();
                Response.Redirect("~/QuanTri/QL_SanPham.aspx");
            }
            else
            {
                WebMsgBox.Show("False");
            }
    }
}