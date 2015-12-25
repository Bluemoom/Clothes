﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
namespace PTXDPM.Customer
{
    public partial class Register : System.Web.UI.Page
    {
        Data.Customer customer = new Data.Customer();
        protected void Page_Load(object sender, EventArgs e)
        {  
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            if(customer.CheckUsename(txtTenDangNhap.Text)>0)
            {
                ClientScript.RegisterClientScriptBlock(this.ClientScript.GetType(), "", "<script language='javascript'>alert('Tên đăng nhập đã tồn tại vui lòng chọn tên khác ');</script>");
            }
            else if(txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text)==false)
            {
                ClientScript.RegisterClientScriptBlock(this.ClientScript.GetType(), "", "<script language='javascript'>alert('Mật khẩu không khớp');</script>");
            }
            else
            {
                customer.CreateCustomer(txtHoTen.Text, txtEmail.Text, txtDiaChi.Text, txtSĐT.Text, txtTenDangNhap.Text, txtMatKhau.Text);
                ClientScript.RegisterClientScriptBlock(this.ClientScript.GetType(), "", "<script language='javascript'>alert('Đăng ký thành công, vui lòng đăng nhập hoặc quay lại trang chủ');</script>");
            }
        }
    }
}