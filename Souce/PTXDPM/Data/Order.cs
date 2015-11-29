using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order
    {
        public Bag bag { get; set; }
        public Customer customer { get; set; }
        public string date { get; set; }

        public Order() { }
        public Order(Bag _bag,Customer _customer,string _date)
        {
            this.bag = _bag;
            this.customer = _customer;
            this.date = _date;
        }

        public void printOrder()
        { }
    }
}
