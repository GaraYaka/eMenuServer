using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eMenu.DTO;
using eMenu.BL;
using eMenu.Entity;

namespace eMenu.BL
{
    public class TB_TestBL : AbstractBL<TB_TestBL, long>
    {
        public List<TB_Test> GetAll()
        {
            var result = (from d in ITPManager.TB_Tests
                          select d).ToList();

            return result;
        }
    }
}