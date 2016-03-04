using eMenu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMenu.BL
{
    public class tbMenuBL : AbstractBL<tb_menu, long>
    {
        public List<tb_menuE> GetAll()
        {
            var all = (from d in ITPManager.tb_menus
                       select new tb_menuE
                       {
                           itemID = d.itemID,
                           itemname = d.itemName,
                           Catid = d.catID

                       }).ToList();

            return all;
        }
    }
}