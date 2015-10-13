using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Common;

public partial class MuaHang_Modul_TimKiem : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["TimKiem"] != null)
                txtTimKiem.Text = (string)Session["TimKiem"];
                rblTimGiaTrongKhoan.SelectedIndex=0;
        }
    }
    protected void btnTimKiem_Click(object sender, ImageClickEventArgs e)
    {
        Session["TimKiem"] = txtTimKiem.Text;
        Response.Redirect("TimKiem.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            Session["TimKiemTheoGia"] = rblTimGiaTrongKhoan.SelectedValue.ToString();
            Response.Redirect("TimKiemTheoGia.aspx");   
    }
}