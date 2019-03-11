using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Studing_Journal
{
    public partial class BurdenCombinationEmployeeForm : Form
    {
        DataBaseTables dataComb = new DataBaseTables();
        private string Combinationqr = "";
        int EmployeeCount = 0;
        public string OldPassword = "";
        public int OldRole = 0;
        public BurdenCombinationEmployeeForm()
        {
            InitializeComponent();
        }

        private void accessRightsFill()
        {
            Action action = () =>
             {
                 DataBaseTables tables = new DataBaseTables();
                 tables.dtAccess_rightsFill();
                 tables.dependency.OnChange += onchangeAccessRights;
                 cbAccessRights.DataSource = tables.dtAccess_rights;
                 cbAccessRights.ValueMember = "ID_Access_rights";
                 cbAccessRights.DisplayMember = "Access_rights_name";
             };
            Invoke(action);
        }

        private void onchangeAccessRights(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                accessRightsFill();
        }

        private void employeeFill()
        {
            Action action = () =>
            {
                DataBaseTables tables = new DataBaseTables();
                tables.dtEmployeeFill();
                tables.dependency.OnChange += onchangeEmployee;
                dgvEmployee.DataSource = tables.dtEmployee;
                dgvEmployee.Columns[0].Visible = false;
                dgvEmployee.Columns[1].HeaderText = "Фамилия";
                dgvEmployee.Columns[2].HeaderText = "Имя";
                dgvEmployee.Columns[3].HeaderText = "Отчество";
                dgvEmployee.Columns[4].Visible = false;
            };
            Invoke(action);
        }

        private void onchangeEmployee(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                employeeFill();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Registry_Class.error_message);
        }

        private void cbLogin_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                DataBaseTables table = new DataBaseTables();
                table.qrEmployee += " and [Login_Employee] like '%" + cbLogin.Text + "%'";
                table.dtEmployeeFill();
                cbLogin.Items.Clear();
                foreach (DataRow r in table.dtEmployee.Rows)
                {
                    cbLogin.Items.Add(r[0]);
                }
                cbLogin.DroppedDown = true;
                cbLogin.SelectionStart = cbLogin.Text.Length;
                EmployeeCount = table.dtEmployee.Rows.Count;
            }
            catch
            {

            }
        }

        private void cbLogin_Leave(object sender, EventArgs e)
        {
            switch (EmployeeCount == 0 || cbLogin.Text == "")
            {
                case (true):
                    tbPassword.Clear();
                    tbConfPass.Clear();
                    tbSurName.Clear();
                    tbName.Clear();
                    tbMiddleName.Clear();
                    break;
                case (false):
                    DataBaseTables tables = new DataBaseTables();
                    tables.qrEmployee += " and [Login_Employee] like '%" + cbLogin.Text + "%'";
                    tables.qrProfile += " and [Login_Profile] like '%" + cbLogin.Text + "%'";
                    tables.dtProfileFill();
                    tables.dtEmployeeFill();
                    foreach (DataRow r in tables.dtEmployee.Rows)
                    {
                        tbSurName.Text = r[1].ToString();
                        tbName.Text = r[2].ToString();
                        tbMiddleName.Text = r[3].ToString();
                    }
                    foreach (DataRow r in tables.dtProfile.Rows)
                    {
                        try
                        {
                            OldPassword = r[1].ToString();
                            cbAccessRights.SelectedValue = r[3].ToString();
                            OldRole = Convert.ToInt32(r[3].ToString());
                            tbImagePath.Text = r[4].ToString();
                            pbProfile.Load(r[4].ToString());
                        }
                        catch
                        {

                        }
                    }
                    break;
            }
        }

        private void cbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
                cbLogin_Leave(sender, e);
        }

        private void BurdenCombinationEmployeeForm_Load(object sender, EventArgs e)
        {
            Combinationqr = dataComb.qrCombination;
            Burdenqr = tablesBurden.qrBurden;
            Thread threadAccess = new Thread(accessRightsFill);
            Thread threadEmployee = new Thread(employeeFill);
            threadAccess.Start();
            threadEmployee.Start();
            Thread threadEmployeeComb = new Thread(ltbEmployeeFill);
            Thread threadPostsComb = new Thread(ltbPostsFill);
            Thread threadCombination = new Thread(dgvCombinationFill);
            threadEmployeeComb.Start();
            threadPostsComb.Start();
            threadCombination.Start();
            Thread threadDepartment = new Thread(cbDepartmentFill);
            threadDepartment.Start();
        }

        private void btImagePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tbImagePath.Text = openFileDialog1.FileName;
            pbProfile.Load(tbImagePath.Text);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbLogin.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            cbLogin_TextUpdate(sender, e);
            cbLogin_Leave(sender, e);
        }

        private void btInsertUpdate_Click(object sender, EventArgs e)
        {
            switch (tbPassword.Text != tbConfPass.Text)
            {
                case (true):
                    tbPassword.Clear();
                    tbConfPass.Clear();
                    Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " пароли не совпадают!";
                    btError_Click(sender, e);
                    break;
                case (false):
                    switch (EmployeeCount)
                    {
                        case (0):
                            switch (MessageBox.Show(
                                "Создать ноую учётную запись:" +
                                "\n Логин: " + cbLogin.Text + "," +
                                "\n Права доступа: " + cbAccessRights.Text + "," +
                                "\n Персональные данные:" +
                                "\n Фамилия: " + tbSurName.Text + "," +
                                "\n Имя:" + tbName.Text + "," +
                                "\n Отчество: " + tbMiddleName.Text + ".", "Создание нового сотрудника",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question))
                            {
                                case DialogResult.Yes:
                                    DataBaseProcedure procedure = new DataBaseProcedure();
                                    procedure.spProfile_New_User(cbLogin.Text, tbPassword.Text, Convert.ToInt32(cbAccessRights.SelectedValue.ToString()), 0, tbImagePath.Text);
                                    cbLogin.Text = "";
                                    tbPassword.Clear();
                                    tbConfPass.Clear();
                                    tbSurName.Clear();
                                    tbName.Clear();
                                    tbMiddleName.Clear();
                                    tbImagePath.Clear();
                                    break;
                            }
                            break;
                        default:
                            switch (OldPassword == tbPassword.Text)
                            {
                                case (true):
                                    int access = 0;
                                    switch (OldRole == Convert.ToInt32(cbAccessRights.SelectedValue.ToString()))
                                    {
                                        case (true):
                                            access = 1;
                                            break;
                                        case (false):
                                            access = 0;
                                            break;
                                    }
                                    DataBaseProcedure procedure = new DataBaseProcedure();
                                    procedure.spProfile_Update_User(cbLogin.Text, tbPassword.Text,
                       Convert.ToInt32(cbAccessRights.SelectedValue.ToString()), access, tbImagePath.Text);
                                    procedure.spEmployee_Update(cbLogin.Text, tbSurName.Text,
                                        tbName.Text, tbMiddleName.Text);
                                    break;
                                case (false):
                                    DynamicObjects dynamicObjects = new DynamicObjects();
                                    dynamicObjects.parentCheck = this;
                                    dynamicObjects.createCheckPass();
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            bool deleteEmployee = false, deleteProfile = false;
            switch (MessageBox.Show(
                "Удалить сотрудника " + tbSurName.Text + " " + tbName.Text + " " + tbMiddleName.Text + "?", "Удаление сотрудника",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    deleteEmployee = true;
                    break;
            }

            switch (MessageBox.Show(
                "Удалить профиль " + cbLogin.Text + "?", "Удаление профиля",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    deleteProfile = true;
                    break;
            }
            DataBaseProcedure procedure = new DataBaseProcedure();
            switch (deleteEmployee)
            {
                case (true):
                    procedure.spEmployee_Delete(cbLogin.Text);
                    switch (deleteProfile)
                    {
                        case (true):
                            procedure.spProfile_Delete_User(cbLogin.Text);
                            break;
                    }
                    break;
            }
        }

        

        private void btEmployeeEdit_Click(object sender, EventArgs e)
        {
            tcEmployeeManupulation.SelectedIndex = 0;
        }

        private void btPostsEdit_Click(object sender, EventArgs e)
        {
            PostForm postForm = new PostForm();
            postForm.Show(this);
        }

        private void ltbEmployeeFill()
        {
            Action action = () =>
             {
                 DataBaseTables data = new DataBaseTables();
                 data.dtEmployeeFill();
                 data.dependency.OnChange += onchangeEmlFill;
                 ltbEmployee.DataSource = data.dtEmployee;
                 ltbEmployee.ValueMember = "Login_Employee";
                 ltbEmployee.DisplayMember = "Emploeyee_Info";
             };
            Invoke(action);
        }

        private void onchangeEmlFill(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                ltbEmployeeFill();
        }

        private void ltbPostsFill()
        {
            Action action = () =>
            {
                DataBaseTables data = new DataBaseTables();
                data.dtPostFill();
                data.dependency.OnChange += onchangePost;
                ltbPosts.DataSource = data.dtPost;
                ltbPosts.ValueMember = "ID_Post";
                ltbPosts.DisplayMember = "Post_title";
            };
            Invoke(action);
        }

        private void onchangePost(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                ltbPostsFill();
        }

        private void dgvCombinationFill()
        {
            Action action = () =>
            {
                try
                {
                    dataComb.dtCombination.Clear();
                    dataComb.dtCombinationFill();
                    dataComb.dependency.OnChange += onchaangeCombination;
                }
                catch
                {

                }
                finally
                {
                    dgvCombination.DataSource = dataComb.dtCombination;
                    dgvCombination.Columns[0].Visible = false;
                    dgvCombination.Columns[1].Visible = false;
                    dgvCombination.Columns[2].Visible = false;
                    dgvCombination.Columns[3].HeaderText = "Фамилия, иницыалы сотрудника";
                    dgvCombination.Columns[4].HeaderText = "Занимаемая должность";
                }
            };
            Invoke(action);
        }

        private void onchaangeCombination(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dgvCombinationFill();
        }

        private void btInsertCom_Click(object sender, EventArgs e)
        {
            DataBaseProcedure procedure = new DataBaseProcedure();
            procedure.spCombination_Insert(Convert.ToInt32(ltbPosts.SelectedValue.ToString()),
                ltbEmployee.SelectedValue.ToString());
        }

        private void btUpdateComb_Click(object sender, EventArgs e)
        {
            DataBaseProcedure procedure = new DataBaseProcedure();
            procedure.spCombination_Update(Convert.ToInt32(
                dgvCombination.CurrentRow.Cells[0].Value.ToString()),
                Convert.ToInt32(ltbPosts.SelectedValue.ToString()),
                ltbEmployee.SelectedValue.ToString());
        }

        private void btDeleteComb_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить совместительство: "+dgvCombination.CurrentRow.Cells[3].Value.ToString()+" "+
                dgvCombination.CurrentRow.Cells[4].Value.ToString()+"?","Удаление совместительство",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DataBaseProcedure procedure = new DataBaseProcedure();
                    procedure.spCombination_Delete(Convert.ToInt32(
                        dgvCombination.CurrentRow.Cells[0].Value.ToString()));
                    break;
            }
        }

        private void ChekedChange()
        {
            dataComb.qrCombination = Combinationqr;
            try
            {
                switch (rabEmployee.Checked)
                {
                    case (true):
                        dataComb.qrCombination += " and [Employee_Login] = '" + ltbEmployee.SelectedValue.ToString() + "'";
                        break;
                }
                switch (rabPosts.Checked)
                {
                    case (true):
                        dataComb.qrCombination += " and [dbo].[Combination].[Post_ID] = " + ltbPosts.SelectedValue.ToString();
                        break;
                }
                switch (rabNone.Checked)
                {
                    case (true):
                        dataComb.qrCombination = Combinationqr;
                        break;
                }
                dgvCombinationFill();
            }
            catch
            {

            }
        }

        private void AllChakedChanged(object sender, EventArgs e)
        {
            ChekedChange();
        }

        private void ltbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChekedChange();
        }

        private void ltbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChekedChange();
        }

        private void cbDepartmentFill()
        {
            Action action = () =>
             {
                 DataBaseTables tables = new DataBaseTables();
                 tables.dtDepartmentFill();
                 tables.dependency.OnChange += onchangeDepartment;
                 cbDepartment.DataSource = tables.dtDepartment;
                 cbDepartment.ValueMember = "ID_Department";
                 cbDepartment.DisplayMember = "Departments_List";
             };
            Invoke(action);
        }

        private void onchangeDepartment(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                cbDepartmentFill();
        }

        private void cbGroupFill()
        {
            Action action = () =>
            {
                DataBaseTables tables = new DataBaseTables();
                tables.qrGroup += " and [Department_ID] = " + cbDepartment.SelectedValue.ToString();
                tables.dtGroupFill();
                tables.dependency.OnChange += onchangeGroup;
                cbGroup.DataSource = tables.dtGroup;
                cbGroup.ValueMember = "ID_Group";
                cbGroup.DisplayMember = "Group_name";
            };
            Invoke(action);
        }

        private void onchangeGroup(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                cbGroupFill();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(cbGroupFill);
            thread.Start();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string lstyrltr = year[2].ToString() + year[3].ToString();
            decimal courseEnter = 1;
            string currentGroup = cbGroup.Text[cbGroup.Text.Length - 2].ToString() + cbGroup.Text[cbGroup.Text.Length - 1].ToString();
            try
            {
                courseEnter = Convert.ToDecimal(lstyrltr) - Convert.ToDecimal(currentGroup);
                nudCourse.Value = courseEnter;
            }
            catch
            {
                courseEnter = 1;
            }
        }

        DataBaseTables tablesEmployee = new DataBaseTables();
        DataBaseTables tablesDiscipline = new DataBaseTables();
        DataBaseTables tablesBurden = new DataBaseTables();
        string Burdenqr = "";
        private void btAcept_Click(object sender, EventArgs e)
        {
            switch (btAcept.Text)
            {
                case ("Принять"):
                    tablesEmployee.dtEmployee.Clear();
                    tablesDiscipline.dtDiscipline.Clear();
                    tablesBurden.dtBurden.Clear();
                    btAcept.Text = "Завершить";
                    gbDisciplineEmployee.Visible = true;
                    gbBurden.Visible = true;
                    cbDepartment.Enabled = false;
                    cbGroup.Enabled = false;
                    nudCourse.Enabled = false;
                    cbCourseEdit.Enabled = false;
                    Thread thread_Employe = new Thread(ltbEmployeeBurdenFill);
                    Thread thread_Discipline = new Thread(ltbDisciplineFill);
                    Thread thread_Burden = new Thread(dgvBurdenFill);
                    thread_Employe.Start();
                    thread_Discipline.Start();
                    thread_Burden.Start();
                    break;
                case ("Завершить"):
                    btAcept.Text = "Принять";
                    gbDisciplineEmployee.Visible = false;
                    gbBurden.Visible = false;
                    cbDepartment.Enabled = true;
                    cbGroup.Enabled = true;
                    cbCourseEdit.Enabled = true;
                    cbCourseEdit_CheckedChanged(sender, e);
                    tablesEmployee.dependency.OnChange -= onchangeEmployeeBurden;
                    tablesDiscipline.dependency.OnChange -= onchangeDisciplineBurden;
                    tablesBurden.dependency.OnChange -= onchangeBurden;
                    break;
            }
        }

        private void cbCourseEdit_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbCourseEdit.CheckState)
            {
                case CheckState.Checked:
                    nudCourse.Enabled = true;
                    break;
                case CheckState.Unchecked:
                    nudCourse.Enabled = false;
                    break;
            }
        }

        private void ltbEmployeeBurdenFill()
        {
            Action action = () =>
             {
                 tablesEmployee.dtEmployeeFill();
                 tablesEmployee.dependency.OnChange += onchangeEmployeeBurden;
                 ltbEmployeeBurden.DataSource = tablesEmployee.dtEmployee;
                 ltbEmployeeBurden.ValueMember = "Login_Employee";
                 ltbEmployeeBurden.DisplayMember = "Emploeyee_Info";
             };
            Invoke(action);
        }
        private void onchangeEmployeeBurden(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                ltbEmployeeBurdenFill();
        }

        private void ltbDisciplineFill()
        {
            Action action = () =>
            {
                tablesDiscipline.dtDisciplineFill();
                tablesDiscipline.dependency.OnChange += onchangeDisciplineBurden;
                ltbDiscipline.DataSource = tablesDiscipline.dtDiscipline;
                ltbDiscipline.ValueMember = "ID_Discipline";
                ltbDiscipline.DisplayMember = "Discipline_Info";
            };
            Invoke(action);
        }

        private void onchangeDisciplineBurden(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                ltbDisciplineFill();
        }

        private void dgvBurdenFill()
        {
            Action action = () =>
            {
                tablesBurden.qrBurden = Burdenqr;
                tablesBurden.qrBurden += " and [Group_ID] = " + cbGroup.SelectedValue.ToString();
                tablesBurden.dtBurdenFill();
                tablesBurden.dependency.OnChange += onchangeBurden;
                dgvBurden.DataSource = tablesBurden.dtBurden;
                dgvBurden.Columns[0].Visible = false;
                dgvBurden.Columns[1].Visible = false;
                dgvBurden.Columns[2].Visible = false;
                dgvBurden.Columns[3].Visible = false;
                dgvBurden.Columns[4].HeaderText = "Курс обоучения";
                dgvBurden.Columns[5].Visible = false;
                dgvBurden.Columns[6].HeaderText = "Дисциплина";
                dgvBurden.Columns[7].HeaderText = "Перподаватель";
                dgvBurden.Columns[8].HeaderText = "Учебная группа";
            };
            Invoke(action);
        }

        private void onchangeBurden(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dgvBurdenFill();
        }

        private void btInserBurden_Click(object sender, EventArgs e)
        {
            DataBaseProcedure procedure = new DataBaseProcedure();
            procedure.spBurden_Insert(ltbEmployeeBurden.SelectedValue.ToString(),
                Convert.ToInt32(ltbDiscipline.SelectedValue.ToString()),
                Convert.ToInt32(cbGroup.SelectedValue.ToString()), (int)nudCourse.Value);
        }

        private void btUpdateBurden_Click(object sender, EventArgs e)
        {
            DataBaseProcedure procedure = new DataBaseProcedure();
            procedure.spBurden_Update(Convert.ToInt32(dgvBurden.CurrentRow.Cells[0].Value.ToString()),
                ltbEmployeeBurden.SelectedValue.ToString(),
                Convert.ToInt32(ltbDiscipline.SelectedValue.ToString()),
                Convert.ToInt32(cbGroup.SelectedValue.ToString()), (int)nudCourse.Value);
        }

        private void btDeleteBurden_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить нагрузку: "+dgvBurden.CurrentRow.Cells[7].Value.ToString()+" "
                +dgvBurden.CurrentRow.Cells[8].Value.ToString()+" "
                +dgvBurden.CurrentRow.Cells[6].Value.ToString()+"?","Удаление распределения",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DataBaseProcedure procedure = new DataBaseProcedure();
                    procedure.spBurden_Delete(Convert.ToInt32(
                        dgvBurden.CurrentRow.Cells[0].Value.ToString()));
                    break;
            }
        }
    }
}
