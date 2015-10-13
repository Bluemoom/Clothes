using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWeb.Data;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.Data
{
    class HoaDonController : ConnectDB
    {
        public static DataTable OrderDetail()
        {
            DataTable dt = new DataTable();
            string query = "OrderDetail";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
    }
}
