using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    public class QuangCaoController : ConnectDB
    {

        #region[QuangCao_Insert]
        public int QuangCao_Insert(QuangCaoInfo data)
        {
            SqlParameter[] a = new SqlParameter[9];
            a[0] = new SqlParameter("@Name", data.Name);
            a[1] = new SqlParameter("@Url", data.Url);
            a[2] = new SqlParameter("@Width", data.Width);
            a[3] = new SqlParameter("@Height", data.Height);
            a[4] = new SqlParameter("@Link", data.Link);
            a[5] = new SqlParameter("@Tagert", data.Tagert);
            a[6] = new SqlParameter("@Position", data.Position);
            a[7] = new SqlParameter("@Order", data.Order);
            a[8] = new SqlParameter("@Status", data.Status);
            return ExecuteCommand("QuangCao_Insert", a); ;
        }
        #endregion

        #region[QuangCao_Update]
        public int QuangCao_Update(QuangCaoInfo data)
        {
            SqlParameter[] a = new SqlParameter[10];
            a[0] = new SqlParameter("@ID", data.ID);
            a[1] = new SqlParameter("@Name", data.Name);
            a[2] = new SqlParameter("@Url", data.Url);
            a[3] = new SqlParameter("@Width", data.Width);
            a[4] = new SqlParameter("@Height", data.Height);
            a[5] = new SqlParameter("@Link", data.Link);
            a[6] = new SqlParameter("@Tagert", data.Tagert);
            a[7] = new SqlParameter("@Position", data.Position);
            a[8] = new SqlParameter("@Order", data.Order);
            a[9] = new SqlParameter("@Status", data.Status);
            return ExecuteCommand("QuangCao_Update", a);
        }
        #endregion

        #region[QuangCao_Delete]
        public int QuangCao_Delete(string ID)
        {
            SqlCommand sqlcmd = new SqlCommand("QuangCao_Delete", connect);
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ExecuteCommand("QuangCao_Delete", a);

        }
        #endregion

        #region[QuangCao_SelectByAll]
        public DataTable QuangCao_SelectByAll()
        {
            return ReturnDataTable_NonParameter("QuangCao_SelectByAll");
        }
        #endregion

        #region[QuangCao_SelectByID]
        public DataTable QuangCao_SelectByID(string ID)
        {
            MoKetNoi();
            SqlParameter[] a = new SqlParameter[1];
            a[0] = new SqlParameter("@ID", ID);
            return ReturnDataTable("QuangCao_SelectByID", a);
        }
        #endregion

        #region[QuangCao_SelectByTop]
        public DataTable QuangCao_SelectByTop(string Top, string Where, string Order)
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", Top);
            a[1] = new SqlParameter("@where", Where);
            a[2] = new SqlParameter("@order", Order);
            return ReturnDataTable("QuangCao_SelectByTop", a);
        }
        #endregion

    }
}
