using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.UseCotrol
{
    public partial class Bag : System.Web.UI.UserControl
    {
        private OrderClothesUI orderClothesUI = new OrderClothesUI();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["ID"];
            if (!IsPostBack)
            {
                if (Session["Bag"] != null)
                {
                    orderClothesUI.bag = (Data.Bag)Session["Bag"]; 
                }
                else
                {
                    orderClothesUI.bag = new Data.Bag();
                }
                if (ID != null) orderClothesUI.addClothesToBag(ID);
                Session["Bag"] = orderClothesUI.bag;
                showBagDetail();
            }
        }
        private void showBagDetail()
        {
            grdGioHang.DataSource = orderClothesUI.showBagDetail();
            grdGioHang.DataBind();
        }
    }
}