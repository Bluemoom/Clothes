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
        public Order(Bag _bag,Customer _customer,string _date)
        {
            this.bag = _bag;
            this.customer = _customer;
            this.date = _date;


            //Thêm Order vào CSDL
            //Thêm OrderDetail vào CSDL

            ConnectDB db = new ConnectDB();
            SqlParameter[] a = new SqlParameter[3];
            foreach(Clothes item in _bag.listClothes)
            {
                //a[0] = new SqlParameter("@Order_ID", _customer.id);
                //a[1] = new SqlParameter("@ProductID", data.ProductID);
                //a[2] = new SqlParameter("@Quatity", data.Quatity);
                //return ExecuteCommand("Order_Detail_Insert", a); 
            }

        }

        public void printOrder()
        { }
    }
}
