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
    public class UserService 
    {
        public static UserController db = new UserController();
        #region[User_Insert]
        public void User_Insert(UserInfo data)
        {
            db.User_Insert(data);
        }
        #endregion

        #region[User_Update]
        public void User_Update(UserInfo data)
        {
            db.User_Update(data);
        }
        #endregion

        #region[User_Delete]
        public void User_Delete(string id)
        {
            db.User_Delete(id);
        }
        #endregion

        #region[User_GetByAll]
        public DataTable User_GetByAll()
        {
            return db.User_GetByAll();
        }
        #endregion

        #region[User_GetById]
        public DataTable User_GetById(string id)
        {
            return db.User_GetByID(id);
        }
        #endregion

        #region[User_GetByTop]
        public DataTable User_GetByTop(string Top, string Where, string order)
        {
            return db.User_GetByTop(Top, Where, order);
        }
        #endregion

        #region[User_CheckLogin]
        public int User_CheckLogin(string username, string password)
        {
            return db.User_ChẹckLogin(username, password);
        }
        #endregion
    }
}
