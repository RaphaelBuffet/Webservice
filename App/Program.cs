using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string userTemp = WebServiceClient_REST.getUserAccount("LoanBuffet");

            Console.WriteLine(userTemp);
            Console.ReadKey();

            WebServiceClient_REST.addCHFByUserName("LoanBuffet", 100);
            Console.ReadKey();

            WebServiceClient_REST.addCHFByUID(3, 200);
            Console.ReadKey();

            userTemp = WebServiceClient_REST.getUserAccount("LoanBuffet");

            Console.WriteLine(userTemp);
            Console.ReadKey();

            String userName = WebServiceClient_REST.getUsernameByUserID(4);
            Console.WriteLine("Username: " + userName);
            Console.ReadKey();*/

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
