using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CardManager
    {
        public double convertQuotaToCHF(int quota)
        {
            double chf = (double)(quota * 0.5);

            return chf;

        }

        public static string getUsernameByUserID(int UID)
        {         
            string userName = CardDB.getUsernameByUserID(UID);

            return userName;
        }

        public static int setQuota(double chf, int uid)
        {
            int quota;

            quota = CardDB.setQuota(chf, uid);

            return quota;
        }
    }
}
