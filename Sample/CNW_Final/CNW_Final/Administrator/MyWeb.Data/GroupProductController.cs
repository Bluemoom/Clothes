using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class GroupProductController : ConnectDB
    {

        #region[GroupProduct_Insert]
        public int GroupProduct_Insert(GroupProductInfo data)
        {
            SqlParameter[] a = new SqlParameter[5];
            a[0] = new SqlParameter("@Name", data.Name);
            a[1] = new SqlParameter("@Content", data.Content);
            a[2] = new SqlParameter("@Images", data.Images);
            a[3] = new SqlParameter("@Order", data.Order);
            a[4] = new SqlParameter("@Status", data.status);
            return ExecuteCommand("GroupProduct_Insert", a);
        }
        #endregion

        #region[GroupProduct_Update]
        public int GroupProduct_Update(GroupProductInfo data)
        {
            SqlParameter[] a = new SqlParameter[6];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Name", data.Name);
            a[2] = new SqlParameter("@Content", data.Content);
            a[3] = new SqlParameter("@Images", data.Images);
            a[4] = new SqlParameter("@Order", data.Order);
            a[5] = new SqlParameter("@Status", data.status);
            return ExecuteCommand("GroupProduct_Update", a);
        }
        #endregion

        #region[GroupProduct_Delete]
        public int GroupProduct_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("GroupProduct_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("GroupProduct_Delete", a);

        }
        #endregion

        #region[GroupProduct_SelectByAll]
        public DataTable GroupProduct_SelectByAll()
        {
            return ReturnDataTable_NonParameter("GroupProduct_SelectByAll");
        }
        #endregion

        #region[GroupProduct_SelectByID]
        public DataTable GroupProduct_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("GroupProduct_SelectByID", a);
        }
        #endregion

        #region[GroupProduct_SelectByTop]
        public DataTable GroupProduct_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@order", Order);
            return ReturnDataTable("GroupProduct_SelectBTop", a);
        }
        #endregion

    }
}
