using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class CustomerController : ConnectDB
    {

        #region[Customer_Insert]
        public int Customer_Insert(CustomerInfo data)
        {
            SqlParameter[] a = new SqlParameter[7];
            a[0] = new SqlParameter("@Username", data.Username);
            a[1] = new SqlParameter("@Password", data.Password);
            a[2] = new SqlParameter("@Brithday", data.Brithday);
            a[3] = new SqlParameter("@Provice", data.Provice);
            a[4] = new SqlParameter("@Address", data.Address);
            a[5] = new SqlParameter("@Tell", data.Tell);
            a[6] = new SqlParameter("@Email", data.Email);
            return ExecuteCommand("Customer_Insert", a); ;
        }
        #endregion

        #region[Customer_Update]
        public int Customer_Update(CustomerInfo data)
        {
            SqlParameter[] a = new SqlParameter[8];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Username", data.Username);
            a[2] = new SqlParameter("@Password", data.Password);
            a[3] = new SqlParameter("@Brithday", data.Brithday);
            a[4] = new SqlParameter("@Provice", data.Provice);
            a[5] = new SqlParameter("@Address", data.Address);
            a[6] = new SqlParameter("@Tell", data.Tell);
            a[7] = new SqlParameter("@Email", data.Email);
            return ExecuteCommand("Customer_Update", a);
        }
        #endregion

        #region[Customer_Delete]
        public int Customer_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("Customer_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("Customer_Delete", a);

        }
        #endregion

        #region[Customer_SelectByAll]
        public DataTable Customer_SelectByAll()
        {
            return ReturnDataTable_NonParameter("Customer_SelectByAll");
        }
        #endregion

        #region[Customer_SelectByID]
        public DataTable Customer_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("Customer_SelectByID", a);
        }
        #endregion

        #region[Customer_SelectByTop]
        public DataTable Customer_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@order", Order);
            return ReturnDataTable("Customer_SelectByTop", a);
        }
        #endregion

        public int Customer_CheckLogin(string usename, string password)
        {
            MoKetNoi();
            string query = "SELECT * FROM CUSTOMER WHERE USERNAME = '" + usename+ "' AND PASSWORD = '" + password+"'";
            SqlCommand sqlcmd = new SqlCommand(query, connect);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            DongKetNoi();
            if (dt.Rows.Count >= 1)
                return int.Parse(dt.Rows[0]["ID"].ToString());
            else
                return -1;
        }
        public int Customer_ChangePassword(string NewPass,string id)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[2];
            a[0] = new SqlParameter("@NewPass", NewPass);
            a[1] = new SqlParameter("@ID",id);
            return ExecuteCommand("Customer_ChangePassword", a);
        }
        public string Customer_GetName(int id)
        {
            string name = "";
            string query = "SELECT USERNAME FROM Customer WHERE ID=" + id;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(query, connect);
            SqlDataReader reader = null;
            reader = sqlcmd.ExecuteReader();
            while (reader.Read())
                name = reader["USERNAME"].ToString();
            DongKetNoi();
            return name;
        }
    }
}
