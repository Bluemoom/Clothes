using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.UseCotrol
{
    public partial class HeadRight : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerName"] != null)
            {

            }
            else
            {

            }

            if (Session["Bag"] == null)
            {
                lbTongTien.Text = "0 VNĐ";
                lbSoLuong.Text = "0 hàng";
            }
            else
            {
                Data.Bag gh = (Data.Bag)Session["Bag"];
                gh.caculatorTotalPrice();
                lbTongTien.Text = (gh.totalPrice).ToString() + " VNĐ";
                lbSoLuong.Text = gh.listClothes.Count().ToString() + " hàng";
            }
        }
    }
}