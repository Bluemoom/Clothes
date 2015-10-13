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
    public class ProductService
    {
        public static ProductController db = new ProductController();

        #region[Product_Insert]
        public int Product_Insert(ProductInfo data)
        {
            return db.Product_Insert(data);
        }
        #endregion

        #region[Product_Update]
        public int Product_Update(ProductInfo data)
        {
            return db.Product_Update(data);
        }
        #endregion


        #region[Product_Delete]
        public int Product_Delere(string ID)
        {
            return db.Product_Delete(ID);
        }
        #endregion


        #region[Product_SelectByID]
        public DataTable Product_SelectByID(string ID)
        {
            return db.Product_SelectByID(ID);
        }
        #endregion


        #region[Product_SelectByAll]
        public DataTable Product_SelectByAll()
        {
            return db.Product_SelectByAll();
        }
        #endregion


        #region[Product_SelectByTop]
        public DataTable Product_SelectByTop(string Top, string Where, String Order)
        {
            return db.Product_SelectByTop(Top, Where, Order);
        }
        #endregion



    }
}