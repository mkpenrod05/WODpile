using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WODpile.Models
{
    public class CustomClasses
    {
        public static string SqlConnWODPile = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnWODPile"].ConnectionString;
        public static string DateFormat = "dd/MM/yyyy";

        public class ErrorCheck
        {
            public bool IsError { get; set; }
            public string Message { get; set; }

        }
    }
}