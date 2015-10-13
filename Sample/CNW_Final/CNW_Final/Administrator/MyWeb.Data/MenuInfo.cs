using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Data
{
    public class MenuInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Order { get; set; }
        public string ParentID { get; set; }
    }
}
