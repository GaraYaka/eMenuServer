using eMenu.BL;
using eMenu.DTO;
using eMenu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace eMenu.Services
{
    /// <summary>
    /// Summary description for MenuService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MenuService : System.Web.Services.WebService
    {
        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public List<tb_menuE> GetAll()
        {
            return new tbMenuBL().GetAll();
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
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
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
        public void SaveFoodItem(string name, decimal price, int CatId)
        {


            tb_foodItem addFood = new tb_foodItem();

            addFood.name = name;
            addFood.price = price;
            addFood.CatID = CatId;

            new tbFoodItemsBL().Save(addFood);

        }
    }
}
