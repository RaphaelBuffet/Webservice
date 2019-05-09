using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class WebServiceClient_Soap
    {
        static ServiceReference1.SoapPrinterServiceClient localClient = new ServiceReference1.SoapPrinterServiceClient();
        const string baseUri = "http://localhost:58760/";
        public static string GetUserAccount(string username)
        {
            return localClient.getUserAccount(username);
        }
        public static Boolean addCHFByUserName(string userName, decimal chf)
        {
            return localClient.addCHFByUsername(userName,chf);
        }
        public static Boolean addCHFByUID(int UID, decimal chf)
        {
            return localClient.addCHFByUID(UID,chf);
        }
        public static string getUsernameByUserID(int UID)
        {
            return localClient.getUsernameByCardID(UID);
        }
    }
}
