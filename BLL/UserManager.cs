using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    class UserManager
    {

        public int convertCHFToQuota(double chf)
        {
            int quota = (int) (chf * 2);

            return quota;
        }

        public static int addCHFByUID(int uid, double chf)
        {
            int udResult = 0;

            UserDB.addCHFByUID(uid, chf);

            return udResult;

        }

        public static int addCHFByUserName(string userName, decimal chf)
        {
            int udResult = 0;

            UserDB.addCHFByUserName(userName, chf);

            return udResult;

        }

        public static User getUserAccount(string username)
        {
            User tempUser = null;

            tempUser = UserDB.getUserAccount(username);

            return tempUser;
        }

        public static User getUserAccountById(int id)
        {
            User tempUser = null;

            tempUser = UserDB.getUserAccountById(id);

            return tempUser;
        }
    }
}