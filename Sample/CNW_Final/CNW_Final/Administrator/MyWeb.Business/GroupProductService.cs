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
    public class GroupProductService
    {
        public static GroupProductController db = new GroupProductController();

        #region[GroupProduct_Insert]
        public int GroupProduct_Insert(GroupProductInfo data)
        {
            return db.GroupProduct_Insert(data);
        }
        #endregion

        #region[GroupProduct_Update]
        public int GroupProduct_Update(GroupProductInfo data)
        {
            return db.GroupProduct_Update(data);
        }
        #endregion


        #region[GroupProduct_Delete]
        public int GroupProduct_Delere(string ID)
        {
            return db.GroupProduct_Delete(ID);
        }
        #endregion


        #region[GroupProduct_SelectByID]
        public DataTable GroupProduct_SelectByID(string ID)
        {
            return db.GroupProduct_SelectByID(ID);
        }
        #endregion


        #region[GroupProduct_SelectByAll]
        public DataTable GroupProduct_SelectByAll()
        {
            return db.GroupProduct_SelectByAll();
        }
        #endregion


        #region[GroupProduct_SelectByTop]
        public DataTable GroupProduct_SelectByTop(string Top, string Where, String Order)
        {
            return db.GroupProduct_SelectByTop(Top, Where, Order);
        }
        #endregion



    }
}