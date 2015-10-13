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
    public class MenuService
    {
        public static MenuController db = new MenuController();

        #region[Menu_Insert]
        public int Menu_Insert(MenuInfo data)
        {
            return db.Menu_Insert(data);
        }
        #endregion

        #region[Menu_Update]
        public int Menu_Update(MenuInfo data)
        {
            return db.Menu_Update(data);
        }
        #endregion


        #region[Menu_Delete]
        public int Menu_Delere(string ID)
        {
            return db.Menu_Delete(ID);
        }
        #endregion


        #region[Menu_SelectByID]
        public DataTable Menu_SelectByID(string ID)
        {
            return db.Menu_SelectByID(ID);
        }
        #endregion


        #region[Menu_SelectByAll]
        public DataTable Menu_SelectByAll()
        {
            return db.Menu_SelectByAll();
        }
        #endregion


        #region[Menu_SelectByTop]
        public DataTable Menu_SelectByTop(string Top, string Where, string Order)
        {
            return db.Menu_SelectByTop(Top, Where, Order);
        }
        #endregion



    }
}