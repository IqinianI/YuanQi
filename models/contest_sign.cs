﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class contest_sign
    {
        public int consign { get; set; }
        public int user_id { get; set; }
        public int contest_id { get; set; }
        public DateTime sign_time { get; set; }

    }
}