using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string username = CardManager.getUsernameByUserID(1);
            Console.Write(username);
            Console.ReadKey();
            */

            User testUser =  BLL.UserManager.getUserAccount("SamuelPintodas");
            Console.Write(testUser.ToString());

            Console.ReadKey();
            
           
            int test = UserManager.addCHFByUserName("SamuelPintodas", 100);

            Console.WriteLine(test);
            Console.ReadKey();

            testUser = BLL.UserManager.getUserAccount("SamuelPintodas");
            Console.Write(testUser.ToString());

            Console.ReadKey();

            //int test = CardDB.setQuota(100.00, 1);
        }
    }
}
