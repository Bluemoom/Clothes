using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Clothes
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string GroupClothesID { get; set; }
        public string Description { get; set; }
        public string PriceIn { get; set; }
        public string PriceOut { get; set; }
        public string NewPrice { get; set; }
        public string Sex { get; set; }
        public string ColorID { get; set; }
        public string SizeID { get; set; }
        public string Images { get; set; }
        public string MaterialID { get; set; }
        public string Quantity { get; set; }
        public string Order { get; set; }
        public string Status { get; set; }

        public Clothes() {}

        public Clothes(string _id,string _name,string _gID,string _des,string _pricein,string priceout,string _newprice,string _sex,string _colorID, string _sizeID, string _images, string _materialID,string _quantity, string _order,string _status)
        {
            this.ID = _id;
            this.Name = _name;
            this.GroupClothesID = _gID;
            this.Description = _des;
            this.PriceIn = _pricein;
            this.PriceOut = priceout;
            this.NewPrice = _newprice;
            this.Sex = _sex;
            this.ColorID = _colorID;
            this.SizeID = _sizeID;
            this.Images = _images;
            this.MaterialID = _materialID;
            this.Quantity = _quantity;
            this.Order = _order;
            this.Status = _status;
        }

        public List<Clothes> findClothesByOptions()
        {
            List<Clothes> _list = new List<Clothes>();
            return _list;
        }

        public void showDetail(string _ID)
        {

        }

        public string getClothesID()
        {
            string id="";
            return id;
        }
    }
}
