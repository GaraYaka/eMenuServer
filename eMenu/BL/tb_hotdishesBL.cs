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

        public int Save(tb_hotdishe masterData)
        {
            ITPManager.tb_hotdishes.InsertOnSubmit(masterData);
            ITPManager.SubmitChanges();

            return masterData.ID;
        }

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

        public List<tb_hotdishesE> GetHotDishToAPP()
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