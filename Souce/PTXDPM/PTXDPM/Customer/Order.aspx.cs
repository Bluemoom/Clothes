using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.Customer
{
    public partial class Order : System.Web.UI.Page
    {
        OrderClothesUI order = new OrderClothesUI();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            if (Session["Bag"] != null)
            {
                order.bag = (Data.Bag)Session["Bag"];
            }
            else
            {
            }

            if (Session["Customer"] != null) order.customer = (Data.Customer)Session["Customer"];
            else
                order.customer = new Data.Customer(txtHoTen.Text, txtEmail.Text, txtDiaChi.Text, txtSĐT.Text);
            order.order = new Data.Order(order.bag, order.customer, DateTime.Now.ToString());
            Session["Bag"] = null;
            Response.Redirect("FinishOrder.aspx");
        }
    }
}