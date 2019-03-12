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
        public DataTable dtCMC = new DataTable("CMC");
        public DataTable dtCMC_of_the_Department = new DataTable("CMC_of_the_Department");
        public DataTable dtEmployee_in_CMC = new DataTable("Employee_in_CMC");
        public DataTable dtPrefix = new DataTable("Prefix");
        public DataTable dtType_of_discipline = new DataTable("Type_of_discipline");
        public DataTable dtForm_of_Control = new DataTable("Form_of_Control");
        public DataTable dtDiscipline_of_CMC = new DataTable("Discipline_of_CMC");
        public DataTable dtDoCMC_Form_Control = new DataTable("DoCMC_Form_Control");
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
            qrDiscipline = "select[ID_Discipline], [The_name_of_the_discipline],[Prefix]+' '+[The_name_of_the_discipline] as \"Discipline_Info\" from[dbo].[Discipline] where[dbo].[Discipline].[Discipline_Logical_Delete] = 0",
            qrBurden = "select[ID_Burden],[Employee_Login],[Group_ID],[Course], [Surname_Employee]+' '+SUBSTRING([Name_Employee],1,1)+'. '+SUBSTRING([Middle_name_Employee],1,1)+'.'as \"Emploeyee_Info\", [Group_name], [dbo].[Burden].[Discipline_of_CMC_id], [Name_of_prefix]+' '+ [Prefix_number]+' '+[The_name_of_the_discipline] as \"Discipline_Info\", [Form_controls_value], [Workin_hours], [Examenation_hours] from [dbo].[Burden] inner join [dbo].[Discipline_of_CMC] on [dbo].[Discipline_of_CMC].[ID_Discipline_of_CMC] = [dbo].[Burden].[Discipline_of_CMC_id] inner join [dbo].[Discipline] on [dbo].[Discipline_of_CMC].[Discipline_id] = [dbo].[Discipline].[ID_Discipline] inner join [dbo].[Prefix] on [dbo].[Prefix].[ID_Prefix] = [dbo].[Discipline_of_CMC].[Prefix_id] inner join[dbo].[Employee] on[dbo].[Employee].[Login_Employee] = [dbo].[Burden].[Employee_Login] inner join[dbo].[Group] on[dbo].[Group].[ID_Group] = [dbo].[Burden].[Group_ID] where[dbo].[Burden].[Burden_Logical_Delete] = 0 and [dbo].[Employee].[Employee_Logical_Delete] = 0 and [dbo].[Discipline].[Discipline_Logical_Delete] = 0 and [dbo].[Group].[Group_Logical_Delete] = 0",
            qrExercise_Type = "select[ID_Exercise_Type], [Name_of_exercise] from[dbo].[Exercise_Type] where[dbo].[Exercise_Type].[Exercise_Type_Logical_Delete] = 0",
            qrJournal_of_the_lessons = "select[ID_Journal_of_the_lessons],[Current_Date],[Discipline],[Teacher],[Group],[Student],[Mark] from[dbo].[Journal_of_the_lessons] where[dbo].[Journal_of_the_lessons].[Journal_of_the_lessons_Logical_Delete] = 0",
            qrCMC = "select [id_cmc], [cmc_name] from [dbo].[cmc] where [cmc_logical_delete] = 0",
            qrCMC_of_the_Department = "select [ID_CMC_of_the_Department], [Department_id], [CMC_id], [ID_Department], [Department_Number]+' '+[Department_Name] as \"Department_Info\", [id_cmc], [cmc_name] from [dbo].[CMC_of_the_Department] inner join [dbo].[CMC] on [dbo].[CMC].[ID_CMC] = [dbo].[CMC_of_the_Department].[CMC_id] inner join [dbo].[Department] on [dbo].[Department].[ID_Department] = [dbo].[CMC_of_the_Department].[Department_id] where [dbo].[CMC_of_the_Department].[CMC_of_the_Department_Logical_Delete] = 0",
            qrEmployee_in_CMC = "select [ID_Employee_in_CMC], [CMC_id], [Employee_Login], [Role_in_CMC], [Surname_Employee]+' '+Substring([Name_Employee],1,1)+' '+SUBSTRING([Middle_name_Employee], 1,1) as \"Employee_Info\", [cmc_name] from [dbo].[Employee_in_CMC] inner join [dbo].[CMC] on [dbo].[CMC].[ID_CMC] = [dbo].[Employee_in_CMC].[CMC_id] inner join [dbo].[Employee] on [dbo].[Employee].[Login_Employee] = [dbo].[Employee_in_CMC].[Employee_Login] where [dbo].[Employee_in_CMC].[Employee_in_CMC_Logical_Delete] = 0",
            qrPrefix = "select [ID_Prefix], [Name_of_prefix] from [dbo].[Prefix] where [dbo].[Prefix].[Prefix_Logical_Delete] = 0",
            qrType_of_discipline = "select [ID_Type_of_discipline], [Name_of_the_type] from [dbo].[Type_of_discipline] where [dbo].[Type_of_discipline].[Type_of_discipline_Logical_Delete] = 0",
            qrForm_of_Control = "select [ID_Form_of_control], [Name_of_form] from [dbo].[Form_of_Control] where [dbo].[Form_of_Control].[Form_of_Control_Logical_Delete] = 0",
            qrDiscipline_of_CMC = "select [ID_Discipline_of_CMC], [CMC_id],[Prefix_id], [Prefix_number], [Name_of_prefix]+' '+ [Prefix_number]+' '+[The_name_of_the_discipline] as \"Discipline_Info\", [Discipline_id], [Type_of_discipline_id], [Full_hours], [Theory_hours], [Labaratory_hours], [Course_work_hours], [Discipline_of_CMC_id] ,[Name_of_the_type], [CMC_Name] from [dbo].[Discipline_of_CMC] inner join [dbo].[CMC] on [dbo].[Discipline_of_CMC].[CMC_id] = [dbo].[CMC].[ID_CMC] inner join [dbo].[Prefix] on [dbo].[Prefix].[ID_Prefix] = [dbo].[Discipline_of_CMC].[Prefix_id] inner join [dbo].[Discipline] on [dbo].[Discipline].[ID_Discipline] = [dbo].[Discipline_of_CMC].[Discipline_id] inner join [dbo].[Type_of_discipline] on [dbo].[Type_of_discipline].[ID_Type_of_discipline] = [dbo].[Discipline_of_CMC].[Type_of_discipline_id] where [dbo].[Discipline_of_CMC].[Discipline_of_CMC_Logical_Delete] = 0",
            qrDoCMC_Form_Control = "select [ID_DoCMC_Form_Control],[dbo].[DoCMC_Form_Control].[Discipline_of_CMC_id], [Form_of_control_id], [Semester], [Name_of_prefix]+' '+ [Prefix_number]+' '+[The_name_of_the_discipline] as \"Discipline_Info\", [Name_of_form] from [dbo].[DoCMC_Form_Control] inner join [dbo].[Discipline_of_CMC] on [dbo].[DoCMC_Form_Control].[Discipline_of_CMC_id] = [dbo].[Discipline_of_CMC].[ID_Discipline_of_CMC] inner join [dbo].[Discipline] on [dbo].[Discipline].[ID_Discipline] = [dbo].[Discipline_of_CMC].[Discipline_id] inner join [dbo].[Prefix] on [dbo].[Prefix].[ID_Prefix] = [dbo].[Discipline_of_CMC].[Prefix_id] inner join [Form_of_Control] on [dbo].[Form_of_Control].[ID_Form_of_control] = [dbo].[DoCMC_Form_Control].[Form_of_control_id] where [dbo].[DoCMC_Form_Control].[DoCMC_Form_Control_Logical_Delete] = 0 ";

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

        public void dtCMCFill()
        {
            dtFill(dtCMC, qrCMC);
        }

        public void dtCMC_of_the_DepartmentFill()
        {
            dtFill(dtCMC_of_the_Department, qrCMC_of_the_Department);
        }

        public void dtEmployee_in_CMCFill()
        {
            dtFill(dtEmployee_in_CMC, qrEmployee_in_CMC);
        }

        public void dtPrefixFill()
        {
            dtFill(dtPrefix, qrPrefix);
        }

        public void dtType_of_disciplineFill()
        {
            dtFill(dtType_of_discipline, qrType_of_discipline);
        }

        public void dtForm_of_ControlFill()
        {
            dtFill(dtForm_of_Control, qrForm_of_Control);
        }

        public void dtDiscipline_of_CMCFill()
        {
            dtFill(dtDiscipline_of_CMC, qrDiscipline_of_CMC);
        }

        public void dtDoCMC_Form_ControlFill()
        {
            dtFill(dtDoCMC_Form_Control, qrDoCMC_Form_Control);
        }
    }
}
