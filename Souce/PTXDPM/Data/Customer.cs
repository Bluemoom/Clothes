using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Data
{
    public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }

        public Customer() { }
        public Customer(string _name, string _email, string _address, string _phoneNumber, string _userName, string _password)
        {
            this.name = _name;
            this.email = _email;
            this.address = _address;
            this.phoneNumber = _phoneNumber;
            this.userName = _userName;
            this.passWord = _password;
        }

        // Hàm khởi tạo cho trường hợp khách hàng không đăng ký tài khoản
        public Customer(string _name, string _email, string _address, string _phoneNumber)
        {
            this.name = _name;
            this.email = _email;
            this.address = _address;
            this.phoneNumber = _phoneNumber;

            //Thêm mới Customer vào CSDL
            ConnectDB db = new ConnectDB();
            SqlParameter[] a = new SqlParameter[6];
            a[0] = new SqlParameter("@Name", _name);
            a[1] = new SqlParameter("@Email", _email);
            a[2] = new SqlParameter("@Address", _address);
            a[3] = new SqlParameter("@PhoneNumber", _name);
            a[4] = new SqlParameter("@UserName", _email);
            a[5] = new SqlParameter("@Password", "CrazyClothes");
            db.ExecuteCommand("Customer_Insert", a);
        }

        public int checkLogin()
        {
            int result = 0;
            return result;
        }

        public string getCustomerID()
        {
            string a = "";
            return a;
        }

        public string getCustomerName()
        {
            string a = "";
            return a;
        }

        public int editCustomer(string _name, string _address, string _password)
        {
            return 1;
        }
    }
}
