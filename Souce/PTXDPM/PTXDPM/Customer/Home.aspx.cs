﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;

namespace PTXDPM.Customer
{
    public partial class Home : System.Web.UI.Page
    {
        OrderClothesUI orderClothesUI = new OrderClothesUI();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listGroup.DataSource = orderClothesUI.ShowGroup(6);
                listGroup.DataBind();
                listproduct.DataSource = orderClothesUI.showNewClothes(20);
                listproduct.DataBind();
            }
        }
    }
}