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

public partial class QuanTri_QL_QuangCao : System.Web.UI.Page
{
    public static bool Insert;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["folder"] = "Advertise";
            BinGrid();
        }
    }
    public void BinGrid()
    {
        grdQuangCao.DataSource = QuangCaoService.db.QuangCao_SelectByAll();
        grdQuangCao.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdQuangCao_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        QuangCaoInfo obj = new QuangCaoInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = QuangCaoService.db.QuangCao_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            Session["upload"] = dt.Rows[0]["Url"].ToString();
            txtWidth.Text = dt.Rows[0]["Width"].ToString();
            txtHeight.Text = dt.Rows[0]["Height"].ToString();
            txtLink.Text = dt.Rows[0]["Link"].ToString();
            txtTagert.Text = dt.Rows[0]["Tagert"].ToString();
            Ddlposition.SelectedValue = dt.Rows[0]["Position"].ToString();
            txtOrder.Text = dt.Rows[0]["Order"].ToString();
            DdlStatus.SelectedValue = dt.Rows[0]["Status"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {

            QuangCaoService.db.QuangCao_Delete(id);
            BinGrid();
        }
    }
    public void DisLayInput(bool c)
    {
        txtName.Enabled = c;
        //txtUrl.Enabled = c;
        txtWidth.Enabled = c;
        txtHeight.Enabled = c;
        txtLink.Enabled = c;
        Ddlposition.Enabled = c;
        txtOrder.Enabled = c;
        DdlStatus.Enabled = c;
        txtTagert.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtName.Text.Equals("") || txtWidth.Text.Equals("") || txtHeight.Text.Equals("")
            || txtLink.Text.Equals("") || txtOrder.Text.Equals("") || txtTagert.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new QuangCaoInfo();
            obj.ID = txtID.Text;
            obj.Name = txtName.Text;
            obj.Url = (string)Session["upload"];
            obj.Width = txtWidth.Text;
            obj.Height = txtHeight.Text;
            obj.Link = txtLink.Text;
            obj.Tagert = txtTagert.Text;
            obj.Position = Ddlposition.SelectedValue;
            obj.Order = txtOrder.Text;
            obj.Status = DdlStatus.SelectedValue;
            if (Insert)
            {
                //WebMsgBox.Show(obj.Url);
                QuangCaoService.db.QuangCao_Insert(obj);
            }
            else
            {
                QuangCaoService.db.QuangCao_Update(obj);
            }

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
    protected void grdQuangCao_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdQuangCao.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
    protected void grdQuangCao_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}