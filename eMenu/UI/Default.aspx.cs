using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eMenu.DTO;
using eMenu.BL;
using eMenu.Entity;


namespace eMenu.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            k();
        }

        private void k()
        {
            var x = new TB_TestBL().GetAll();
        }
    }
}