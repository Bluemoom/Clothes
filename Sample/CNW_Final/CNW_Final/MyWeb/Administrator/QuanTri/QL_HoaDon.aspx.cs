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

public partial class QuanTri_QL_HoaDon : System.Web.UI.Page
{
    public static bool Insert;
    ConnectDB db = new ConnectDB();
    //public static string IdOrder;
    //public static string IdCustomer;
    protected void Page_Load(object sender, EventArgs e)
    {
        DisLayInput(false);
        BinGrid();
        pnShow.Visible = true;
        pnUpdate.Visible = true;
        PnCustomerDetail.Visible = false;
        PnOrderDetail.Visible = false;
    }

    public void BinGrid()
    {
        grdOrder.DataSource = OrderService.db.Order_SelectByAll();
        grdOrder.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdOrder_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        OrderInfo obj = new OrderInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = OrderService.db.Order_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtCustomer_ID.Text = dt.Rows[0]["Customer_ID"].ToString();
            txtTotalmoney.Text = dt.Rows[0]["Totalmoney"].ToString();
            txtDate.Text = dt.Rows[0]["Date"].ToString();
            txtStatus.Text = dt.Rows[0]["Status"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {

            OrderService.db.Order_Delete(id);
            BinGrid();
        }
        if (e.CommandName == "ViewOrderDetail")
        {
            int IdCustomer = int.Parse(db.GetData("SELECT Customer_ID FROM [Order] WHERE ID= ", "Customer_ID", id.ToString()));
            //IdOrder = id;
            grdOrderDetail.DataSource = Order_DetailService.db.Order_Detail_SelectByTop("", " Order_ID="+id+"", "");
            grdOrderDetail.DataBind();
            PnOrderDetail.Visible = true;
            grdCustomer.DataSource = CustomerService.db.Customer_SelectByTop("", " ID=" + IdCustomer + "", "");
            grdCustomer.DataBind();
            PnCustomerDetail.Visible = true;
        }
        //if (e.CommandName == "ViewCustomerDetail")
        //{
        //    WebMsgBox.Show(id);
            
        //    //IdCustomer = id;
        //    grdCustomer.DataSource = CustomerService.db.Customer_SelectByTop("", " ID="+id+"", "");
        //    grdCustomer.DataBind();
        //    PnCustomerDetail.Visible = true;
        //}

    }
    public void DisLayInput(bool c)
    {
        txtCustomer_ID.Enabled = c;
        txtTotalmoney.Enabled = c;
        txtDate.Enabled = c;
        txtStatus.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtCustomer_ID.Text.Equals("") || txtTotalmoney.Text.Equals("") || txtDate.Text.Equals("") || txtStatus.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new OrderInfo();
            obj.ID = txtID.Text;
            obj.Customer_ID = txtCustomer_ID.Text;
            obj.Totalmoney = txtTotalmoney.Text;
            obj.Date = txtDate.Text;
            obj.Status = txtStatus.Text;
            if (Insert)
                OrderService.db.Order_Insert(obj);
            else
                OrderService.db.Order_Update(obj);
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
    protected void grdOrder_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdOrder.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
    protected void grdCustomer_ItemCommand(object source, DataGridCommandEventArgs e)
    {

    }
    protected void grdCustomer_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

    }
    protected void grdOrderDetail_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

    }
    protected void grdOrderDetail_ItemCommand(object source, DataGridCommandEventArgs e)
    {

    }
}