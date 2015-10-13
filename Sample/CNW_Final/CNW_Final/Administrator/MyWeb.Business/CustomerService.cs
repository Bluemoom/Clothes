using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWeb.Data;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Business
{
    public class CustomerService
    {
        public static CustomerController db = new CustomerController();

        #region[Customer_Insert]
        public int Customer_Insert(CustomerInfo data)
        {
            return db.Customer_Insert(data);
        }
        #endregion

        #region[Customer_Update]
        public int Customer_Update(CustomerInfo data)
        {
            return db.Customer_Update(data);
        }
        #endregion


        #region[Customer_Delete]
        public int Customer_Delere(string ID)
        {
            return db.Customer_Delete(ID);
        }
        #endregion


        #region[Customer_SelectByID]
        public DataTable Customer_SelectByID(string ID)
        {
            return db.Customer_SelectByID(ID);
        }
        #endregion


        #region[Customer_SelectByAll]
        public DataTable Customer_SelectByAll()
        {
            return db.Customer_SelectByAll();
        }
        #endregion


        #region[Customer_SelectByTop]
        public DataTable Customer_SelectByTop(string Top,string Where,String Order)
        {
            return db.Customer_SelectByTop(Top, Where, Order);
        }
        #endregion

        public string Customer_Getname(int id)
        {
            return db.Customer_GetName(id);
        }

        public int Customer_CheckLogin(string username,string password)
        {
            return db.Customer_CheckLogin(username, password);
        }
        public int Customer_ChangePassword(string NewPass,string id)
        {
            return db.Customer_ChangePassword(NewPass, id);
        }
    }
}