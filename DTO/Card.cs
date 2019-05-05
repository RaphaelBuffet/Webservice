using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Card
    {
        public int cardId { get; set; }
        public int quota { get; set; }
        public int userId { get; set; }

        public override string ToString()
        {
            return
                "cardId:\t\t" + cardId + "\n" +
                "Quota:\t\t" + quota + "\n" +
                "UserId: \t" + userId + "\n";
        }
    }
}
