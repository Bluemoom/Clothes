using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Common;
using MyWeb.Business;
using MyWeb.Data;

public partial class MuaHang_Modul_DangKy : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbThongBao.Visible = false;
        hlDangNhap.Visible = false;
        hlVeTrangChu.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Equals("") || txtMatKhau.Text.Equals("") || txtNgaySinh.Text.Equals("") || txtTinhThanh.Text.Equals("") || txtSoDienThoai.Text.Equals("") || txtEmail.Text.Equals(""))
        {
            WebMsgBox.Show("Chưa nhập đủ thông tin");
        }
        else
        {
            try
            {
                var obj = new CustomerInfo();
                obj.Username = txtName.Text;
                obj.Password = txtMatKhau.Text;
                obj.Brithday = txtNgaySinh.Text;
                obj.Provice = txtTinhThanh.Text;
                obj.Address = txtDiaChi.Text;
                obj.Tell = txtSoDienThoai.Text;
                obj.Email = txtEmail.Text;
                int i = CustomerService.db.Customer_Insert(obj);
                if (i > 0) lbThongBao.Text = "Đăng kí thành công! Lựa chọn: ";
                lbThongBao.Visible = true;
                hlVeTrangChu.Visible = true;
                hlDangNhap.Visible = true;  
            }
            catch (Exception ex)
            {
                WebMsgBox.Show(ex.ToString());
            }
        }
    }
}