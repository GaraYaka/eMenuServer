using eMenu.DTO;
using eMenu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMenu.BL
{
    public class tb_customerBL : AbstractBL<tb_customer, long>
    {

        public List<tb_customerE> GetAll()
        {
            var all = (from d in ITPManager.tb_customers
                       select new tb_customerE
                       {
                           ID = d.ID,
                           name = d.name,
                           number = d.number,
                           lname = d.lname,
                           gender = d.gender,
                           email = d.email,
                           location = d.location,
                           points = d.points


                       }).ToList();

            return all;
        }
    }
}