using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class WebServiceClient_Soap
    {
        public static string GetUserAccount(string username)
        {
            return "coucou";
        }
        public static bool addCHFByUserName(string userName, decimal chf)
        {
            return true;
        }
        public static bool addCHFByUID(int UID, decimal chf)
        {
            return true;
        }
    }
}
