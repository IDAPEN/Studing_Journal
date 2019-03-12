using System;
using System.Data.SqlClient;

namespace Studing_Journal
{
    class DataBaseProcedure
    {
        private SqlCommand cmd = new SqlCommand("Empty",Registry_Class.sqlConnection);
        private void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void spWork_at_a_lesson_Insert(string Student_Login,UInt32 Exercise_ID,string Student_work)
        {
            spConfiguration("Work_at_a_lesson_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Student_Login", Student_Login);
                cmd.Parameters.AddWithValue("@Exercise_ID", Exercise_ID);
                cmd.Parameters.AddWithValue("@Student_work", Student_work);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
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
       
        public void spWork_at_a_lesson_Update(string ID_Work_at_a_lesson, string Student_Login, Int32 Exercise_ID, string Student_work)
        {
            spConfiguration("Work_at_a_lesson_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Work_at_a_lesson", ID_Work_at_a_lesson);
                cmd.Parameters.AddWithValue("@Student_Login", Student_Login);
                cmd.Parameters.AddWithValue("@Exercise_ID", Exercise_ID);
                cmd.Parameters.AddWithValue("@Student_work", Student_work);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spWork_at_a_lesson_Delete(Int32 ID_Work_at_a_lesson)
        {
            spConfiguration("Work_at_a_lesson_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Work_at_a_lesson", ID_Work_at_a_lesson);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spWork_at_a_lesson_Logical_Delete(Int32 ID_Work_at_a_lesson)
        {
            spConfiguration("Work_at_a_lesson_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Work_at_a_lesson", ID_Work_at_a_lesson);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spExercise_New(Int32 Exercise_Type_ID, Int32 Burden_ID)
        {
            spConfiguration("Access_rights_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Exercise_Type_ID", Exercise_Type_ID);
                cmd.Parameters.AddWithValue("@Burden_ID", Burden_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spExercise_Delete(Int32 ID_Exercise)
        {
            spConfiguration("Exercise_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Exercise", ID_Exercise);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spExercise_Logical_Delete(Int32 ID_Exercise)
        {
            spConfiguration("Exercise_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Exercise", ID_Exercise);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spExercise_Type_Insert(string Name_of_exercise)
        {
            spConfiguration("Exercise_Type_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Name_of_exercise", Name_of_exercise);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spExercise_Type_Update(Int32 ID_Exercise_Type, string Name_of_exercise)
        {
            spConfiguration("Exercise_Type_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Exercise_Type", ID_Exercise_Type);
                cmd.Parameters.AddWithValue("@Name_of_exercise", Name_of_exercise);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spExercise_Type_Delete(Int32 ID_Exercise_Type)
        {
            spConfiguration("Exercise_Type_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Exercise_Type", ID_Exercise_Type);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spExercise_Type_Logical_Delete(Int32 ID_Exercise_Type)
        {
            spConfiguration("Exercise_Type_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Exercise_Type", ID_Exercise_Type);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
                
        public void spCombination_Insert(Int32 Post_ID, string Employee_Login)
        {
            spConfiguration("Combination_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Post_ID", Post_ID);
                cmd.Parameters.AddWithValue("@Employee_Login", Employee_Login);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spCombination_Update(Int32 ID_Combination, Int32 Post_ID, string Employee_Login)
        {
            spConfiguration("Combination_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Combination", ID_Combination);
                cmd.Parameters.AddWithValue("@Post_ID", Post_ID);
                cmd.Parameters.AddWithValue("@Employee_Login", Employee_Login);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spCombination_Delete(Int32 ID_Combination)
        {
            spConfiguration("Combination_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Combination", ID_Combination);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCombination_Logical_Delete(Int32 ID_Combination)
        {
            spConfiguration("Combination_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Combination", ID_Combination);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_Insert(string Login_Employee, string Surname_Employee, string Name_Employee, string Middle_name_Employee)
        {
            spConfiguration("Employee_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Employee", Login_Employee);
                cmd.Parameters.AddWithValue("@Surname_Employee", Surname_Employee);
                cmd.Parameters.AddWithValue("@Name_Employee", Name_Employee);
                cmd.Parameters.AddWithValue("@Middle_name_Employee", Middle_name_Employee);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_Update(string Login_Employee,string Surname_Employee,string Name_Employee, string Middle_name_Employee)
        {
            spConfiguration("Employee_Update");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Employee", Login_Employee);
                cmd.Parameters.AddWithValue("@Surname_Employee", Surname_Employee);
                cmd.Parameters.AddWithValue("@Name_Employee", Name_Employee);
                cmd.Parameters.AddWithValue("@Middle_name_Employee", Middle_name_Employee);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_Delete(string Login_Employee)
        {
            spConfiguration("Employee_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Employee", Login_Employee);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_Logical_Delete(string Login_Employee)
        {
            spConfiguration("Employee_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Employee", Login_Employee);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spPost_Insert(string Post_title, Int32 Post_ID)
        {
            spConfiguration("Post_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Post_title", Post_title);
                cmd.Parameters.AddWithValue("@Post_ID", Post_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spFirst_Post_Insert(string Post_title)
        {
            spConfiguration("First_Post_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Post_title", Post_title);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spPost_Update(Int32 ID_Post, string Post_title, Int32 Post_ID)
        {
            spConfiguration("Post_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Post", ID_Post);
                cmd.Parameters.AddWithValue("@Post_title", Post_title);
                cmd.Parameters.AddWithValue("@Post_ID", Post_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spPost_Delete(Int32 ID_Post)
        {
            spConfiguration("Post_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Post", ID_Post);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spPost_Logical_Delete(Int32 ID_Post)
        {
            spConfiguration("Post_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Post", ID_Post);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spStudent_Insert(string Login_Student, string Surname_Student, string Name_Student, string Middle_name_Student, string Student_ticket_number, Int32 Group_ID)
        {
            spConfiguration("Student_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Student", Login_Student);
                cmd.Parameters.AddWithValue("@Surname_Student", Surname_Student);
                cmd.Parameters.AddWithValue("@Name_Student", Name_Student);
                cmd.Parameters.AddWithValue("@Middle_name_Student", Middle_name_Student);
                cmd.Parameters.AddWithValue("@Student_ticket_number", Student_ticket_number);
                cmd.Parameters.AddWithValue("@Group_ID", Group_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spStudent_Update(string Login_Student, string Surname_Student, string Name_Student, string Middle_name_Student, string Student_ticket_number, Int32 Group_ID)
        {
            spConfiguration("Student_Update");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Student",Login_Student);
                cmd.Parameters.AddWithValue("@Surname_Student",Surname_Student);
                cmd.Parameters.AddWithValue("@Name_Student",Name_Student);
                cmd.Parameters.AddWithValue("@Middle_name_Student",Middle_name_Student);
                cmd.Parameters.AddWithValue("@Student_ticket_number",Student_ticket_number);
                cmd.Parameters.AddWithValue("@Group_ID",Group_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
                
        public void spStudent_Delete(string Login_Student)
        {
            spConfiguration("Student_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Student", Login_Student);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spStudent_Logical_Delete(string Login_Student)
        {
            spConfiguration("Student_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Student", Login_Student);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spGroup_Insert(string Group_name, Int32 Department_ID)
        {
            spConfiguration("Group_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Group_name", Group_name);
                cmd.Parameters.AddWithValue("@Department_ID", Department_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spGroup_Update(Int32 ID_Group, string Group_name, Int32 Department_ID)
        {
            spConfiguration("Group_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Group",ID_Group);
                cmd.Parameters.AddWithValue("@Group_name",Group_name);
                cmd.Parameters.AddWithValue("@Department_ID",Department_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
   
        public void spGroup_Delete(Int32 ID_Group)
        {
            spConfiguration("Group_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Group", ID_Group);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spGroup_Logical_Delete(Int32 ID_Group)
        {
            spConfiguration("Group_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Group", ID_Group);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
   
        public void spDepartment_Insert(string Department_Number, string Department_Name, Int32 Standard_ID)
        {
            spConfiguration("Department_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Department_Number", Department_Number);
                cmd.Parameters.AddWithValue("@Department_Name", Department_Name);
                cmd.Parameters.AddWithValue("@Standard_ID", Standard_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
        
        public void spDepartment_Update(Int32 ID_Department, string Department_Number, string Department_Name, Int32 Standard_ID)
        {
            spConfiguration("Department_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Department",ID_Department);
                cmd.Parameters.AddWithValue("@Department_Number",Department_Number);
                cmd.Parameters.AddWithValue("@Department_Name",Department_Name);
                cmd.Parameters.AddWithValue("@Standard_ID",Standard_ID);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDepartment_Delete(Int32 ID_Department)
        {
            spConfiguration("Department_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Department", ID_Department);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDepartment_Logical_Delete(Int32 ID_Department)
        {
            spConfiguration("Department_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Department", ID_Department);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spStandard_Insert(string Standard_name)
        {
            spConfiguration("Standard_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Standard_name", Standard_name);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spStandard_Update(Int32 ID_Standard, string Standard_name)
        {
            spConfiguration("Standard_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Standard", ID_Standard);
                cmd.Parameters.AddWithValue("@Standard_name", Standard_name);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spStandard_Delete(Int32 ID_Standard)
        {
            spConfiguration("Standard_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Standard", ID_Standard);
                Registry_Class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spStandard_Logical_Delete(Int32 ID_Standard)
        {
            spConfiguration("Standard_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Standard", ID_Standard);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spProfile_New_User(string Login_Profile, string Password_Profile, Int32 Access_rights_ID, Int32 System_access, string Profile_Image)
        {
            spConfiguration("Profile_New_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                cmd.Parameters.AddWithValue("@Password_Profile", Password_Profile);
                cmd.Parameters.AddWithValue("@Access_rights_ID", Access_rights_ID);
                cmd.Parameters.AddWithValue("@System_access", System_access);
                cmd.Parameters.AddWithValue("@Profile_Image", Profile_Image);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spProfile_Update_User(string Login_Profile, string Password_Profile, Int32 Access_rights_ID, Int32 System_access, string Profile_Image)
        {
            spConfiguration("Profile_Update_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                cmd.Parameters.AddWithValue("@Password_Profile", Password_Profile);
                cmd.Parameters.AddWithValue("@Access_rights_ID", Access_rights_ID);
                cmd.Parameters.AddWithValue("@System_access", System_access);
                cmd.Parameters.AddWithValue("@Profile_Image", Profile_Image);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spProfile_Delete_User(string Login_Profile)
        {
            spConfiguration("Profile_Delete_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spProfile_Logical_Delete(string Login_Profile)
        {
            spConfiguration("Profile_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spProfile_Block_User(string Login_Profile)
        {
            spConfiguration("Profile_Block_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spProfile_Unblok_User(string Login_Profile)
        {
            spConfiguration("Profile_Unblok_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spAccess_rights_Insert(string Access_rights_name, Int32 Head_of_Department,
        Int32 Teacher, Int32 CCMC, Int32 Director, Int32 Deputy_Director, Int32 Student)
        {
            spConfiguration("Access_rights_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Access_rights_name", Access_rights_name);
                cmd.Parameters.AddWithValue("@Head_of_Department", Head_of_Department);
                cmd.Parameters.AddWithValue("@Teacher", Teacher);
                cmd.Parameters.AddWithValue("@CCMC", CCMC);
                cmd.Parameters.AddWithValue("@Director", Director);
                cmd.Parameters.AddWithValue("@Deputy_Director", Deputy_Director);
                cmd.Parameters.AddWithValue("@Student", Student);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spAccess_rights_Update(Int32 ID_Access_rights, string Access_rights_name, Int32 Head_of_Department,
        Int32 Teacher, Int32 CCMC, Int32 Director, Int32 Deputy_Director, Int32 Student)
        {
            spConfiguration("Access_rights_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Access_rights", ID_Access_rights);
                cmd.Parameters.AddWithValue("@Access_rights_name", Access_rights_name);
                cmd.Parameters.AddWithValue("@Head_of_Department", Head_of_Department);
                cmd.Parameters.AddWithValue("@Teacher", Teacher);
                cmd.Parameters.AddWithValue("@CCMC", CCMC);
                cmd.Parameters.AddWithValue("@Director", Director);
                cmd.Parameters.AddWithValue("@Deputy_Director", Deputy_Director);
                cmd.Parameters.AddWithValue("@Student", Student);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spAccess_rights_Delete(Int32 ID_Access_rights)
        {
            spConfiguration("Access_rights_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Access_rights", ID_Access_rights);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spAccess_rights_Logical_Delete(Int32 ID_Access_rights)
        {
            spConfiguration("Access_rights_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Access_rights", ID_Access_rights);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n"+DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spBurden_Insert(string Employee_Login, Int32 Discipline_of_CMC_id, Int32 Group_ID,
            Int32 Course, string Form_controls_value, decimal Workin_hours, decimal Examenation_hours)
        {
            spConfiguration("Burden_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Employee_Login", Employee_Login);
                cmd.Parameters.AddWithValue("@Discipline_of_CMC_id", Discipline_of_CMC_id);
                cmd.Parameters.AddWithValue("@Group_ID", Group_ID);
                cmd.Parameters.AddWithValue("@Course", Course);
                cmd.Parameters.AddWithValue("@Form_controls_value", Form_controls_value);
                cmd.Parameters.AddWithValue("@Workin_hours", Workin_hours);
                cmd.Parameters.AddWithValue("@Examenation_hours", Examenation_hours);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spBurden_Update(Int32 ID_Burden, string Employee_Login, Int32 Discipline_of_CMC_id, Int32 Group_ID,
            Int32 Course, string Form_controls_value, decimal Workin_hours, decimal Examenation_hours)
        {
            spConfiguration("Burden_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Burden", ID_Burden);
                cmd.Parameters.AddWithValue("@Employee_Login", Employee_Login);
                cmd.Parameters.AddWithValue("@Discipline_of_CMC_id", Discipline_of_CMC_id);
                cmd.Parameters.AddWithValue("@Group_ID", Group_ID);
                cmd.Parameters.AddWithValue("@Course", Course);
                cmd.Parameters.AddWithValue("@Form_controls_value", Form_controls_value);
                cmd.Parameters.AddWithValue("@Workin_hours", Workin_hours);
                cmd.Parameters.AddWithValue("@Examenation_hours", Examenation_hours);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spBurden_Delete(Int32 ID_Burden)
        {
            spConfiguration("Burden_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Burden", ID_Burden);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spBurden_Logical_Delete(Int32 ID_Burden)
        {
            spConfiguration("Burden_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Burden", ID_Burden);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_insert(string CMC_Name)
        {
            spConfiguration("CMC_insert");
            try
            {
                cmd.Parameters.AddWithValue("@CMC_Name", CMC_Name);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_update(Int32 ID_CMC, string CMC_Name)
        {
            spConfiguration("CMC_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_CMC", ID_CMC);
                cmd.Parameters.AddWithValue("@CMC_Name", CMC_Name);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_delete(Int32 ID_CMC)
        {
            spConfiguration("CMC_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_CMC", ID_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_Logical_delete(Int32 ID_CMC)
        {
            spConfiguration("CMC_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_CMC", ID_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_of_the_Department_insert(Int32 Department_id, Int32 CMC_id)
        {
            spConfiguration("CMC_of_the_Department_insert");
            try
            {
                cmd.Parameters.AddWithValue("@Department_id", Department_id);
                cmd.Parameters.AddWithValue("@CMC_id", CMC_id);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_of_the_Department_update(Int32 ID_CMC_of_the_Department, Int32 Department_id, Int32 CMC_id)
        {
            spConfiguration("CMC_of_the_Department_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_CMC_of_the_Department", ID_CMC_of_the_Department);
                cmd.Parameters.AddWithValue("@Department_id", Department_id);
                cmd.Parameters.AddWithValue("@CMC_id", CMC_id);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_of_the_Department_delete(Int32 ID_CMC_of_the_Department)
        {
            spConfiguration("CMC_of_the_Department_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_CMC_of_the_Department", ID_CMC_of_the_Department);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spCMC_of_the_Department_Logical_delete(Int32 ID_CMC_of_the_Department)
        {
            spConfiguration("CMC_of_the_Department_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_CMC_of_the_Department", ID_CMC_of_the_Department);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_in_CMC_insert(Int32 CMC_id, string Employee_Login, string Role_in_CMC)
        {
            spConfiguration("Employee_in_CMC_insert");
            try
            {
                cmd.Parameters.AddWithValue("@CMC_id", CMC_id);
                cmd.Parameters.AddWithValue("@Employee_Login", Employee_Login);
                cmd.Parameters.AddWithValue("@Role_in_CMC", Role_in_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_in_CMC_update(Int32 ID_Employee_in_CMC, Int32 CMC_id, string Employee_Login, string Role_in_CMC)
        {
            spConfiguration("Employee_in_CMC_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Employee_in_CMC", ID_Employee_in_CMC);
                cmd.Parameters.AddWithValue("@CMC_id", CMC_id);
                cmd.Parameters.AddWithValue("@Employee_Login", Employee_Login);
                cmd.Parameters.AddWithValue("@Role_in_CMC", Role_in_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_in_CMC_delete(Int32 ID_Employee_in_CMC)
        {
            spConfiguration("Employee_in_CMC_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Employee_in_CMC", ID_Employee_in_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spEmployee_in_CMC_Logical_delete(Int32 ID_Employee_in_CMC)
        {
            spConfiguration("Employee_in_CMC_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Employee_in_CMC", ID_Employee_in_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spPrefix_insert(string Name_of_prefix)
        {
            spConfiguration("Prefix_insert");
            try
            {
                cmd.Parameters.AddWithValue("@Name_of_prefix", Name_of_prefix);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spPrefix_update(Int32 ID_Prefix, string Name_of_prefix)
        {
            spConfiguration("Prefix_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Prefix", ID_Prefix);
                cmd.Parameters.AddWithValue("@Name_of_prefix", Name_of_prefix);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spPrefix_delete(Int32 ID_Prefix)
        {
            spConfiguration("Prefix_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Prefix", ID_Prefix);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spPrefix_Logical_delete(Int32 ID_Prefix)
        {
            spConfiguration("Prefix_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Prefix", ID_Prefix);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spType_of_discipline_insert(string Name_of_the_type)
        {
            spConfiguration("Type_of_discipline_insert");
            try
            {
                cmd.Parameters.AddWithValue("@Name_of_the_type", Name_of_the_type);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spType_of_discipline_update(Int32 ID_Type_of_discipline, string Name_of_the_type)
        {
            spConfiguration("Type_of_discipline_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Type_of_discipline", ID_Type_of_discipline);
                cmd.Parameters.AddWithValue("@Name_of_the_type", Name_of_the_type);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spType_of_discipline_delete(Int32 ID_Type_of_discipline)
        {
            spConfiguration("Type_of_discipline_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Type_of_discipline", ID_Type_of_discipline);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spType_of_discipline_Logical_delete(Int32 ID_Type_of_discipline)
        {
            spConfiguration("Type_of_discipline_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Type_of_discipline", ID_Type_of_discipline);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spForm_of_Control_insert(string Name_of_form)
        {
            spConfiguration("Form_of_Control_insert");
            try
            {
                cmd.Parameters.AddWithValue("@Name_of_form", Name_of_form);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spForm_of_Control_update(Int32 ID_Form_of_control, string Name_of_form)
        {
            spConfiguration("Form_of_Control_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Form_of_control", ID_Form_of_control);
                cmd.Parameters.AddWithValue("@Name_of_form", Name_of_form);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spForm_of_Control_delete(Int32 ID_Form_of_control)
        {
            spConfiguration("Form_of_Control_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Form_of_control", ID_Form_of_control);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spForm_of_Control_Logical_delete(Int32 ID_Form_of_control)
        {
            spConfiguration("Form_of_Control_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Form_of_control", ID_Form_of_control);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_of_CMC_insert(Int32 CMC_id, Int32 Prefix_id, string Prefix_number,
            Int32 Discipline_id, Int32 Type_of_discipline_id, decimal Full_hours, decimal Theory_hours, decimal Labaratory_hours,
            decimal Course_work_hours, Int32 Discipline_of_CMC_id)
        {
            spConfiguration("Discipline_of_CMC_insert");
            try
            {
                cmd.Parameters.AddWithValue("@CMC_id", CMC_id);
                cmd.Parameters.AddWithValue("@Prefix_id", Prefix_id);
                cmd.Parameters.AddWithValue("@Prefix_number", Prefix_number);
                cmd.Parameters.AddWithValue("@Discipline_id", Discipline_id);
                cmd.Parameters.AddWithValue("@Type_of_discipline_id", Type_of_discipline_id);
                cmd.Parameters.AddWithValue("@Full_hours", Full_hours);
                cmd.Parameters.AddWithValue("@Theory_hours", Theory_hours);
                cmd.Parameters.AddWithValue("@Labaratory_hours", Labaratory_hours);
                cmd.Parameters.AddWithValue("@Course_work_hours", Course_work_hours);
                cmd.Parameters.AddWithValue("@Discipline_of_CMC_id", Discipline_of_CMC_id);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_of_CMC_update(Int32 ID_Discipline_of_CMC, Int32 CMC_id, Int32 Prefix_id, string Prefix_number,
            Int32 Discipline_id, Int32 Type_of_discipline_id, decimal Full_hours, decimal Theory_hours, decimal Labaratory_hours,
            decimal Course_work_hours, Int32 Discipline_of_CMC_id)
        {
            spConfiguration("Discipline_of_CMC_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Discipline_of_CMC", ID_Discipline_of_CMC);
                cmd.Parameters.AddWithValue("@CMC_id", CMC_id);
                cmd.Parameters.AddWithValue("@Prefix_id", Prefix_id);
                cmd.Parameters.AddWithValue("@Prefix_number", Prefix_number);
                cmd.Parameters.AddWithValue("@Discipline_id", Discipline_id);
                cmd.Parameters.AddWithValue("@Type_of_discipline_id", Type_of_discipline_id);
                cmd.Parameters.AddWithValue("@Full_hours", Full_hours);
                cmd.Parameters.AddWithValue("@Theory_hours", Theory_hours);
                cmd.Parameters.AddWithValue("@Labaratory_hours", Labaratory_hours);
                cmd.Parameters.AddWithValue("@Course_work_hours", Course_work_hours);
                cmd.Parameters.AddWithValue("@Discipline_of_CMC_id", Discipline_of_CMC_id);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_of_CMC_delete(Int32 ID_Discipline_of_CMC)
        {
            spConfiguration("Discipline_of_CMC_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Discipline_of_CMC", ID_Discipline_of_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_of_CMC_Logical_delete(Int32 ID_Discipline_of_CMC)
        {
            spConfiguration("Discipline_of_CMC_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Discipline_of_CMC", ID_Discipline_of_CMC);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDoCMC_Form_Control_insert(Int32 Discipline_of_CMC_id, Int32 Form_of_control_id, string Semester)
        {
            spConfiguration("DoCMC_Form_Control_insert");
            try
            {
                cmd.Parameters.AddWithValue("@Discipline_of_CMC_id", Discipline_of_CMC_id);
                cmd.Parameters.AddWithValue("@Form_of_control_id", Form_of_control_id);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDoCMC_Form_Control_update(Int32 ID_DoCMC_Form_Control, Int32 Discipline_of_CMC_id, Int32 Form_of_control_id,
            string Semester)
        {
            spConfiguration("DoCMC_Form_Control_update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_DoCMC_Form_Control", ID_DoCMC_Form_Control);
                cmd.Parameters.AddWithValue("@Discipline_of_CMC_id", Discipline_of_CMC_id);
                cmd.Parameters.AddWithValue("@Form_of_control_id", Form_of_control_id);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDoCMC_Form_Control_delete(Int32 ID_DoCMC_Form_Control)
        {
            spConfiguration("DoCMC_Form_Control_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_DoCMC_Form_Control", ID_DoCMC_Form_Control);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDoCMC_Form_Control_Logical_delete(Int32 ID_DoCMC_Form_Control)
        {
            spConfiguration("DoCMC_Form_Control_Logical_delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_DoCMC_Form_Control", ID_DoCMC_Form_Control);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_Insert(string The_name_of_the_discipline)
        {
            spConfiguration("Discipline_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@The_name_of_the_discipline", The_name_of_the_discipline);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_Update(Int32 ID_Discipline, string The_name_of_the_discipline)
        {
            spConfiguration("Discipline_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Discipline", ID_Discipline);
                cmd.Parameters.AddWithValue("@The_name_of_the_discipline", The_name_of_the_discipline);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_Delete(Int32 ID_Discipline)
        {
            spConfiguration("Discipline_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Discipline", ID_Discipline);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void spDiscipline_Logical_Delete(Int32 ID_Discipline)
        {
            spConfiguration("Discipline_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Discipline", ID_Discipline);
                Registry_Class.sqlConnection.Open();
                Registry_Class.sqlConnection.InfoMessage += message;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        private void message(object sender, SqlInfoMessageEventArgs e)
        {
            Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + e.Message;
        }
    }
}