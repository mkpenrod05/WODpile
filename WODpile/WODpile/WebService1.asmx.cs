using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WODpile
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int? TestArray() 
        {
            int[] TempArray = { 2, 4, 6, -1 };
            int Index = 4;

            int? getValue = GetValue(TempArray, Index);

            return getValue;
        }

        int? GetValue(int[] array, int index)
        {
            int? returnValue;

            if ((index >= 0) && (index < array.Length) && (array.Length > 0))
            {
                returnValue = array[index];
            }
            else 
            {
                returnValue = null;
            }

            return returnValue;
        }
    }
}
