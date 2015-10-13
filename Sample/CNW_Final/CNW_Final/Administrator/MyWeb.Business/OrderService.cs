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
    public class OrderService
    {
        public static OrderController db = new OrderController();

        #region[Order_Insert]
        public int Order_Insert(OrderInfo data)
        {
            return db.Order_Insert(data);
        }
        #endregion

        #region[Order_Update]
        public int Order_Update(OrderInfo data)
        {
            return db.Order_Update(data);
        }
        #endregion


        #region[Order_Delete]
        public int Order_Delere(string ID)
        {
            return db.Order_Delete(ID);
        }
        #endregion


        #region[Order_SelectByID]
        public DataTable Order_SelectByID(string ID)
        {
            return db.Order_SelectByID(ID);
        }
        #endregion


        #region[Order_SelectByAll]
        public DataTable Order_SelectByAll()
        {
            return db.Order_SelectByAll();
        }
        #endregion


        #region[Order_SelectByTop]
        public DataTable Order_SelectByTop(string Top, string Where, String Order)
        {
            return db.Order_SelectByTop(Top, Where, Order);
        }
        #endregion

        public int Order_GetId(int CustomerID)
        {
            return db.Order_GetId(CustomerID);
        }

    }
}