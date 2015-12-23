using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.UseCotrol
{
    public partial class hRight : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["Bag"] == null)
                {
                    lbTongTien.Text = "0 VND";
                    lbSoLuong.Text = "0 hang";
                }
                else
                {
                    Bag bag = new Bag();
                    bag = (Bag)Session["Bag"];
                    bag.CaculatorTotalPrice();
                    lbTongTien.Text = bag.totalPrice.ToString();
                    lbSoLuong.Text = bag.listClothes.Count().ToString();
                }
            }
        }
    }
}