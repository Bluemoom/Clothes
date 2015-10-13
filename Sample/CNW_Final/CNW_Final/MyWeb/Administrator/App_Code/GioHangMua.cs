using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MyWeb.Data;
using MyWeb.Business;

/// <summary>
/// Summary description for GioHangMua
/// </summary>
public class GioHangMua : ConnectDB
{
	public GioHangMua()
	{      
	}
    public List<HangHoa> listHangHoa = new List<HangHoa>();
    public float TotalMoney { get; set; }
    public HangHoa SelectHangHoa(int id)
    {
        return listHangHoa[id];
    }
    public int GetSoLuong()
    {
        int sl = 0;
        foreach (HangHoa i in listHangHoa)
            sl += i.sl;
        return sl;
    }

    public void AddHangHoa(HangHoa tmp)
    {
        bool yes = false;
        foreach(HangHoa i in listHangHoa)
            if(tmp.id==i.id)
            {
                i.sl += tmp.sl;
                yes = true;
                break;
            }
        if(!yes)
        {
            listHangHoa.Add(tmp);
        }
    }

    public void DeleteHangHoa(int id)
    {
        foreach (HangHoa i in listHangHoa)
            if (i.id == id)
                listHangHoa.Remove(i);
    }

    public void UpdateHangHoa(HangHoa tmp)
    {
        foreach (HangHoa i in listHangHoa)
            if (i.id == tmp.id)
            {
                i.sl = tmp.sl;
                if (tmp.sl == 0)
                    listHangHoa.Remove(i);
                return;
            }
    }

    public DataTable returnTable()
    {
        TotalMoney = 0;
        DataTable tbl = new DataTable();
        tbl.Columns.Add("id");
        tbl.Columns.Add("Name");
        tbl.Columns.Add("Sl");
        tbl.Columns.Add("ThanhTien");
        foreach(HangHoa i in listHangHoa)
        {
            DataRow dr = tbl.NewRow();
            dr["Id"] = i.id;
            dr["Name"] = GetName(i.id);
            dr["Sl"] = i.sl;
            dr["thanhtien"] = (double)i.sl * GetPrice(i.id);
            TotalMoney += i.sl * GetPrice(i.id);
            tbl.Rows.Add(dr);
        }
        return tbl; 
    }

    public DataTable returnTable1()
    {
        TotalMoney = 0;
        DataTable tbl = new DataTable();
        tbl.Columns.Add("Images");
        tbl.Columns.Add("Name");
        tbl.Columns.Add("Sl");
        tbl.Columns.Add("ThanhTien");
        foreach (HangHoa i in listHangHoa)
        {
            DataRow dr = tbl.NewRow();
            dr["Images"] = GetImages(i.id);
            dr["Name"] = GetName(i.id);
            dr["Sl"] = i.sl;
            dr["thanhtien"] = (double)i.sl * GetPrice(i.id);
            TotalMoney += i.sl * GetPrice(i.id);
            tbl.Rows.Add(dr);
        }
        return tbl;
    }

    public string GetName(int id)
    { 
        return GetData("SELECT NAME FROM PRODUCT WHERE ID=", "NAME", id.ToString());
    }

    public float GetPrice(int id)
    {
        return float.Parse(GetData("SELECT PRICE FROM PRODUCT WHERE ID=", "PRICE", id.ToString()));
    }   

    public string GetImages(int id)
    {
        return GetData("SELECT IMAGES FROM PRODUCT WHERE ID=", "IMAGES", id.ToString());
    }

    public double GetTongTien()
    {
        double TongTien=0;
        foreach (HangHoa i in listHangHoa)
            TongTien += i.sl * GetPrice(i.id);
        return TongTien;
    }

    public int CreateOrderDetail(string OrderID)
    {
        Order_DetailInfo obj=new Order_DetailInfo();
        int j = 0;
        foreach(HangHoa i in listHangHoa)
        {
            obj.Order_ID = OrderID;
            obj.ProductID = i.id.ToString();
            obj.Quatity = i.sl.ToString();
            j= Order_DetailService.db.Order_Detail_Insert(obj);
        }
        return j;
    }
}