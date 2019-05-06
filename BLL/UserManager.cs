using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class UserManager
    {

        public static int convertCHFToQuota(decimal chf)
        {
            int quota = (int) (chf * 2);

            return quota;
        }

        public static int addCHFByUID(int uid, decimal chf)
        {
            int udResult = 0;

            int quota = convertCHFToQuota(chf);

            CardManager.setQuota(quota, uid);
            UserDB.addCHFByUID(uid, chf);

            return udResult;

        }

        public static int addCHFByUserName(string userName, decimal chf)
        {
            int udResult = 0;

            int userId = getUserAccount(userName).userId;
            int quota = convertCHFToQuota(chf);

            CardManager.setQuota(quota, userId);
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