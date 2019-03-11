using System;
using System.Data.SqlClient;

namespace Studing_Journal
{
    class DataBaseFunctionAuthorization
    {
        SqlCommand command = new SqlCommand("", Registry_Class.sqlConnection);
        public static string Access_Rights = "000000", System_Access = "00", Login = "";
        
        public void fcProfile_Authorization(string login, string password)
        {
            command.CommandText = "select [dbo].[Profile_Authorization]('"+login+"','"+password+"')";
            try
            {
                Registry_Class.sqlConnection.Open();
                System_Access = command.ExecuteScalar().ToString();
                command.CommandText = "select [dbo].[Access_rights_Value]("
                    + "select [dbo].[Profile].[Access_rights_ID] from [dbo].[Profile] " +
                    "where Login_Profile ='"+ login + "' and Password_Profile = '"+ password + "')";
                Access_Rights = command.ExecuteScalar().ToString();
                Login = login;
            }
            catch(SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
    }
}
