using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Common;
using MyWeb.Business;
using MyWeb.Data;

public partial class MuaHang_Modul_Login : System.Web.UI.UserControl
{
    ConnectDB db = new ConnectDB();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
            int i = CustomerService.db.Customer_CheckLogin(txtUserName.Text, txtPassWord.Text);
            if (i > 0)
            {
                Session["IdCustomer"] = i;
                Session["CustomerName"] = db.GetData("SELECT UserName FROM CUSTOMER WHERE ID =", "UserName",i.ToString());
                Response.Redirect("~/KhachHang/TrangChu.aspx");
            }
            else
            {
                WebMsgBox.Show("Tai khoan khong ton tai");
                txtUserName.Focus();
            }
    }
    protected void btnThoat_Click(object sender, EventArgs e)
    {
        Response.Redirect("Trangchu.aspx");
    }
}