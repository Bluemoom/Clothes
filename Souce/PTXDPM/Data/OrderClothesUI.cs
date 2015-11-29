using System;
using System.Collections.Generic;
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

        public List<Clothes> showClothesByOptions()
        {
            List<Clothes> _list=null;
            return _list;
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
