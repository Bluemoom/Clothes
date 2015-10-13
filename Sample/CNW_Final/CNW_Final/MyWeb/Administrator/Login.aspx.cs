using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Data;
using MyWeb.Business;
using MyWeb.Common;

public partial class Account_Admins_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        int qh = UserService.db.User_ChẹckLogin(txtUserName.Text,txtPassWord.Text);
        if (qh < 3 && qh > -1)
        {
            Session["Role"] = qh;
            Session["Username"] = txtUserName.Text.Trim();
            Response.Redirect("~/QuanTri/QL_SanPham.aspx");
        }
        else
        {
            WebMsgBox.Show("False");
        }
    }
}