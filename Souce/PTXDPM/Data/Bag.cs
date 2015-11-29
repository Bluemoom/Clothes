using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Bag
    {
        public List<Clothes> listClothes { get; set; }
        public float totalPrice { get; set; }

        public Bag() { }

        public Bag(List<Clothes> _list,float _total)
        {
            this.listClothes = _list;
            this.totalPrice = _total;
        }

        public int addClothes(string _id)
        {
            return 1;
        }

        public void showDetail()
        {
            caculatorTotalPrice();
        }

        public void caculatorTotalPrice()
        {
            totalPrice = 0; // tinsh tong cho bag o day
        }
    }
}
