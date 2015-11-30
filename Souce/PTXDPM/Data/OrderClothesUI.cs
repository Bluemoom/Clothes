﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrderClothesUI
    {
        public Order order { get; set; }

        public Bag bag { get; set; }
        public Customer customer { get; set; }
        public Clothes chonseClothes { get; set; }

        public OrderClothesUI() { }

        public OrderClothesUI(Order _order,Bag _bag,Customer _customer,Clothes _chonseClothes)
        {
            this.order = _order;
            this.bag = _bag;
            this.customer = _customer;
            this.chonseClothes = _chonseClothes;
        }

        public DataTable showClothesByOptions(int _c,string _ColorID, string _sizeID, string _pricemin,string _pricemax )
        {
            ConnectDB db = new ConnectDB();
            if (_c ==1)
            {   
                SqlParameter[] a = new SqlParameter[3];
                a[0] = new SqlParameter("@Top", "");
                a[1] = new SqlParameter("@where", "ColorID =" + _ColorID);
                a[2] = new SqlParameter("@order", "[Order] Desc");
                DataTable dt = db.ReturnDataTable("Clothes_SelectByTop", a);
                return dt;
            }
            if(_c==2)
            {
                SqlParameter[] a = new SqlParameter[3];
                a[0] = new SqlParameter("@Top", "");
                a[1] = new SqlParameter("@where", "SizeID =" + _sizeID);
                a[2] = new SqlParameter("@order", "[Order] Desc");
                DataTable dt = db.ReturnDataTable("Clothes_SelectByTop", a);
                return dt;
            }
            if(_c==3)
            {
                SqlParameter[] a = new SqlParameter[3];
                a[0] = new SqlParameter("@Top", "");
                a[1] = new SqlParameter("@where", "PriceOut >=" + _pricemin+" and PriceOut<="+_pricemax);
                a[2] = new SqlParameter("@order", "[Order] Desc");
                DataTable dt = db.ReturnDataTable("Clothes_SelectByTop", a);
                return dt;
            }
            return null;
        }
        public DataTable showNewClothes(int _sl)
        {
            ConnectDB db = new ConnectDB();
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", ""+_sl+"");
            a[1] = new SqlParameter("@where", "status =1 and new = 1");
            a[2] = new SqlParameter("@order", "[Order] Desc");
            DataTable dt = db.ReturnDataTable("Clothes_SelectByTop", a);
            return dt;
        }
        public DataTable showClothesByGroup(string _groupID)
        {
            ConnectDB db = new ConnectDB();
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@Top", "");
            a[1] = new SqlParameter("@where", "GroupClothesID ="+_groupID);
            a[2] = new SqlParameter("@order", "[Order] Desc");
            DataTable dt = db.ReturnDataTable("Clothes_SelectByTop", a);
            return dt;
        }

        public void showClothesByID(string _id)
        {
            chonseClothes.showDetail(_id);
        }

        public void addClothesToBag(string _id)
        {
            bag.addClothes(_id);
        }

        public void showBagDetail()
        {
            bag.showDetail();
        }

        public void createOrder(string _name,string _email,string _address,string _phonenumber)
        {
            string date = "";
            customer = new Customer(_name, _email, _address, _phonenumber);
            order = new Order(bag, customer, date);
        }
    }
}
