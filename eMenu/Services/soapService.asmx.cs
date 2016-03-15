using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using eMenu.BL;
using eMenu.DTO;
using eMenu.Entity;
using System.Web.Script.Services;
using System.Web.Script.Serialization;


namespace eMenu.Services
{
    /// <summary>
    /// Summary description for soapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    
    
    public class soapService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        
        public List<tb_menuE> GetAll()
        {
            List<tb_menuE> list = new tbMenuBL().GetAll();
            return list;
        }

        /// <summary>
        /// refer this as the sampple method, repsonse should be JSON.
        /// </summary>
        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void getTest()
        {
            List<tb_menuE> list = new tbMenuBL().GetAll();
            JavaScriptSerializer jSerial = new JavaScriptSerializer();
            Context.Response.Write(jSerial.Serialize(list));
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public void SaveItem(string itemName)
        {


            tb_menu addCategory = new tb_menu();

            addCategory.itemName = itemName;

            new tbMenuBL().Save(addCategory);

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public List<tb_menuE> GetAllCategories()
        {
            return new tbMenuBL().GetAll();
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public List<tb_foodItemsE> GetFoodAll()
        {
            return new tbFoodItemsBL().GetAll();

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public void GetFoodAllToApp() 
        {           
            List<tb_foodItemsE> list = new tbFoodItemsBL().GetAll();
            JavaScriptSerializer jSerial = new JavaScriptSerializer();
            Context.Response.Write(jSerial.Serialize(list));

        }


        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public List<tb_hotdishesE> GetAllHotDishToWEB()
        {
            return new tb_hotdishesBL().GetAll();

            
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public List<tb_hotdishesE> GetAllHotDish()
        {
           

            List<tb_hotdishesE> list = new tb_hotdishesBL().GetAll();
            return list;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void getAllDishToAPP()
        {
            List<tb_hotdishesE> list = new tb_hotdishesBL().GetHotDishToAPP();
            JavaScriptSerializer jSerial = new JavaScriptSerializer();
            Context.Response.Write(jSerial.Serialize(list));
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public void SaveFoodItem(string name, decimal price, int CatId)
        {


            tb_foodItem addFood = new tb_foodItem();

            addFood.name = name;
            addFood.price = price;
            addFood.CatID = CatId;

            new tbFoodItemsBL().Save(addFood);

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public void SaveHotDish(string name, decimal price)
        {


            tb_hotdishe addFood = new tb_hotdishe();

            addFood.name = name;
            addFood.price = price;
            

            new tb_hotdishesBL().Save(addFood);

        }


        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public List<tb_usersE> GetAllUsers()
        {
            return new tb_usersBL().GetAllUsers();

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void getAllUsersToAPP()
        {
            List<tb_usersE> list = new tb_usersBL().GetAllUsers();
            JavaScriptSerializer jSerial = new JavaScriptSerializer();
            Context.Response.Write(jSerial.Serialize(list));
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void AddUser(string name, string mobile)
        {

            tb_user adduser = new tb_user();

            adduser.uname = name;
            adduser.umobile = mobile;


            new tb_usersBL().Save(adduser);

        }

    }
}
