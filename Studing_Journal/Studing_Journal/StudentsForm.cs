using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Studing_Journal
{
    public partial class StudentsForm : Form
    {
        DataBaseProcedure procedure = new DataBaseProcedure();
        private int studentCoint = 0;
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void departmentFill()
        {
            Action action = () =>
             {
                 try
                 {
                     DataBaseTables data = new DataBaseTables();
                     data.dtDepartmentFill();
                     data.dependency.OnChange += onChangeDepartment;
                     cbDepartment.DataSource = data.dtDepartment;
                     cbDepartment.ValueMember = "ID_Department";
                     cbDepartment.DisplayMember = "Departments_List";
                 }
                 catch
                 {

                 }
             };
            Invoke(action);
        }

        private void onChangeDepartment (object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                departmentFill();
        }

        private void groupFill()
        {
            Action action = () =>
             {
                try
                 {
                     lbGroupValue.Text = "0";
                     lbStudentValue.Text = "0";
                     DataBaseTables data = new DataBaseTables();
                     data.qrGroup += " and [Department_ID] = " 
                     + cbDepartment.SelectedValue.ToString();
                     data.dtGroupFill();
                     data.dependency.OnChange += onChangeGroup;
                     cbGroup.DataSource = data.dtGroup;
                     cbGroup.ValueMember = "ID_Group";
                     cbGroup.DisplayMember = "Group_name";
                     cbGroup.Enabled = true;
                     statisticFill();
                     switch (lbGroupValue.Text)
                     {
                         case ("0"):
                             btStartEnd.Enabled = false;
                             break;
                         default:
                             btStartEnd.Enabled = true;
                             break;
                     }
                 }
                 catch
                 {
                     
                 }                                    
             };
            Invoke(action);
        }

        private void onChangeGroup(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                groupFill();
        }

        private void statisticFill()
        {
            Action action = () =>
             {
                 try
                 {
                     DataBaseView view = new DataBaseView();
                     view.qrvDepartment_statistic_Groups += 
                     " where [Department_name] = '" + cbDepartment.Text + "'";
                     view.dtvDepartment_statistic_Groups();
                     foreach (DataRow r in view.vdtDepartment_statistic_Groups.Rows)
                     {
                         lbGroupValue.Text = r[1].ToString();
                     }
                     view.qrvDepartment_statistic_Students += 
                     " where [Department_name] = '" + cbDepartment.Text + "'";
                     view.dtvDepartment_statistic_Students();
                     view.dependency.OnChange += onChengeDepartment;
                     foreach (DataRow r in view.vdtDepartment_statistic_Students.Rows)
                     {
                         lbStudentValue.Text = r[1].ToString();
                     }
                 }
                 catch
                 {

                 }
             };
            Invoke(action);
        }

        private void onChengeDepartment(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                statisticFill();
        }

        private void StudentFill()
        {
            Action action = () =>
             {
                 try
                 {
                     lbAvarageValue.Text = "00.00";
                     lbQualityValue.Text = "00.00";
                     lblPerfomanceValue.Text = "00.00";
                     DataBaseTables data = new DataBaseTables();
                     data.qrStudent += " and [Group_ID] = " 
                     + cbGroup.SelectedValue.ToString();
                     data.dtStudentFill();
                     data.dependency.OnChange += onChangeStudent;
                     dgvStudents.DataSource = data.dtStudent;
                     dgvStudents.Columns[0].Visible = false;
                     dgvStudents.Columns[1].HeaderText = "Фамилия";
                     dgvStudents.Columns[2].HeaderText = "Имя";
                     dgvStudents.Columns[3].HeaderText = "Отчество";
                     dgvStudents.Columns[4].HeaderText = "Номер студенческого";
                     dgvStudents.Columns[5].Visible = false;
                     dgvStudents.Columns[6].Visible = false;
                     dgvStudents.Columns[7].Visible = false;
                     dgvStudents.Columns[8].Visible = false;
                     gbStudents.Visible = true;
                     qualityFill();
                 }
                 catch
                 {
                     
                 }
             };
            Invoke(action);
        }

        private void onChangeQuality(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                qualityFill();
        }

        private void qualityFill()
        {
            Action action = () =>
             {
                 try
                 {
                     DataBaseView view = new DataBaseView();
                     view.qrvGroup_academic_performance += 
                     " where [Group_name] = '" + cbGroup.Text + "'";
                     view.dtvGroup_academic_performance();
                     view.dependency.OnChange += onChangeQuality;
                     foreach (DataRow r in view.vdtGroup_academic_performance.Rows)
                     {
                         lbAvarageValue.Text = r[1].ToString();
                         lbQualityValue.Text = r[2].ToString();
                         lblPerfomanceValue.Text = r[3].ToString();
                     }
                 }
                 catch
                 {

                 }
             };
            Invoke(action);
        }

        private void onChangeStudent(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                StudentFill();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(departmentFill);
            thread.Start();
        }

        private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(groupFill);
            thread.Start();
        }

        private void cbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(StudentFill);
            thread.Start();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbStudentLogin.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
            tbStudentSurname.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
            tbStudentName.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
            tbStudentMiddleName.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
            mtbTicketNumber.Text = dgvStudents.CurrentRow.Cells[4].Value.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btManupDepStnd_Click(object sender, EventArgs e)
        {
            StandartDepartmentForm standartDepartmentForm = new StandartDepartmentForm();
            standartDepartmentForm.ShowDialog(this);
        }

        private void dtManupgroup_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog(this);
        }

        private void btStartEnd_Click(object sender, EventArgs e)
        {
            switch (btStartEnd.Text)
            {
                case ("Актуализация списка"):
                    cbDepartment.Enabled = false;
                    cbGroup.Enabled = false;
                    btManupDepStnd.Enabled = false;
                    btManupgroup.Enabled = false;
                    gbStudentInform.Enabled = true;
                    dgvStudents.Enabled = true;
                    dgvStudents.Visible = true;
                    btStartEnd.Text = "Завершить работу";
                    break;
                case ("Завершить работу"):
                    cbDepartment.Enabled = true;
                    cbGroup.Enabled = true;
                    btManupDepStnd.Enabled = true;
                    btManupgroup.Enabled = true;
                    gbStudentInform.Enabled = false;
                    dgvStudents.Enabled = false;
                    dgvStudents.Visible = false;
                    cbStudentLogin.Items.Clear();
                    btStartEnd.Text = "Актуализация списка";
                    break;
            }
        }

        private void btError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Registry_Class.error_message);
        }

        private void btStudentInsert_Click(object sender, EventArgs e)
        {
            switch (cbStudentLogin.Text == "" || tbStudentName.Text == "" ||
                tbStudentSurname.Text == "" || tbStudentMiddleName.Text == "" ||
                mtbTicketNumber.Text == "")
            {
                case (true):
                    MessageBox.Show("Одно или несколько из полей не заполнены!");
                    break;
                case (false):
                    switch (btStudentInsert.Text)
                    {
                        case ("Добавить студента"):
                            DataBaseView view = new DataBaseView();
                            view.qrvProfiles_List += " where [Login_list] = '" + cbStudentLogin.Text + "' and [Status_list] = 'Студент'";
                            view.dtvProfiles_List();
                            try
                            {
                                procedure.spStudent_Insert(view.vdtProfiles_List.Rows[0][0].ToString(), tbStudentSurname.Text, tbStudentName.Text, tbStudentMiddleName.Text, mtbTicketNumber.Text, Convert.ToInt32(cbGroup.SelectedValue.ToString()));
                                cbStudentLogin.Items.Clear();
                                tbStudentMiddleName.Clear();
                                tbStudentName.Clear();
                                tbStudentSurname.Clear();
                                mtbTicketNumber.Clear();
                            }
                            catch
                            {
                                switch (MessageBox.Show("Данного студента нет в системе учётных записей! \n Создать новую учётную запись?", "Создание учётной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                                {
                                    case DialogResult.Yes:
                                        DynamicObjects dynamic = new DynamicObjects();
                                        dynamic.parentCreate = this;
                                        Thread thread1 = new Thread(dynamic.NewStudentAccountCreate);
                                        thread1.Start();
                                        break;
                                    case DialogResult.No:

                                        break;
                                }

                            }
                            break;
                        case ("Поменять учебную группу"):
                            DynamicObjects dynamicObjects = new DynamicObjects();
                            dynamicObjects.student = cbStudentLogin.Text;
                            dynamicObjects.parent = this;
                            Thread thread = new Thread(dynamicObjects.ChangeFormCreate);
                            thread.Start();
                            break;
                    }
                    break;
            }
        }

        private void cbStudentLogin_Leave(object sender, EventArgs e)
        {
            switch (studentCoint == 0 || cbStudentLogin.Text == "")
            {
                case (true):
                    btStudentInsert.Text = "Добавить студента";
                    tbStudentName.Clear();
                    tbStudentSurname.Clear();
                    tbStudentMiddleName.Clear();
                    mtbTicketNumber.Clear();
                    break;
                default:
                    btStudentInsert.Text = "Поменять учебную группу";
                    DataBaseTables data = new DataBaseTables();
                    data.qrStudent += " and [Login_Student] = '"+cbStudentLogin.Text+"'";
                    data.dtStudentFill();
                    foreach (DataRow r in data.dtStudent.Rows)
                    {
                        tbStudentSurname.Text = r[1].ToString();
                        tbStudentName.Text = r[2].ToString();
                        tbStudentMiddleName.Text = r[3].ToString();
                        mtbTicketNumber.Text = r[4].ToString();
                    }
                    break;
            }
        }

        private void cbStudentLogin_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                DataBaseTables tables = new DataBaseTables();
                tables.qrStudent += " and [Group_ID] = " + cbGroup.SelectedValue.ToString() + " and [Login_Student] like '%" + cbStudentLogin.Text + "%'";
                tables.dtStudentFill();
                cbStudentLogin.Items.Clear();
                foreach (DataRow r in tables.dtStudent.Rows)
                {
                    cbStudentLogin.Items.Add(r[0]);
                }
                cbStudentLogin.DroppedDown = true;
                cbStudentLogin.SelectionStart = cbStudentLogin.Text.Length;
                studentCoint = tables.dtStudent.Rows.Count;
            }
            catch
            {

            }
        }

        private void cbStudentLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
                cbStudentLogin_Leave(sender, e);
        }

        private void btStudentUpdate_Click(object sender, EventArgs e)
        {
            switch (cbStudentLogin.Text == "" || tbStudentName.Text == "" ||
                tbStudentSurname.Text == "" || tbStudentMiddleName.Text == "" ||
                mtbTicketNumber.Text == "")
            {
                case (true):
                    MessageBox.Show("Одно или несколько полей не заполнены!");
                    break;
                case (false):
                    procedure.spStudent_Update(cbStudentLogin.Text, tbStudentSurname.Text, tbStudentName.Text, tbStudentMiddleName.Text, mtbTicketNumber.Text, Convert.ToInt32(cbGroup.SelectedValue.ToString()));
                    break;
            }
        }

        private void btStudentDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись о студенте?", "Удаление студента",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spStudent_Delete(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void btWordStudentList_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empry"||Registry_Class.OrganizationName == "Empty"
                || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 || 
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    ApplicationConfigurationForm configurationForm = new ApplicationConfigurationForm();
                    configurationForm.ShowDialog();
                    break;
                case (false):
                    btWordStudentList.Enabled = false;
                    DataBaseTables data = new DataBaseTables();
                    data.qrStudent = "select ROW_NUMBER() over (order by [Surname_Student]  ASC) as \"№ПП\",[Surname_Student] +' '+ [Name_Student]+' '+[Middle_name_Student] as \"Фамилия Имя Отчество Студентов\" from [dbo].[Student] where [Group_ID] = " + cbGroup.SelectedValue.ToString();
                    data.dtStudentFill();
                    WordDocument document = new WordDocument();
                    document.table = data.dtStudent;
                    document.Group_name = cbGroup.Text;
                    document.student_list();
                    btWordStudentList.Enabled = true;
                    break;
            }
        }

        private void btExcelGroupList_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empry" || Registry_Class.OrganizationName == "Empty"
                || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    ApplicationConfigurationForm configurationForm = new ApplicationConfigurationForm();
                    configurationForm.ShowDialog();
                    break;
                case (false):
                    btExcelGroupList.Enabled = false;
                    DataBaseTables tables = new DataBaseTables();
                    tables.qrDiscipline = "select [dbo].[Discipline].[Prefix]+' '+[dbo].[Discipline].[The_name_of_the_discipline] from [dbo].[Group] join [dbo].[Burden] on [dbo].[Burden].[Group_ID] = [dbo].[Group].[ID_Group] join [dbo].[Discipline] on [dbo].[Discipline].[ID_Discipline] = [dbo].[Burden].[Discipline_ID] where [dbo].[Group].[Group_name] = '" + cbGroup.Text + "'";
                    tables.qrStudent = "select [Surname_Student]+' '+SUBSTRING([Name_Student],1,1)+'. '+SUBSTRING([Middle_name_Student],1,1)+'.' from [dbo].[Student] where [dbo].[Student].[Group_ID] = " + cbGroup.SelectedValue.ToString();
                    tables.dtDisciplineFill();
                    tables.dtStudentFill();
                    ExcelDocument document = new ExcelDocument();
                    document.Group_name = cbGroup.Text;
                    document.dtDiscipline = tables.dtDiscipline;
                    document.dtStudents = tables.dtStudent;
                    document.GroupDisciplineCreate();
                    btExcelGroupList.Enabled = true;
                    break;
            }
        }

        private void btWordGroupQuality_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empry" || Registry_Class.OrganizationName == "Empty"
                || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    ApplicationConfigurationForm configurationForm = new ApplicationConfigurationForm();
                    configurationForm.ShowDialog();
                    break;
                case (false):
                    btWordGroupQuality.Enabled = false;
                    WordDocument document = new WordDocument();
                    document.AVG = lbAvarageValue.Text;
                    document.QC = lbQualityValue.Text;
                    document.PC = lblPerfomanceValue.Text;
                    document.Group_name = cbGroup.Text;
                    document.quality_Group();
                    btWordGroupQuality.Enabled = true;
                    break;
            }
        }
    }
}
