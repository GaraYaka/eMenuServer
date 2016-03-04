using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using eMenu.BL;
using eMenu.DTO;
using eMenu.Entity;
using System.Web.Script.Services;

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
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
