using eMenu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMenu.BL
{
    public class tb_feedbackBL : AbstractBL<tb_feedback, string>
    {
        public int Save(tb_feedback masterData)
        {
            ITPManager.tb_feedbacks.InsertOnSubmit(masterData);
            ITPManager.SubmitChanges();

            return masterData.feedbackID;
        }
              
    }
}