using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CardManager
    {
        public double convertQuotaToCHF(int quota)
        {
            double chf = (double)(quota * 0.5);

            return chf;

        }



    }
}
