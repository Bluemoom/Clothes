using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class OrderController : ConnectDB
    {

        #region[Order_Insert]
        public int Order_Insert(OrderInfo data)
        {
            SqlParameter[] a = new SqlParameter[4];
            a[0] = new SqlParameter("@Customer_ID", data.Customer_ID);
            a[1] = new SqlParameter("@Totalmoney", data.Totalmoney);
            a[2] = new SqlParameter("@Date", data.Date);
            a[3] = new SqlParameter("@Status", data.Status);
            return ExecuteCommand("Order_Insert", a); ;
        }
        #endregion

        #region[Order_Update]
        public int Order_Update(OrderInfo data)
        {
            SqlParameter[] a = new SqlParameter[5];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Customer_ID", data.Customer_ID);
            a[2] = new SqlParameter("@Totalmoney", data.Totalmoney);
            a[3] = new SqlParameter("@Date", data.Date);
            a[4] = new SqlParameter("@Status", data.Status);
            return ExecuteCommand("Order_Update", a);
        }
        #endregion

        #region[Order_Delete]
        public int Order_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("Order_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("Order_Delete", a);

        }
        #endregion

        #region[Order_SelectByAll]
        public DataTable Order_SelectByAll()
        {
            return ReturnDataTable_NonParameter("Order_SelectByAll");
        }
        #endregion

        #region[Order_SelectByID]
        public DataTable Order_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("Order_SelectByID", a);
        }
        #endregion

        #region[Order_SelectByTop]
        public DataTable Order_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@order", Order);
            return ReturnDataTable("Order_SelectBTop", a);
        }
        #endregion

        public int Order_GetId(int CustomerID)
        {
            int id = 0;
            string query = "SELECT ID FROM [Order] WHERE Customer_ID = " + CustomerID;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(query, connect);
            SqlDataReader reader = null;
            reader = sqlcmd.ExecuteReader();
            while (reader.Read())
                id = int.Parse(reader["ID"].ToString());
            DongKetNoi();
            return id;
        }
    }
}
