using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order
    {
        public Bag bag { get; set; }
        public Customer customer { get; set; }
        public string date { get; set; }

        public Order() { }

        // Hàm khởi tạo sử dụng để thêm mới đơn đặt hàng
        public Order(Bag _bag, Customer _customer, string _date)
        {
            this.bag = _bag;
            this.customer = _customer;
            this.date = _date;

            ConnectDB db = new ConnectDB();

            //Lấy ID của khách hàng vừa tạo
            string customerID = db.GetData("Select Top 1 ID from [dbo].[Customer] order by ID desc", "ID", "");
            // Sử dụng ID vừa lấy, thêm dữ liệu Order vào CSDL
            SqlParameter[] b = new SqlParameter[4];
            b[0] = new SqlParameter("@CustomerID", customerID);
            b[1] = new SqlParameter("@TotalPrice", bag.totalPrice);
            b[2] = new SqlParameter("@Date", DateTime.Now.ToString("MM/dd/yyyy"));
            b[3] = new SqlParameter("@Status", "1");
            db.ExecuteCommand("Order_Insert", b);

            // Lấy ID của Order vừa thêm vào bên trên
            string orderID = db.GetData("Select Top 1 ID from [dbo].[Order] order by ID desc", "ID", "");
            if (orderID == null) orderID = "1";

            // Sử dụng ID vừa lấy, thêm dữ liệu vào bảng OrderDetail
            SqlParameter[] a = new SqlParameter[3];
            foreach (Cloth item in _bag.listClothes)
            {
                a[0] = new SqlParameter("@OrderID", orderID);
                a[1] = new SqlParameter("@ClothesID", item.id);
                a[2] = new SqlParameter("@Quantity", item.quantity);
                db.ExecuteCommand("OrderDetail_Insert", a);
            }
        }
        public void PrintOrder()
        { }
    }
}
