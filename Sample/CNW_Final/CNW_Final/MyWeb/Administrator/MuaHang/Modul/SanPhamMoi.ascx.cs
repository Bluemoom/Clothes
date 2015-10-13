using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class MuaHang_Modul_SanPhamMoi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            listproduct.DataSource = QuangCaoService.db.QuangCao_SelectByTop("3", "[Position]=3", "[Order] Desc");
            listproduct.DataBind();
        }
    }

    protected void listproduct_ItemCommand(object source, DataListCommandEventArgs e)
    {

    }
    protected void listproduct_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}