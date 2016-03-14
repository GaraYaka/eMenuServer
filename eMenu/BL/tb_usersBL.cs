using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eMenu.DTO;

namespace eMenu.BL
{
    public class tb_usersBL : AbstractBL<tb_user, long>
    {
        public int Save(tb_user masterData)
        {
            ITPManager.tb_users.InsertOnSubmit(masterData);
            ITPManager.SubmitChanges();

            return masterData.uid;
        }

        public List<tb_usersE> GetAllUsers()
        {
            var all = (from d in ITPManager.tb_users
                       select new tb_usersE
                       {
                           uid = d.uid,
                           uname = d.uname,
                           umobile = d.umobile

                       }).ToList();

            return all;
        }
    }
}