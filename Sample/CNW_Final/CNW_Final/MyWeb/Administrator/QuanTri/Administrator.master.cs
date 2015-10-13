using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class QuanTri_Administrator : System.Web.UI.MasterPage
{
    private int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if(Session["ID"]!=null)
        //    id=(int)Session["ID"];
        //    Button1.Text=CustomerService.db.Customer_GetName(id);
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
}
