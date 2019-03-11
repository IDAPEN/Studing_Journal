using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Studing_Journal
{
    class DataBaseView
    {
        SqlCommand command = new SqlCommand("", Registry_Class.sqlConnection);
        public DataTable vdtProfiles_List = new DataTable("Profiles_List");
        public DataTable vdtDepartment_statistic_Groups = new DataTable("Department_statistic_Groups");
        public DataTable vdtDepartment_statistic_Students = new DataTable("Department_statistic_Students");
        public DataTable vdtGroup_statistics_in_studing = new DataTable("Group_statistics_in_studing");
        public DataTable vdtGroup_academic_performance = new DataTable("Group_academic_performance");
        public DataTable vdtStudent_Marks = new DataTable("Student_Marks");
        public DataTable vdtEmployee_Burden = new DataTable("Employee_Burden");
        public SqlDependency dependency = new SqlDependency();
        public string qrvProfiles_List = "select [Login_list],[Password_list], [Status_list]  from [dbo].[Profiles_List]",
            qrvDepartment_statistic_Groups = "select [Department_name],[Groups_Count] from [dbo].[Department_statistic_Groups]",
            qrvDepartment_statistic_Students = "select [Department_name], [Students_count] from [dbo].[Department_statistic_Students]",
            qrvGroup_statistics_in_studing = "select [Group_name],[Middle_mark] from [dbo].[Group_statistics_in_studing]",
            qrvGroup_academic_performance = "select [Group_name],[Grade_point_average],[Quality_percentage],[Percentage_of_performance] from [dbo].[Group_academic_performance]",
            qrvStudent_Marks = "select [Student_Login],[Student_Info],[Disipline],[Mark] from [dbo].[Student_Marks]",
            qrvEmployee_Burden = "select [Employee_Login],[Employee_Info],[Discipline_Info],[Group_Info] from [dbo].[Employee_Burden]";
        private void dtvFill(DataTable table, string query)
        {
            command.CommandText = query;
            command.Notification = null;
            dependency.AddCommandDependency(command);
            try
            {
                SqlDependency.Start(Registry_Class.sqlConnection.ConnectionString);
                Registry_Class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
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

        public void dtvProfiles_List()
        {
            dtvFill(vdtProfiles_List, qrvProfiles_List);
        }

        public void dtvDepartment_statistic_Groups()
        {
            dtvFill(vdtDepartment_statistic_Groups, qrvDepartment_statistic_Groups);
        }

        public void dtvDepartment_statistic_Students()
        {
            dtvFill(vdtDepartment_statistic_Students, qrvDepartment_statistic_Students);
        }

        public void dtvGroup_statistics_in_studing()
        {
            dtvFill(vdtGroup_statistics_in_studing, qrvGroup_statistics_in_studing);
        }

        public void dtvGroup_academic_performance()
        {
            dtvFill(vdtGroup_academic_performance, qrvGroup_academic_performance);
        }

        public void dtvStudent_Marks()
        {
            dtvFill(vdtStudent_Marks, qrvStudent_Marks);
        }

        public void dtvEmployee_Burden()
        {
            dtvFill(vdtEmployee_Burden, qrvEmployee_Burden);
        }
    }
}
