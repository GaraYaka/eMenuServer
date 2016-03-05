using eMenu.BL;
using eMenu.Entity;
using eMenu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace eMenu.Services
{
    /// <summary>
    /// Summary description for FoodItemsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class FoodItemsService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public List<tb_foodItemsE> GetAll()
        {
            return new tbFoodItemsBL().GetAll();
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public void SaveItem(string name, decimal price , int CatId)
        {


            tb_foodItem addFood = new tb_foodItem();

            addFood.name = name;
            addFood.price = price;
            addFood.CatID = CatId;

            new tbFoodItemsBL().Save(addFood);

        }
    }
}
