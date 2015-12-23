using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.Customer
{
    public partial class BagDetail: System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            OrderControl orderControl = (OrderControl)Session["OrderControl"];
            if (!IsPostBack)
            {
                string ID = Request.QueryString["ID"];
                if (Session["Bag"] != null)
                {
                    orderControl.bag =(Bag)Session["Bag"];
                }
                else
                {
                    orderControl.bag = new Bag();
                }
                if (ID != null) orderControl.AddClothToBag(ID);
                Session["Bag"] = orderControl.bag;
                Session["OrderControl"] = orderControl;
                ShowBagDetail();
            }
        }

        protected void grdGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Data.Bag bag = (Data.Bag)Session["Bag"];
            OrderControl orderControl = (OrderControl)Session["OrderControl"];
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "CapNhat")
            {
                string quantity;
                // Lấy giá trị số lượng trong ô textbox
                quantity = ((TextBox)(grdGioHang.Rows[index].FindControl("txtquantity"))).Text;
                Response.Write("<script>alert('Gia tri cua TextBox : " + quantity + "')</script>");
                // Lấy giá trị mã sản phẩm 
                string clothesID = grdGioHang.Rows[index].Cells[0].Text;
                foreach (Cloth item in orderControl.bag.listClothes)
                {
                    if (item.id == clothesID) item.quantity = quantity;
                    //if (item.ID == clothesID) item.Quantity = (int.Parse(quantity) - 1).ToString();
                }
                Session["OrderControl"] = orderControl;
                //Response.Redirect(Request.RawUrl);
                Response.Redirect("BagDetail.aspx");
                ShowBagDetail();
            }
            if (e.CommandName == "Xoa")
            {
                string clothesID = grdGioHang.Rows[index].Cells[0].Text;
                Cloth temp = null;
                foreach (Cloth item in orderControl.bag.listClothes)
                {
                    if (item.id == clothesID) temp = item;
                }
                orderControl.bag.listClothes.Remove(temp);
                Session["OrderControl"] = orderControl;
                //Response.Redirect(Request.RawUrl);
                Response.Redirect("BagDetail.aspx");
                //showBagDetail();
            }
        }
        private void ShowBagDetail()
        {
            OrderControl orderControl = (OrderControl)Session["OrderControl"];
            orderControl.bag.CaculatorTotalPrice();
            lbTongTien.Text = orderControl.bag.totalPrice.ToString() + " VNĐ";
            grdGioHang.DataSource = orderControl.ShowBagDetail();
            grdGioHang.DataBind();
        }
    }
}