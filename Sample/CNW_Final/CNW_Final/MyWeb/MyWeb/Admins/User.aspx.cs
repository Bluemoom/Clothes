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

public partial class Admins_User : System.Web.UI.Page
{
    public static bool Insert;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void BinGrid()
    {
        grdUser.DataSource = UserService.db.User_GetByAll();
        grdUser.DataBind();
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        pnUpdate.Visible = true;
        pnShow.Visible = false;
        ControlClass.ResetControlValues(pnUpdate);
        Insert = true;
    }
    protected void grdUser_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        UserInfo obj = new UserInfo();
        string id = e.CommandArgument.ToString();
        if(e.CommandName=="Edit")
        {
            Insert = false;
            DataTable dt = UserService.db.User_GetByID(id);
            txtUserName.Text = dt.Rows[0]["UserName"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtMatKhau.Text = dt.Rows[0]["password"].ToString();
            DdlRole.SelectedValue = dt.Rows[0]["Rule"].ToString();
            DdlStatus.SelectedValue = dt.Rows[0]["Status"].ToString();
            pnUpdate.Visible = true;
            pnShow.Visible = false;
        }
        else
        {
            UserService.db.User_Delete(id);
            BinGrid();
    }
        }
    protected void lbtUpdate_Click(object sender, EventArgs e)
    {
        #region[Test Input]
        if (txtUserName.Text.Trim().Equals("")) 
        {
            WebMsgBox.Show("Bạn chưa nhập tên đăng nhập");
            txtUserName.Focus();
            return;
        }
        if (txtMatKhau.Text.Trim().Equals(""))
        {
            WebMsgBox.Show("Bạn chưa nhập mật khẩu");
            txtMatKhau.Focus();
            return;
        }
        #endregion
        var obj = new UserInfo();
        obj.Name = txtName.Text;
        obj.UserName = txtUserName.Text;
        obj.Password = txtMatKhau.Text;
        obj.Rule = DdlRole.SelectedValue;
        obj.Status = DdlStatus.SelectedValue;
        if (Insert)
            UserService.db.User_Insert(obj);
        else
            UserService.db.User_Update(obj);
        BinGrid();
        pnUpdate.Visible = false;
        pnShow.Visible = true;
        ControlClass.ResetControlValues(pnUpdate);
        
    }
    protected void lbtBack_Click(object sender, EventArgs e)
    {
        pnShow.Visible = true;
        pnUpdate.Visible = false;
    }
    protected void grdUser_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {
        grdUser.CurrentPageIndex = e.NewPageIndex;
        BinGrid();
    }
}