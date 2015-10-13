using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;
using MyWeb.Common;
using MyWeb.Data;

public partial class Modul_Banner : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            imgBanner.ImageUrl = QuangCaoService.QuangCao_SelectByTop("1","Position=0","").Rows[0]["Url"].ToString();
        }
    }
}