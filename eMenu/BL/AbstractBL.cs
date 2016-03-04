using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMenu.DTO;

namespace eMenu.BL
{
    public class AbstractBL <T, Idt>
    {
        private EntityManagerDataContext _EntityManager = new EntityManagerDataContext();

        public List<T> GetAll<T>()
        {
            _EntityManager.DeferredLoadingEnabled = false;
            _EntityManager.ObjectTrackingEnabled = false;
            List<T> entities = _EntityManager.GetTable(typeof(T)) as List<T>;
            return entities;
        }

        protected AbstractBL()
        {

        }

        public bool SaveChanges()
        {
            try
            {
                _EntityManager.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                //Logger.Error("AbstractDao", "Error In Save Changes: \n " + e.Message);
                //Logger.Error("AbstractDao", "Error In Save Changes: \n " + e.StackTrace);
                if (null != _EntityManager.Transaction)
                {
                    _EntityManager.Transaction.Rollback();
                }
                throw e;
            }
        }

        protected EntityManagerDataContext ITPManager
        {
            get
            {
                if (null == _EntityManager)
                {
                    _EntityManager = new EntityManagerDataContext();
                }
                return _EntityManager;
            }
            set
            {
                _EntityManager = value;
            }
        } 
    }
}
