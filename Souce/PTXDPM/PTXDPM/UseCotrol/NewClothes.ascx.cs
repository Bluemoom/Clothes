using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
using System.Data;

namespace PTXDPM.UseCotrol
{
    public partial class NewClothes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderClothesUI orderClothesUI = new OrderClothesUI();
            if (!IsPostBack)
            {
                listproduct.DataSource = orderClothesUI.showNewClothes(20);
                listproduct.DataBind();
            }

        }
    }
}