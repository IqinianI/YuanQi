﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class indent
    {
        public int indent_id { get; set; }
        public int user_id { get; set; }
        public string indent_state { get; set; }
        public DateTime indent_date { get; set; }
        public decimal indent_price { get; set; }
    }
}
