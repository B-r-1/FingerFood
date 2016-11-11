using FingerFood.Base.Time;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.Exceptions
{
    public class ExceptionManager
    {
        //public static string ConnectionStrings = ConfigurationManager.ConnectionStrings["EFDbContext"].ConnectionString;

        //public static void Process(Exception ex)
        //{
        //    try
        //    {
        //        using (SqlConnection sqlConnection = new SqlConnection(ConnectionStrings))
        //        {

        //            SqlCommand mySqlCommand = sqlConnection.CreateCommand();
        //            mySqlCommand.CommandText = "INSERT INTO Errors ([Message],[InnerException],[DateTime]) VALUES (@Message, @InnerException, @DateTime)";

        //            mySqlCommand.Parameters.Add("@Message", SqlDbType.VarChar, 5000);
        //            mySqlCommand.Parameters.Add("@InnerException", SqlDbType.VarChar, 5000);
        //            mySqlCommand.Parameters.Add("@DateTime", SqlDbType.DateTime);

        //            mySqlCommand.Parameters["@Message"].Value = ex.ToString();

        //            if (ex.InnerException != null)
        //                mySqlCommand.Parameters["@InnerException"].Value = ex.InnerException.ToString();
        //            else
        //                mySqlCommand.Parameters["@InnerException"].Value = DBNull.Value;

        //            mySqlCommand.Parameters["@DateTime"].Value = TimeManager.Now;

        //            sqlConnection.Open();
        //            mySqlCommand.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        Console.Write(exception.ToString());
        //    }
        //}
    }
}
