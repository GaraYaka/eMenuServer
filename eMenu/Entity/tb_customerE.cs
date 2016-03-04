using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMenu.Entity
{
    public class tb_customerE
    {
        public int ID { get; set; }

        public string name { get; set; }

        public int number { get; set; }

        public string lname { get; set; }

        public bool? gender { get; set; }

        public string email { get; set; }

        public string location { get; set; }

        public int? points { get; set; }
    }
}