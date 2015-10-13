using System;
using MyWeb.Business;
using MyWeb.Common;
using MyWeb.Data;

namespace MyWeb.Admins
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogon_Click(object sender, EventArgs e)
        {
            int qh = UserService.User_CheckLogin(txtUsername.Text, StringClass.Encrypt(txtPassword.Text));
            if (qh < 3 && qh >-1)
            {
                Session["Role"] = qh;
                Session["Username"] = txtUsername.Text.Trim();
                Response.Redirect("~/Admins/Default.aspx");
            }
            else
            {
                WebMsgBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
        protected void btnHuyBo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}