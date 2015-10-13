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
    public class QuangCaoService
    {
        public static QuangCaoController db = new QuangCaoController();

        #region[QuangCao_Insert]
        public int QuangCao_Insert(QuangCaoInfo data)
        {
            return db.QuangCao_Insert(data);
        }
        #endregion

        #region[QuangCao_Update]
        public int QuangCao_Update(QuangCaoInfo data)
        {
            return db.QuangCao_Update(data);
        }
        #endregion


        #region[QuangCao_Delete]
        public int QuangCao_Delere(string ID)
        {
            return db.QuangCao_Delete(ID);
        }
        #endregion


        #region[QuangCao_SelectByID]
        public static DataTable QuangCao_SelectByID(string ID)
        {
            return db.QuangCao_SelectByID(ID);
        }
        #endregion


        #region[QuangCao_SelectByAll]
        public DataTable QuangCao_SelectByAll()
        {
            return db.QuangCao_SelectByAll();
        }
        #endregion


        #region[QuangCao_SelectByTop]
        public static DataTable QuangCao_SelectByTop(string Top, string Where, string Order)
        {
            return db.QuangCao_SelectByTop(Top, Where, Order);
        }
        #endregion

    }
}