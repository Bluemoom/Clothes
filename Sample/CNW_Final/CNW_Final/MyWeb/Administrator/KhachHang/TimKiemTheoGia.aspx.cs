using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class KhachHang_TimKiemTheoGia : System.Web.UI.Page
{
    int TimKiemTheoGia=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TimKiemTheoGia = int.Parse(Session["TimKiemTheoGia"].ToString());
            switch (TimKiemTheoGia)
            {
                case 1:
                     listproduct.DataSource = ProductService.db.Product_SelectByTop("", " PRICE > 0 AND PRICE <5000000", " PRICE");
                     listproduct.DataBind();
                     break;
                case 2:
                     listproduct.DataSource = ProductService.db.Product_SelectByTop("", " PRICE > 5000000 AND PRICE <8000000", " PRICE");
                     listproduct.DataBind();
                     break;
                case 3:
                     listproduct.DataSource = ProductService.db.Product_SelectByTop("", " PRICE > 8000000 AND PRICE <10000000", " PRICE");
                     listproduct.DataBind();
                     break;
                case 4:
                     listproduct.DataSource = ProductService.db.Product_SelectByTop("", " PRICE>10000000 And PRICE < 15000000", " PRICE");
                     listproduct.DataBind();
                     break;
                case 5:
                    listproduct.DataSource = ProductService.db.Product_SelectByTop("", " PRICE> 15000000", " PRICE");
                     listproduct.DataBind();
                     break;

            }

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