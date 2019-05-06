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
        public static string getUsernameByUserID(int UID)
        {
            User tempUser;

            string username = "";

            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * FROM Users WHERE UserId = " + UID;
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
                                tempUser.CHF = (decimal)dr["CHF"];

                            if (dr["CardId"] != null)
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

        public static int setQuota(double chf, int uid)
        {
            int quota;
            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Cards " +
                                   "Set Quota = Quota + @Quota " +
                                   "WHERE UserId = @UserId ";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@UserId", uid);
                    cmd.Parameters.AddWithValue("@Quota", chf);


                    try
                    {
                        cn.Open();
                        quota = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return quota;
        }

    }
}
