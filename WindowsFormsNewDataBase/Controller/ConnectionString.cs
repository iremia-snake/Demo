using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsNewDataBase.Controller
{
    internal class ConnectionString
    {
        public static string ConnString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["WindowsFormsNewDataBase.Properties.Settings.ConnString"].ConnectionString;
            }
        }
    }
}
