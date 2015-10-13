using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class MenuController : ConnectDB
    {

        #region[Menu_Insert]
        public int Menu_Insert(MenuInfo data)
        {
            SqlParameter[] a = new SqlParameter[4];
            a[0] = new SqlParameter("@Name", data.Name);
            a[1] = new SqlParameter("@Link", data.Link);
            a[2] = new SqlParameter("@Order", data.Order);
            a[3] = new SqlParameter("@ParentID", data.ParentID);
            return ExecuteCommand("Menu_Insert", a); ;
        }
        #endregion

        #region[Menu_Update]
        public int Menu_Update(MenuInfo data)
        {
            SqlParameter[] a = new SqlParameter[5];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Name", data.Name);
            a[2] = new SqlParameter("@Link", data.Link);
            a[3] = new SqlParameter("@Order", data.Order);
            a[4] = new SqlParameter("@ParentID", data.ParentID);
            return ExecuteCommand("Menu_Update", a);
        }
        #endregion

        #region[Menu_Delete]
        public int Menu_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("Menu_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("Menu_Delete", a);

        }
        #endregion

        #region[Menu_SelectByAll]
        public DataTable Menu_SelectByAll()
        {
            return ReturnDataTable_NonParameter("Menu_SelectByAll");
        }
        #endregion

        #region[Menu_SelectByID]
        public DataTable Menu_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("Menu_SelectByID", a);
        }
        #endregion

        #region[Menu_SelectByTop]
        public DataTable Menu_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@order", Order);
            return ReturnDataTable("Menu_SelectByTop", a);
        }
        #endregion

    }
}
