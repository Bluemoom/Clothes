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

public partial class QuanTri_QL_Menu : System.Web.UI.Page
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
        grdMenu.DataSource = MenuService.db.Menu_SelectByAll();
        grdMenu.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdMenu_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        MenuInfo obj = new MenuInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = MenuService.db.Menu_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtLink.Text = dt.Rows[0]["Link"].ToString();
            txtOrder.Text = dt.Rows[0]["Order"].ToString();
            txtParentID.Text = dt.Rows[0]["ParentID"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {
            MenuService.db.Menu_Delete(id);
            BinGrid();
        }
    }
    public void DisLayInput(bool c)
    {
        txtName.Enabled = c;
        txtLink.Enabled = c;
        txtOrder.Enabled = c;
        txtParentID.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtName.Text.Equals("") || txtLink.Text.Equals("") || txtOrder.Text.Equals("") || txtParentID.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new MenuInfo();
            obj.ID = txtID.Text;
            obj.Name = txtName.Text;
            obj.Link = txtLink.Text;
            obj.Order = txtOrder.Text;
            obj.ParentID = txtParentID.Text;
            if (Insert)
                MenuService.db.Menu_Insert(obj);
            else
                MenuService.db.Menu_Update(obj);
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
    protected void grdMenu_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdMenu.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
}