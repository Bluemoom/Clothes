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
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            OrderControl orderControl = (OrderControl)Session["OrderControl"];
            if (orderControl.bag== null)
            {
                //Thông báo chưa mua hàng
            }
            else
            {
            }

            if (Session["Customer"] != null) orderControl.customer = (Data.Customer)Session["Customer"];
            else
                orderControl.customer = new Data.Customer(txtHoTen.Text, txtEmail.Text, txtDiaChi.Text, txtSĐT.Text);
            orderControl.order = new Data.Order(orderControl.bag, orderControl.customer, DateTime.Now.ToString());
            Session["Bag"] = null;
            Response.Redirect("FinishOrder.aspx");
        }
    }
}