using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.UseCotrol
{
    public partial class DetailClothes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderClothesUI orderClothesUI = new OrderClothesUI();
            string ID = Request.QueryString["ID"];
            if (!IsPostBack)
            {
                ConnectDB db = new ConnectDB();
                DLChiTiet.DataSource = orderClothesUI.showClothesByID(ID.ToString());
                DLChiTiet.DataBind();
            }
        }
    }
}