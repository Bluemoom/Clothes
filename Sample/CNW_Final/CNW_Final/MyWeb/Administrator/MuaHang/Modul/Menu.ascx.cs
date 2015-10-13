using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Business;

public partial class MuaHang_Modul_Menu : System.Web.UI.UserControl
{
    string s = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var dt = MenuService.db.Menu_SelectByTop("", "ParentID = 0", " [Order]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoadMenu(dt.Rows[i]["ID"].ToString());
            }
            ltrMenu.Text = s;
        }

    }

    public void LoadMenu(string ID)
    {
        var dt = MenuService.db.Menu_SelectByID(ID);
        var dtChild = MenuService.db.Menu_SelectByTop("", "ParentID= "+ID+" "," [Order]" );
        if(dtChild.Rows.Count>0)
        {
            s+="<li><a href=\""+dt.Rows[0]["Link"]+"\">"+dt.Rows[0]["Name"]+"</a>";
            s+="\n<ul>";
            for(int i=0;i<dtChild.Rows.Count;i++)
            {
                LoadMenu(dtChild.Rows[i]["ID"].ToString());
            }
            s+="\n</ul></li>";
        }
        else
        {
            s+="<li><a href=\""+dt.Rows[0]["Link"]+"\">"+dt.Rows[0]["Name"]+"</a>"; 
        }
    }
}