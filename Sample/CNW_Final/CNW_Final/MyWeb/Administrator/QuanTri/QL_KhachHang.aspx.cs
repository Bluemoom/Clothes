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

public partial class QuanTri_QL_KhachHang : System.Web.UI.Page
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
        grdCustomer.DataSource = CustomerService.db.Customer_SelectByAll();
        grdCustomer.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
        DisLayInput(true);
    }


    protected void grdCustomer_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        DisLayInput(true);
        CustomerInfo obj = new CustomerInfo();
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit")
        {
            Insert = false;
            DataTable dt = CustomerService.db.Customer_SelectByID(id);
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtUserName.Text = dt.Rows[0]["Name"].ToString();
            txtMatKhau.Text = dt.Rows[0]["Password"].ToString();
            txtNgaysinh.Text = dt.Rows[0]["Brithday"].ToString();
            txtTinhThanh.Text = dt.Rows[0]["Provice"].ToString();
            txtDiaChi.Text = dt.Rows[0]["Address"].ToString();
            txtSDT.Text = dt.Rows[0]["Tell"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = true;
        }
        if (e.CommandName == "Delete")
        {

            CustomerService.db.Customer_Delete(id);
            BinGrid();
        }
    }
    public void DisLayInput(bool c)
    {
        txtUserName.Enabled = c;
        txtNgaysinh.Enabled = c;
        txtTinhThanh.Enabled = c;
        txtSDT.Enabled = c;
        txtDiaChi.Enabled = c;
        txtEmail.Enabled = c;
    }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        // Test Input
        if (txtUserName.Text.Equals("") || txtNgaysinh.Text.Equals("") || txtTinhThanh.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSDT.Text.Equals("") || txtEmail.Text.Equals(""))
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        else
        {
            var obj = new CustomerInfo();
            obj.ID = txtID.Text;
            obj.Username = txtUserName.Text;
            obj.Password = txtMatKhau.Text;
            obj.Brithday = txtNgaysinh.Text;
            obj.Provice = txtTinhThanh.Text;
            obj.Address = txtDiaChi.Text;
            obj.Tell = txtSDT.Text;
            obj.Email = txtEmail.Text;
            if (Insert)
                CustomerService.db.Customer_Insert(obj);
            else
                CustomerService.db.Customer_Update(obj);
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
    protected void grdCustomer_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

        grdCustomer.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
}