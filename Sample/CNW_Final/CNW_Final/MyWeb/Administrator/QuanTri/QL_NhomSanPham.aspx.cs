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

public partial class QuanTri_QL_NhomSanPham : System.Web.UI.Page
{
    public static bool Insert;

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["folder"] = "GroupProduct";
       
        BinGrid();
        pnShow.Visible = true;
        pnUpdate.Visible = true;
    }

    public void BinGrid()
    {
        grdGroupProduct.DataSource = GroupProductService.db.GroupProduct_SelectByAll();
        grdGroupProduct.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdGroupProduct_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        GroupProductInfo obj = new GroupProductInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = GroupProductService.db.GroupProduct_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            Session["upload"] = dt.Rows[0]["Images"].ToString();
            txtContent.Text = dt.Rows[0]["Content"].ToString();
            txtOrder.Text = dt.Rows[0]["Order"].ToString();
            txtStatus.Text = dt.Rows[0]["Status"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {
            GroupProductService.db.GroupProduct_Delete(id);
            BinGrid();
        }
    }
    public void DisLayInput(bool c)
    {
        txtName.Enabled = c;
        txtContent.Enabled = c;
        txtOrder.Enabled = c;
        txtStatus.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtName.Text.Equals("") || txtContent.Text.Equals("") || txtStatus.Text.Equals("") || txtOrder.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new GroupProductInfo();
            obj.ID = txtID.Text;
            obj.Name = txtName.Text;
            obj.Content = txtContent.Text;
            obj.Images = (string)Session["upload"];
            obj.Order = txtStatus.Text;
            obj.status = txtOrder.Text;
            if (Insert)
                GroupProductService.db.GroupProduct_Insert(obj);
            else
                GroupProductService.db.GroupProduct_Update(obj);
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
    protected void grdGroupProduct_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdGroupProduct.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
}