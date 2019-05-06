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
    public class UserDB
    {
        
        public static int addCHFByUID(int uid, decimal chf)
        {

            int udResult = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users" +
                                   " Set CHF = CHF + @CHF " +
                                   " WHERE UserId = @UserId";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@UserId", uid);
                    cmd.Parameters.AddWithValue("@CHF", chf);


                    try
                    {
                        cn.Open();
                        udResult = cmd.ExecuteNonQuery();
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

            return udResult;
        }

    

        public static int addCHFByUserName(string userName, decimal chf)
        {

            int udResult = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users " +
                                   " Set CHF = CHF + @CHF " +
                                   " WHERE UserName = @UserName";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@CHF", chf);

                    try
                    {
                        cn.Open();
                        udResult = cmd.ExecuteNonQuery();
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

            return udResult;
        }

        public static User getUserAccount(string username)
        {
            User tempUser = null;

            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users WHERE UserName = '" + username + "'";
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
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return tempUser;
        }

        public static User getUserAccountById(int id)
        {
            User tempUser = null;

            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users WHERE UserId = " + id;
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
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return tempUser;
        }


    }
}