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
                orderClothesUI.bag.caculatorTotalPrice();
                lbTongTien.Text = orderClothesUI.bag.totalPrice.ToString() +" VNĐ";
                showBagDetail();
            }
        }

        protected void grdGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Data.Bag bag = (Data.Bag)Session["Bag"];
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "CapNhat")
            {              
                string quantity = "";
                // Lấy giá trị số lượng trong ô textbox
                quantity = ((TextBox)(grdGioHang.Rows[index].FindControl("txtQuantity"))).Text;
                // Lấy giá trị mã sản phẩm 
                string clothesID = grdGioHang.Rows[index].Cells[0].Text;
                foreach (Clothes item in bag.listClothes)
                {
                    if (item.ID == clothesID) item.Quantity = quantity;
                    //if (item.ID == clothesID) item.Quantity = (int.Parse(quantity) - 1).ToString();
                }
                Session["Bag"] = bag;
                //Response.Redirect(Request.RawUrl);
                Response.Redirect("BagDetail.aspx");
                showBagDetail();
            }
            if(e.CommandName=="Xoa")
            {
                string clothesID = grdGioHang.Rows[index].Cells[0].Text;
                Clothes temp = null;
                foreach (Clothes item in bag.listClothes)
                {
                    if (item.ID == clothesID) temp = item;
                }
                bag.listClothes.Remove(temp);
                Session["Bag"] = bag;
                //Response.Redirect(Request.RawUrl);
                Response.Redirect("BagDetail.aspx");
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