using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eMenu.DTO;
using eMenu.Entity;

namespace eMenu.BL
{
    public class tb_hotdishesBL : AbstractBL<tb_hotdishe, long>
    {
        public List<tb_hotdishesE> GetAll()
        {
            var all = (from d in ITPManager.tb_hotdishes
                       select new tb_hotdishesE
                       {
                           ID = d.ID,
                           name = d.name,
                           img = d.img,
                           price = d.price

                       }).ToList();

            return all;
        }
    }
}