using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Bag
    {
        public List<Clothes> listClothes { get; set; }
        public double totalPrice { get; set; }

        public Bag()
        {
            listClothes = new List<Clothes>();
            totalPrice = 0;
        }

        public Bag(List<Clothes> _list, float _total)
        {
            this.listClothes = _list;
            this.totalPrice = _total;
        }

        public void addClothes(string _id)
        {
            int temp = 1;
            foreach (Clothes item in listClothes)
            {
                //Neu clothes da ton tai thi tang so luong
                if (item.ID == _id)
                {
                    item.Quantity = (int.Parse(item.Quantity) + 1).ToString();
                    temp = 0;
                }
            }
            //Them clothes chua ton tai thi them moi clothes
            if (temp == 1)
            {
                Clothes temp1 = new Clothes(_id);
                this.listClothes.Add(temp1);
            }
        }

        public DataTable showDetail()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Images");
            tbl.Columns.Add("Quantity");
            tbl.Columns.Add("TotalPrice");
            foreach (Clothes item in listClothes)
            {
                DataRow dr = tbl.NewRow();
                dr["ID"] = item.ID.ToString();
                dr["Name"] = item.Name;
                dr["Images"] = item.Images;
                dr["Quantity"] = item.Quantity;
                dr["TotalPrice"] = (Double.Parse(item.Quantity) * Double.Parse(item.PriceOut)).ToString();
                tbl.Rows.Add(dr);
            }
            return tbl;
        }

        public void caculatorTotalPrice()
        {
            totalPrice = 0; // vi tinh nhieu lan se bi tang len
            foreach (Clothes item in listClothes)
                totalPrice += (double.Parse(item.Quantity) * double.Parse(item.PriceOut));
        }
    }
}
