using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class MuaHang_Modul_GroupProduct : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            rptGroupProduct.DataSource = GroupProductService.db.GroupProduct_SelectByAll();
            rptGroupProduct.DataBind();
        }
    }
    protected void rptGroupProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}