using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class KhachHang_TimKiem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            listproduct.DataSource = ProductService.db.Product_SelectByTop("", " Name like '%" + Session["TimKiem"] + "%'", "");
            listproduct.DataBind();
        }

    }
    protected void listproduct_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void listproduct_ItemCommand(object source, DataListCommandEventArgs e)
    {
        GioHangMua gh = new GioHangMua();
        if (e.CommandName == "Order")
        {
            if (Session["giohang"] != null)
                gh = (GioHangMua)Session["giohang"];
            gh.AddHangHoa(new HangHoa(Int32.Parse(e.CommandArgument.ToString()), 1));
            Session["giohang"] = gh;
        }
        if (e.CommandName == "Detail")
        {
            Response.Redirect("DTDD.aspx?ID=" + e.CommandArgument.ToString() + "");
        }
        Response.Redirect(Request.RawUrl);  
    }
}