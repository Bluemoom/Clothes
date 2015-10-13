using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class UserController : ConnectDB
    {
        #region[User_Insert]
        public void User_Insert(UserInfo data)
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_Insert", connect))
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@Name", data.Name));
                sqlcmd.Parameters.Add(new SqlParameter("@UserName", data.UserName));
                sqlcmd.Parameters.Add(new SqlParameter("@Password", data.Password));
                sqlcmd.Parameters.Add(new SqlParameter("@Rule", data.Rule));
                sqlcmd.Parameters.Add(new SqlParameter("@Status", data.Status));
                sqlcmd.ExecuteNonQuery();
            }
            DongKetNoi();
        }

        #endregion
        #region[User_Update]
        public void User_Update(UserInfo data)
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_Update", connect))
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@Id", data.ID));
                sqlcmd.Parameters.Add(new SqlParameter("@Name", data.Name));
                sqlcmd.Parameters.Add(new SqlParameter("@UserName", data.UserName));
                sqlcmd.Parameters.Add(new SqlParameter("@Password", data.Password));
                sqlcmd.Parameters.Add(new SqlParameter("@Rule", data.Rule));
                sqlcmd.Parameters.Add(new SqlParameter("@Status", data.Status));
                sqlcmd.ExecuteNonQuery();
            }
            DongKetNoi();
        }

        #endregion
        #region[User_Delete]
        public void User_Delete(string id)
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_Delete", connect))
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@ID", id));
                sqlcmd.ExecuteNonQuery();
            }
            DongKetNoi();
        }

        #endregion
        #region[User_GetByAll]
        public DataTable User_GetByAll()
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_GetByAll", connect))
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }

        }

        #endregion
        #region[User_GetByID]
        public DataTable User_GetByID(string id)
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_GetByID", connect))
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@ID", id));
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
        }
        #endregion
        #region[User_GetByTop]
        public DataTable User_GetByTop(string Top, string where, string order)
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_GetByTop", connect))
            {
                MoKetNoi();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@Top", Top));
                sqlcmd.Parameters.Add(new SqlParameter("@Where", where));
                sqlcmd.Parameters.Add(new SqlParameter("@order", order));
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                DongKetNoi();
                DongKetNoi();
                return dt;
            }
        }

        #endregion

        #region[User_CheckLogin]
        public int User_ChẹckLogin(string username, string password)
        {
            MoKetNoi();
            using (SqlCommand sqlcmd = new SqlCommand("sp_User_CheckLogin", connect))
            {

                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@Username", username));
                sqlcmd.Parameters.Add(new SqlParameter("@Password", password));
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                DongKetNoi();
                if (dt.Rows.Count >= 1)
                    return int.Parse(dt.Rows[0]["Rule"].ToString());
                else
                    return -1;
            }
        }
        #endregion
    }
}