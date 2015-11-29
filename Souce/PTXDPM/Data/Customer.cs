using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Customer(string _name,string _email,string _address,string _phoneNumber,string _userName,string _password)
        {
            this.name = _name;
            this.email = _email;
            this.address = _address;
            this.phoneNumber = _phoneNumber;
            this.userName = _userName;
            this.passWord = _password;
        }

        public Customer(string _name, string _email, string _address, string _phoneNumber)
        {
            this.name = _name;
            this.email = _email;
            this.address = _address;
            this.phoneNumber = _phoneNumber;
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

        public int editCustomer(string _name,string _address,string _password)
        {
            return 1;
        }

        public int delete(string _id)
        {
            return 1;
        }



    }
}
