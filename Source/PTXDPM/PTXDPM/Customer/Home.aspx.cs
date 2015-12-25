using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.Customer
{
    public partial class Home : System.Web.UI.Page
    {
        OrderControl orderControl = new OrderControl();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["state"];
            if(ID!=null)
            {
                Session["Customer"] = null;
            }
            if (!IsPostBack)
            {
                dlGroupCloth.DataSource = orderControl.ShowGroup(6);
                dlGroupCloth.DataBind();
                dlCloth.DataSource = orderControl.ShowNewCloth(8);
                dlCloth.DataBind();
            }
            Session["OrderControl"] = orderControl;
        }
    }
}