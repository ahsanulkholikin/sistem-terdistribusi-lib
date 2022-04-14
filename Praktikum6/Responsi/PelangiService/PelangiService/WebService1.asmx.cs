using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PelangiService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Pelangi(int C)
        {
            if (C == 1)
            {
                return "Merah";
            }
            else if (C == 2)
            {
                return "Jingga";
            }
            else if (C == 3)
            {
                return "Kuning";
            }
            else if (C == 4)
            {
                return "Hijau";
            }
            else if (C == 5)
            {
                return "Biru";
            }
            else if (C == 6)
            {
                return "Nila";
            }
            else if (C == 7)
            {
                return "Ungu";
            }
            else
            {
                return "Nomor antara 1-7";
            }
        }
    }
}
