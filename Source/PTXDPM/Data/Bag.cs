﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Bag
    {
        public List<Cloth> listClothes { get; set; }
        public double totalPrice { get; set; }

        public Bag()
        {
            listClothes = new List<Cloth>();
            totalPrice = 0;
        }

        public Bag(List<Cloth> _list, float _total)
        {
            this.listClothes = _list;
            this.totalPrice = _total;
        }

        public void AddCloth(string _id)
        {
            int temp = 1;
            foreach (Cloth item in listClothes)
            {
                //Neu clothes da ton tai thi tang so luong
                if (item.id == _id)
                {
                    item.quantity = (int.Parse(item.quantity) + 1).ToString();
                    temp = 0;
                }
            }
            //Neu clothes chua ton tai thi them moi clothes
            if (temp == 1)
            {
                Cloth temp1 = new Cloth(_id);
                this.listClothes.Add(temp1);
            }
        }

        public DataTable ShowDetail()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Images");
            tbl.Columns.Add("Quantity");
            tbl.Columns.Add("TotalPrice");
            foreach (Cloth item in listClothes)
            {
                DataRow dr = tbl.NewRow();
                dr["ID"] = item.id.ToString();
                dr["Name"] = item.name;
                dr["Images"] = item.images;
                dr["Quantity"] = item.quantity;
                dr["TotalPrice"] = (double.Parse(item.quantity) * double.Parse(item.priceOut)).ToString();
                tbl.Rows.Add(dr);
            }
            return tbl;
        }

        public void CaculatorTotalPrice()
        {
            totalPrice = 0; // Tránh trường hợp gọi lại hàm thì tổng tiền sẽ tính tiếp và tăng lên
            foreach (Cloth item in listClothes)
                totalPrice += (double.Parse(item.quantity) * double.Parse(item.priceOut));
        }
    }
}