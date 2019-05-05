using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public decimal CHF { get; set; }
        public int cardId { get; set; }

        public override string ToString()
        {
            return
                "UserId: \t" + userId + "\n" +
                "userName: \t" + userName + "\n" +
                "CHF:\t\t" + CHF + "\n" +
                "cardId:\t\t" + cardId + "\n";
        }
    }


}

