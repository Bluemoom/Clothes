using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;
using MyWeb.Data;
using MyWeb.Common;

public partial class KhachHang_Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["giohang"] == null)
            {
                LiteralTongtien.Text = "Ban chua mua hang";
                return;
            }
            GetDuLieu();
        }
    }
    protected void grdGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "CapNhat")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GioHangMua gh = (GioHangMua)Session["giohang"];
            int sl = Int32.Parse(((TextBox)(grdGioHang.Rows[index].FindControl("TextBox1"))).Text);
            HangHoa hh = new HangHoa(Convert.ToInt32(grdGioHang.Rows[index].Cells[0].Text), sl);
            hh.name = gh.GetName(hh.id);
            gh.UpdateHangHoa(hh);
            Session["giohang"] = gh;
            Response.Redirect(Request.RawUrl);
            GetDuLieu();
        }
    }
    protected void btnDatHang_Click(object sender, EventArgs e)
    {
        if (Session["IdCustomer"] == null)
        {
            Response.Redirect("LoiDatHang.aspx");
        }
        else
        {
            GioHangMua gh = (GioHangMua)Session["giohang"];
            if (gh.GetSoLuong() == 0)
                WebMsgBox.Show("Không có hàng hóa trong giỏ hàng, vui lòng mua hàng để giao dịch");
            else
            {
                int CustomerID = (int)Session["IdCustomer"];
                var obj = new OrderInfo();
                obj.Customer_ID = CustomerID.ToString();
                obj.Totalmoney = gh.GetTongTien().ToString();
                obj.Status = "1";
                int i = OrderService.db.Order_Insert(obj);
                int OrderID = OrderService.db.Order_GetId(CustomerID);
                int kt = gh.CreateOrderDetail(OrderID.ToString());
                if (kt > 0)
                    Response.Redirect("DatHangThanhCong.aspx");
                
            }
        }
    }
    public void GetDuLieu()
    {
        GioHangMua gh = new GioHangMua();
        gh = (GioHangMua)Session["giohang"];
        grdGioHang.DataSource = gh.returnTable();
        grdGioHang.DataBind();
        LiteralTongtien.Text = "Tổng tiền: " + gh.GetTongTien().ToString() + " VND";
    }
}