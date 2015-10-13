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

public partial class QuanTri_QL_SanPham : System.Web.UI.Page
{
    public static bool Insert;
    ConnectDB db=new ConnectDB();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["folder"] = "Product";
            BinGrid();
            pnShow.Visible = true;
            pnUpdate.Visible = true;
            GetNhomSanPham();
        }
    }

    public void BinGrid()
    {
        grdProduct.DataSource = ProductService.db.Product_SelectByAll();
        grdProduct.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdProduct_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        ProductInfo obj = new ProductInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = ProductService.db.Product_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtDetail.Text = dt.Rows[0]["Detail"].ToString();
            txtPrice.Text = dt.Rows[0]["Price"].ToString();
            Session["upload"] = dt.Rows[0]["Images"].ToString();
            txtPrice_new.Text = dt.Rows[0]["Price_new"].ToString();
            txtDate.Text = dt.Rows[0]["Date"].ToString();
            txtOrder.Text = dt.Rows[0]["Order"].ToString();
            ddlIdNhom.SelectedValue = dt.Rows[0]["GroupProductID"].ToString();
            DdlStatus.SelectedValue = dt.Rows[0]["Status"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {

            ProductService.db.Product_Delete(id);
            BinGrid();
        }
    }
    public void DisLayInput(bool c)
    {
        txtName.Enabled = c;
        txtDetail.Enabled = c;
        txtDate.Enabled = c;
        txtPrice.Enabled = c;
        txtPrice_new.Enabled = c;
        txtOrder.Enabled = c;
        DdlStatus.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtName.Text.Equals("") || txtDetail.Text.Equals("") || txtDate.Text.Equals("") || txtPrice.Text.Equals("")
            || txtPrice_new.Text.Equals("") || txtOrder.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new ProductInfo();
            obj.ID = txtID.Text;
            obj.Name = txtName.Text;
            obj.Detail = txtDetail.Text;
            obj.Price = txtPrice.Text;
            obj.Images = (string)Session["upload"];
            obj.Price_new = txtPrice_new.Text;
            obj.Order = txtOrder.Text;
            obj.GroupProductID = ddlIdNhom.SelectedValue.ToString();
            obj.Status = DdlStatus.SelectedValue.ToString();
            if (Insert)
                ProductService.db.Product_Insert(obj);
            else
                ProductService.db.Product_Update(obj);
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
    protected void grdProduct_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdProduct.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
    public void GetNhomSanPham()
    {
        string strselect = "select ID,Name from [dbo].[GroupProduct]";      
        SqlDataAdapter da = new SqlDataAdapter(strselect, ConnectDB.connect);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ddlIdNhom.DataSource = ds;
        ddlIdNhom.DataValueField = "ID";
        ddlIdNhom.DataTextField = "Name";       
        ddlIdNhom.DataBind();
    }
    protected void ddlIdNhom_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}