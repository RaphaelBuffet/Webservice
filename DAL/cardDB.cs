using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CardDB
    {
        public string getUsernameByCardID(int cardId)
        {
            User tempUser;
            string username = "";

            string connectionString = ConfigurationManager.ConnectionStrings["PaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users WHERE cardId = " + cardId;
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tempUser = new User();

                            tempUser.userId = (int)dr["UserId"];

                            if (dr["UserName"] != null)
                                tempUser.userName = (string)dr["UserName"];

                            if (dr["CHF"] != null)
                                tempUser.CHF = (double)dr["CHF"];

                            if (dr["IdCard"] != null)
                                tempUser.cardId = (int)dr["CardId"];

                            username = tempUser.userName;

                        }

                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return username;
        }

    }
}
