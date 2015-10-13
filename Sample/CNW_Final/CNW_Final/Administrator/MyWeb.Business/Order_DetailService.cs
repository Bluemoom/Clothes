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
    public class Order_DetailService
    {
        public static Order_Detail_DetailController db = new Order_Detail_DetailController();

        #region[Order_Detail_Insert]
        public int Order_Detail_Insert(Order_DetailInfo data)
        {
            return db.Order_Detail_Insert(data);
        }
        #endregion

        #region[Order_Detail_Update]
        public int Order_Detail_Update(Order_DetailInfo data)
        {
            return db.Order_Detail_Update(data);
        }
        #endregion


        #region[Order_Detail_Delete]
        public int Order_Detail_Delere(string ID)
        {
            return db.Order_Detail_Delete(ID);
        }
        #endregion


        #region[Order_Detail_SelectByID]
        public DataTable Order_Detail_SelectByID(string ID)
        {
            return db.Order_Detail_SelectByID(ID);
        }
        #endregion


        #region[Order_Detail_SelectByAll]
        public DataTable Order_Detail_SelectByAll()
        {
            return db.Order_Detail_SelectByAll();
        }
        #endregion


        #region[Order_Detail_SelectByTop]
        public DataTable Order_Detail_SelectByTop(string Top, string Where, String Order_Detail)
        {
            return db.Order_Detail_SelectByTop(Top, Where, Order_Detail);
        }
        #endregion



    }
}