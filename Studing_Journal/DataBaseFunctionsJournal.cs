using System;
using System.Data;
using System.Data.SqlClient;

namespace Studing_Journal
{
    class DataBaseFunctionsJournal
    {
        DataTable dtJournal = new DataTable("Journal");
        public event Action<DataTable> fillJornal;
        SqlCommand command = new SqlCommand("", Registry_Class.sqlConnection);
        public string employee, discipline, group;

        public void dtJouranlCreate()
        {
            DataTable table = new DataTable();
            command.CommandText = "select * from [dbo].[Date_Create]('"+ employee + "','"
                + discipline + "','"+ group + "')";
            try
            {
                Registry_Class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
                dtJournal.Columns.Add();
                dtJournal.Rows.Add();
                foreach (DataRow dateRow in table.Rows)
                {
                    dtJournal.Columns.Add(dateRow[0].ToString());
                }
                table.Clear();
                command.CommandText = "select * from [dbo].[Student_List]" +
                    "(select [dbo].[Group].[ID_Group] from [dbo].[Group] " +
                    "where [dbo].[Group].[Group_name] = '"+group+"')";
                table.Load(command.ExecuteReader());
                foreach (DataRow studentRow in table.Rows)
                {
                    dtJournal.Rows.Add(studentRow[0].ToString());
                }
                table.Clear();
                for (int i = 1; i<dtJournal.Columns.Count; i++)
                    for (int j = 1; j<dtJournal.Rows.Count; j++)
                    {
                        command.CommandText = "select [dbo].[Students_Marks]('"
                            +dtJournal.Rows[i][0].ToString()+"','"
                            + dtJournal.Rows[0][j].ToString() + "')";
                        dtJournal.Rows[i][j] = command.ExecuteScalar().ToString();
                    }
                fillJornal(dtJournal);
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
