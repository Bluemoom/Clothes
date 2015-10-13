using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;
using MyWeb.Common;
using MyWeb.Data;
using System.Data;
using System.Data.SqlClient;

public partial class QuanTri_QL_ChiTietHoaDon : System.Web.UI.Page
{
    public static bool Insert;

    protected void Page_Load(object sender, EventArgs e)
    {
        DisLayInput(false);
        BinGrid();
        pnShow.Visible = true;
        pnUpdate.Visible = true;
    }

    public void BinGrid()
    {
        grdOrderDetail.DataSource = Order_DetailService.db.Order_Detail_SelectByAll();
        grdOrderDetail.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdOrderDetail_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        Order_DetailInfo obj = new Order_DetailInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = Order_DetailService.db.Order_Detail_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtOrder_ID.Text = dt.Rows[0]["Order_ID"].ToString();
            txtProductID.Text = dt.Rows[0]["ProductID"].ToString();
            txtQuatity.Text = dt.Rows[0]["Quatity"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {

            Order_DetailService.db.Order_Detail_Delete(id);
            BinGrid();
        }
    }
    public void DisLayInput(bool c)
    {
        txtOrder_ID.Enabled = c;
        txtProductID.Enabled = c;
        txtQuatity.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtOrder_ID.Text.Equals("") || txtProductID.Text.Equals("") || txtQuatity.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new Order_DetailInfo();
            obj.ID = txtID.Text;
            obj.Order_ID = txtOrder_ID.Text;
            obj.ProductID = txtProductID.Text;
            obj.Quatity = txtQuatity.Text;
            if (Insert)
                Order_DetailService.db.Order_Detail_Insert(obj);
            else
                Order_DetailService.db.Order_Detail_Update(obj);
            BinGrid();
            ControlClass.ResetControlValues(pnUpdate);
            DisLayInput(false);
        }

    }
    protected void lbtBack_Click(object sender, EventArgs e)
    {

        pnShow.Visible = true;
        pnUpdate.Visible = true;
    }
    protected void grdOrderDetail_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdOrderDetail.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
}