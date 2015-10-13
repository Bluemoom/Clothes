using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;
using MyWeb.Common;
using MyWeb.Data;

public partial class KhachHang_DoiMatKhau : System.Web.UI.Page
{
    ConnectDB db = new ConnectDB();
    int ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = (int)Session["IdCustomer"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!KiemTraLoi().Equals(""))
            WebMsgBox.Show(KiemTraLoi());
        else
        {
            int kt = CustomerService.db.Customer_ChangePassword(txtMatKhauMoi1.Text, ID.ToString());
            if (kt > 0) WebMsgBox.Show("Thanh Cong");
        }
    }
    public string KiemTraLoi()
    {
        string Loi1 = "";
        string Loi2 = "";
        string Loi3 = "";
        string Loi4 = "";
        string Loi = "";
        string pass = db.GetData("SELECT [Password] FROM [dbo].[Customer] WHERE ID= ", "Password", ID.ToString());
        if (txtMatKhauCu.Text.Equals("") || txtMatKhauMoi1.Text.Equals("") || txtMatKhauMoi2.Text.Equals(""))
            Loi3 = "Bạn chưa nhập đủ thông tin";
        else if (!pass.Equals(txtMatKhauCu.Text))
            Loi1 = "Mật khẩu hiện tại không đúng";
        else if (!txtMatKhauMoi1.Text.Equals(txtMatKhauMoi2.Text))
            Loi2 = "Mật khẩu mới nhập lại không đúng";
        else if (pass.Equals(txtMatKhauMoi1.Text))
            Loi4 = "Mật khẩu mới và mật khẩu cũ không được trùng nhau";
        else Loi = "";
        Loi = Loi3 + Loi1 + Loi4 + Loi2 ;
        return Loi;
    }
}