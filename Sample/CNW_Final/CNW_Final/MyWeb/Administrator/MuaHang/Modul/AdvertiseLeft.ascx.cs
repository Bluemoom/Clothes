using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class MuaHang_Modul_AdvertiseLeft : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            rptAdvertiseLeft.DataSource = QuangCaoService.QuangCao_SelectByTop("", " Position=2 and status =1", " [order]");
            rptAdvertiseLeft.DataBind();
        }
    }
}