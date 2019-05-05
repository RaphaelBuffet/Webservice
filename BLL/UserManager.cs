using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class UserManager
    {

        public int convertCHFToQuota(double chf)
        {
            int quota = (int)(chf* 2);

            return quota;
        }

    }
}
