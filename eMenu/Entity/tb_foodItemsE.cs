using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMenu.Entity
{
    public class tb_foodItemsE
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string img { get; set; }

        public decimal? price { get; set; }

        public int Catid { get; set; }

    }
}