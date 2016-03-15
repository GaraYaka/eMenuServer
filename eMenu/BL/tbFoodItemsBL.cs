using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eMenu.DTO;
using eMenu.Entity;

namespace eMenu.BL
{
    public class tbFoodItemsBL:AbstractBL<tb_foodItem, long>
    {
        public int Save(tb_foodItem masterData)
        {
            ITPManager.tb_foodItems.InsertOnSubmit(masterData);
            ITPManager.SubmitChanges();

            return masterData.ID;
        }

        public List<tb_foodItemsE> GetAll()
        {
            var all = (from d in ITPManager.tb_foodItems
                       select new tb_foodItemsE
                       {
                           ID = d.ID,
                           name = d.name,
                           img = d.img,
                           price = d.price,
                           Catid = d.CatID

                       }).ToList();

            return all;
        }
    }
}