using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class indent_detail
    {
        public int detail { get; set; }
        public int indent_id { get; set; }
        public int goods_id { get; set; }
        public decimal total_price { get; set; }
        public string payway { get; set; }
        public int  user_id { get; set; }
    }
}
