using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using System.Reflection;
using System.Configuration;

namespace DALFactory
{
    public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();

        public static 
    }
}
