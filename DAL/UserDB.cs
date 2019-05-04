using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class UserDB
    {
        public int addCHFByUID(string uid, double chf)
        {

            int udResult = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["PaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users" +
                                   " Set CHF = CHF + @CHF," +
                                   " WHERE IdUser = @IdUser";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@IdUser", uid);
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

        public int addCHFByUserName(string userName, double chf)
        {

            int udResult = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users" +
                                   " Set CHF = CHF + @CHF," +
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


    }
}
