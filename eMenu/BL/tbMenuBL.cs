using eMenu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMenu.BL
{
    public class tbMenuBL : AbstractBL<tb_menu, long>
    {
        public int Save(tb_menu masterData)
        {
            ITPManager.tb_menus.InsertOnSubmit(masterData);
            ITPManager.SubmitChanges();

            return masterData.catID;
        }

        public List<tb_menuE> GetAll()
        {
            var all = (from d in ITPManager.tb_menus
                       select new tb_menuE
                       {
                           Catid = d.catID,
                           itemname = d.itemName,
                           CatImg = d.catImg

                       }).ToList();

            return all;
        }

        
    }
}