using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class ProductController : ConnectDB
    {

        #region[Product_Insert]
        public int Product_Insert(ProductInfo data)
        {
            SqlParameter[] a = new SqlParameter[9];
            a[0] = new SqlParameter("@Name", data.Name);
            a[1] = new SqlParameter("@Detail", data.Detail);
            a[2] = new SqlParameter("@Price", data.Price);
            a[3] = new SqlParameter("@Images", data.Images);
            a[4] = new SqlParameter("@Price_new", data.Price_new);
            a[5] = new SqlParameter("@Date", data.Date);
            a[6] = new SqlParameter("@Order", data.Order);
            a[7] = new SqlParameter("@GroupProductID",data.GroupProductID);
            a[8] = new SqlParameter("@Status",data.Status);
            return ExecuteCommand("Product_Insert", a); ;
        }
        #endregion

        #region[Product_Update]
        public int Product_Update(ProductInfo data)
        {
            SqlParameter[] a = new SqlParameter[10];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Name", data.Name);
            a[2] = new SqlParameter("@Detail", data.Detail);
            a[3] = new SqlParameter("@Price", data.Price);
            a[4] = new SqlParameter("@Images", data.Images);
            a[5] = new SqlParameter("@Price_new", data.Price_new);
            a[6] = new SqlParameter("@Date", data.Date);
            a[7] = new SqlParameter("@Order", data.Order);
            a[8] = new SqlParameter("@GroupProductID", data.GroupProductID);
            a[9] = new SqlParameter("@Status", data.Status);
            return ExecuteCommand("Product_Update", a);
        }
        #endregion

        #region[Product_Delete]
        public int Product_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("Product_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("Product_Delete", a);

        }
        #endregion

        #region[Product_SelectByAll]
        public DataTable Product_SelectByAll()
        {
            return ReturnDataTable_NonParameter("Product_SelectByAll");
        }
        #endregion

        #region[Product_SelectByID]
        public DataTable Product_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("Product_SelectByID", a);
        }
        #endregion

        #region[Product_SelectByTop]
        public DataTable Product_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@order", Order);
            return ReturnDataTable("Product_SelectByTop", a);
        }
        #endregion
    }
}
