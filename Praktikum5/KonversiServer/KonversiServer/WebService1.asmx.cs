﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KonversiServer
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

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        [WebMethod]
        public double CelCiusToReamur(int C)
        {
            return (0.8) * C;
        }
        [WebMethod]
        public double CelCiusToFahrenheit(int C)
        {
            return (1.8) * C + 32;
        }
        [WebMethod]
        public int CelCiusToKelvin(int C)
        {
            return C + 273;
        }

    }
}
