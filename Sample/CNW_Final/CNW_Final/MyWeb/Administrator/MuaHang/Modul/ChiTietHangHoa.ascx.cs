using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Data;
using MyWeb.Common;
using MyWeb.Business;

public partial class MuaHang_Modul_ChiTietHangHoa : System.Web.UI.UserControl
{
    ConnectDB db = new ConnectDB();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];
        if(!IsPostBack)
        {
            DLChiTiet.DataSource = ProductService.db.Product_SelectByTop("", " ID ="+ID+"", "");
            DLChiTiet.DataBind();
        }
    }
    //public string GetImages(string ID)
    //{
    //    return db.GetData("SELECT IMAGES FROM PRODUCT WHERE ID= ","IMAGES",ID);
    //}
    //public string GetDetail(string ID)
    //{
    //    return db.GetData("SELECT DETAIL from PRODUCT WHERE ID = ", "DETAIL", ID);
    //}
    protected void DLChiTiet_ItemCommand(object source, DataListCommandEventArgs e)
    {
        GioHangMua gh = new GioHangMua();
        if (e.CommandName == "Order")
        {
            if (Session["giohang"] != null)
                gh = (GioHangMua)Session["giohang"];
            gh.AddHangHoa(new HangHoa(Int32.Parse(e.CommandArgument.ToString()), 1));
            Session["giohang"] = gh;
        }
        Response.Redirect(Request.RawUrl);
    }
}