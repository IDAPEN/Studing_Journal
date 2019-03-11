using System;
using System.Data;
using System.Data.SqlClient;

namespace Studing_Journal
{
    class DataBaseTables
    {
        public SqlCommand command = new SqlCommand("",Registry_Class.sqlConnection);
        public DataTable dtAccess_rights = new DataTable("Access_rights");
        public DataTable dtProfile = new DataTable("Profile");
        public DataTable dtStandard = new DataTable("Standard");
        public DataTable dtDepartment = new DataTable("Department");
        public DataTable dtGroup = new DataTable("Group");
        public DataTable dtStudent = new DataTable("Student");
        public DataTable dtPost = new DataTable("Post");
        public DataTable dtEmployee = new DataTable("Employee");
        public DataTable dtCombination = new DataTable("Combination");
        public DataTable dtDiscipline = new DataTable("Discipline");
        public DataTable dtBurden = new DataTable("Burden");
        public DataTable dtExercise_Type = new DataTable("Exercise_Type");
        public DataTable dtJournal_of_the_lessons = new DataTable("Journal_of_the_lessons");
        public SqlDependency dependency = new SqlDependency();
        public string qrAccess_rights = "select [ID_Access_rights],[Access_rights_name],[Head_of_Department],[Teacher], [CCMC], [Director], [Deputy_Director],[Student] from[dbo].[Access_rights] where[Access_rights_Logical_Delete] = 0",
            qrProfile = "select [Login_Profile],[Password_Profile], [System_access], [Access_rights_ID],  [Profile_Image] from[dbo].[Profile] where[Profile_Logical_Delete] = 0 and[Login_Profile]<> ''",
            qrStandard = "select [ID_Standard], [Standard_name] from [dbo].[Standard] where [Standard_Logical_Delete] = 0",
            qrDepartment = "select [ID_Department],[Department_Number],[Department_Name],[Standard_ID], [Standard_name], [Department_Number]+' '+[Department_Name] as \"Departments_List\" from[dbo].[Department] inner join[dbo].[Standard] on[dbo].[Standard].[ID_Standard] = [dbo].[Department].[Standard_ID] where [Standard_Logical_Delete] = 0 and[Department_Logical_Delete] = 0",
            qrGroup = "select [ID_Group], [Group_name], [Department_ID],  [ID_Department],[Department_Number]+' '+[Department_Name] from[dbo].[Group] inner join[dbo].[Department] on[dbo].[Department].[ID_Department] = [dbo].[Group].[Department_ID] where[Group_Logical_Delete] = 0 and[Department_Logical_Delete] = 0",
            qrStudent = "select [Login_Student],[Surname_Student], [Name_Student],[Middle_name_Student],[Student_ticket_number],[Group_ID], [ID_Group], [Group_name], [Surname_Student]+' '+[Name_Student]+' '+[Middle_name_Student] as \"Full_Name\" from[dbo].[Student] inner join[dbo].[Group] on[dbo].[Group].[ID_Group] = [dbo].[Student].[Group_ID] inner join[dbo].[Department] on[dbo].[Department].[ID_Department] = [dbo].[Group].[Department_ID] where[Student_Logical_Delete] = 0 and[Group_Logical_Delete] = 0 and [Department_Logical_Delete] = 0",
            qrPost = "select [dbo].[Post].[ID_Post],[dbo].[Post].[Post_title], [dbo].[Post].[Post_ID] from[dbo].[Post] where[dbo].[Post].[Post_Logical_Delete] = 0",
            qrEmployee = "select[Login_Employee], [Surname_Employee], [Name_Employee], [Middle_name_Employee], [Surname_Employee] + ' ' + SUBSTRING([Name_Employee],1,1)+'. '+SUBSTRING([Middle_name_Employee],1,1)+'.' as \"Emploeyee_Info\" from[dbo].[Employee] where[dbo].[Employee].[Employee_Logical_Delete] = 0",
            qrCombination = "select [ID_Combination],[dbo].[Combination].[Post_ID],[Employee_Login], [Surname_Employee] + ' ' + SUBSTRING([Name_Employee],1,1)+'. '+SUBSTRING([Middle_name_Employee],1,1)+'.' as \"Emploeyee_Info\", [dbo].[Post].[Post_title] from[dbo].[Combination] inner join[dbo].[Employee] on[dbo].[Employee].[Login_Employee] = [dbo].[Combination].[Employee_Login] inner join[dbo].[Post] on[dbo].[Post].[ID_Post] = [dbo].[Combination].[Post_ID] where[dbo].[Employee].[Employee_Logical_Delete] = 0 and[dbo].[Post].[Post_Logical_Delete] = 0 and[dbo].[Combination].[Combination_Logical_Delete] = 0",
            qrDiscipline = "select[ID_Discipline], [Prefix],[The_name_of_the_discipline],[Prefix]+' '+[The_name_of_the_discipline] as \"Discipline_Info\" from[dbo].[Discipline] where[dbo].[Discipline].[Discipline_Logical_Delete] = 0",
            qrBurden = "select[ID_Burden],[Employee_Login],[Discipline_ID],[Group_ID],[Course],[ID_Discipline], [Prefix] + ' ' +[The_name_of_the_discipline] as \"Discipline_Info\", [Surname_Employee]+' '+SUBSTRING([Name_Employee],1,1)+'. '+SUBSTRING([Middle_name_Employee],1,1)+'.'as \"Emploeyee_Info\", [Group_name] from[dbo].[Burden]        inner join[dbo].[Discipline] on[dbo].[Discipline].[ID_Discipline] = [dbo].[Burden].[Discipline_ID]        inner join[dbo].[Employee] on[dbo].[Employee].[Login_Employee] = [dbo].[Burden].[Employee_Login] inner join[dbo].[Group] on[dbo].[Group].[ID_Group] = [dbo].[Burden].[Group_ID] where[dbo].[Burden].[Burden_Logical_Delete] = 0 and[dbo].[Employee].[Employee_Logical_Delete] = 0 and[dbo].[Discipline].[Discipline_Logical_Delete] = 0 and[dbo].[Group].[Group_Logical_Delete] = 0",
            qrExercise_Type = "select[ID_Exercise_Type], [Name_of_exercise] from[dbo].[Exercise_Type] where[dbo].[Exercise_Type].[Exercise_Type_Logical_Delete] = 0",
            qrJournal_of_the_lessons = "select[ID_Journal_of_the_lessons],[Current_Date],[Discipline],[Teacher],[Group],[Student],[Mark] from[dbo].[Journal_of_the_lessons] where[dbo].[Journal_of_the_lessons].[Journal_of_the_lessons_Logical_Delete] = 0";
        
        private void dtFill (DataTable table, string query)
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(Registry_Class.sqlConnection.ConnectionString);
                Registry_Class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
            }
            catch(Exception ex)
            {
                Registry_Class.error_message += "\n" 
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void dtAccess_rightsFill()
        {
            dtFill(dtAccess_rights, qrAccess_rights);
        }

        public void dtProfileFill()
        {
            dtFill(dtProfile, qrProfile);
        }

        public void dtStandardFill()
        {
            dtFill(dtStandard, qrStandard);
        }

        public void dtDepartmentFill()
        {
            dtFill(dtDepartment, qrDepartment);
        }

        public void dtGroupFill()
        {
            dtFill(dtGroup, qrGroup);
        }

        public void dtStudentFill()
        {
            dtFill(dtStudent, qrStudent);
        }

        public void dtPostFill()
        {
            dtFill(dtPost, qrPost);
        }

        public void dtEmployeeFill()
        {
            dtFill(dtEmployee, qrEmployee);
        }

        public void dtCombinationFill()
        {
            dtFill(dtCombination, qrCombination);
        }

        public void dtDisciplineFill()
        {
            dtFill(dtDiscipline, qrDiscipline);
        }

        public void dtBurdenFill()
        {
            dtFill(dtBurden, qrBurden);
        }

        public void dtExercise_TypeFill()
        {
            dtFill(dtExercise_Type, qrExercise_Type);
        }

        public void dtJournal_of_the_lessonsFill()
        {
            dtFill(dtJournal_of_the_lessons, qrJournal_of_the_lessons);
        }
    }
}
