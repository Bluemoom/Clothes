using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class Order_Detail_DetailController : ConnectDB
    {

        #region[Order_Detail_Insert]
        public int Order_Detail_Insert(Order_DetailInfo data)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Order_ID", data.Order_ID);
            a[1] = new SqlParameter("@ProductID", data.ProductID);
            a[2] = new SqlParameter("@Quatity", data.Quatity);
            return ExecuteCommand("Order_Detail_Insert", a); ;
        }
        #endregion

        #region[Order_Detail_Update]
        public int Order_Detail_Update(Order_DetailInfo data)
        {
            SqlParameter[] a = new SqlParameter[4];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Order_ID", data.Order_ID);
            a[2] = new SqlParameter("@ProductID", data.ProductID);
            a[3] = new SqlParameter("@Quatity", data.Quatity);
            return ExecuteCommand("Order_Detail_Update", a);
        }
        #endregion

        #region[Order_Detail_Delete]
        public int Order_Detail_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("Order_Detail_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("Order_Detail_Delete", a);

        }
        #endregion

        #region[Order_Detail_SelectByAll]
        public DataTable Order_Detail_SelectByAll()
        {
            return ReturnDataTable_NonParameter("Order_Detail_SelectByAll");
        }
        #endregion

        #region[Order_Detail_SelectByID]
        public DataTable Order_Detail_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("Order_Detail_SelectByID", a);
        }
        #endregion

        #region[Order_Detail_SelectByTop]
        public DataTable Order_Detail_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@Order", Order);
            return ReturnDataTable("Order_Detail_SelectByTop", a);
        }
        #endregion
    }
}
