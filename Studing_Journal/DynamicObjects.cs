using System;
using System.Windows.Forms;

namespace Studing_Journal
{
    class DynamicObjects
    {
        ComboBox comboBoxDepartment = new ComboBox();
        ComboBox comboBoxGroup = new ComboBox();
        Form formRedaction = new Form();
        Label labelStudentInfo = new Label();
        Button buttonCommnit = new Button();
        Button buttonCancel = new Button();
        public string student;
        public Form parent;

        private void DepartmentFill()
        {
            DataBaseTables dataDepartment = new DataBaseTables();
            dataDepartment.dtDepartmentFill();
            comboBoxDepartment.DataSource = dataDepartment.dtDepartment;
            comboBoxDepartment.ValueMember = "ID_Department";
            comboBoxDepartment.DisplayMember = "Departments_List";
        }

        private void GroupFill()
        {
            try
            {
                DataBaseTables dataGroup = new DataBaseTables();
                dataGroup.qrGroup += " and [Department_ID] = " 
                    + comboBoxDepartment.SelectedValue.ToString();
                dataGroup.dtGroupFill();
                comboBoxGroup.DataSource = dataGroup.dtGroup;
                comboBoxGroup.ValueMember = "ID_Group";
                comboBoxGroup.DisplayMember = "Group_name";
            }
            catch
            {

            }
        }
        
        public void ChangeFormCreate()
        {
            Action action = () =>
             {
                 formRedaction.FormBorderStyle = FormBorderStyle.None;
                 formRedaction.StartPosition = FormStartPosition.CenterScreen;
                 formRedaction.Text = "Изменение группы и специальности";

                 labelStudentInfo.Text = "Укажите специальность и группу, " +
                 "в которую необходимо определить студента " + student;
                 labelStudentInfo.TextAlign =
                 System.Drawing.ContentAlignment.MiddleCenter;
                 labelStudentInfo.Dock = DockStyle.Top;

                 comboBoxDepartment.Dock = DockStyle.Top;
                 comboBoxDepartment.SelectedValueChanged 
                 += ComboBoxDepartment_SelectedValueChanged;
                 comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
                 DepartmentFill();

                 comboBoxGroup.Dock = DockStyle.Top;
                 comboBoxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
                 GroupFill();

                 buttonCommnit.Text = "Изменить";
                 buttonCommnit.Dock = DockStyle.Top;
                 buttonCommnit.Click += ButtonCommnit_Click;


                 buttonCancel.Text = "Отмена";
                 buttonCancel.Dock = DockStyle.Top;
                 buttonCancel.Click += ButtonCancel_Click;

                 formRedaction.Size = new System.Drawing.Size(500, 
                     comboBoxDepartment.Height + comboBoxGroup.Height +
                     buttonCancel.Height + buttonCommnit.Height 
                     + labelStudentInfo.Height);
                 formRedaction.Controls.Add(buttonCancel);
                 formRedaction.Controls.Add(buttonCommnit);
                 formRedaction.Controls.Add(comboBoxGroup);
                 formRedaction.Controls.Add(comboBoxDepartment);
                 formRedaction.Controls.Add(labelStudentInfo);
                 formRedaction.Show(parent);
             };
            parent.Invoke(action);
        }

        private void ButtonCommnit_Click(object sender, EventArgs e)
        {
            switch (comboBoxGroup.Text == ((StudentsForm)parent).cbGroup.Text)
            {
                case (true):
                    MessageBox.Show("Невозможно изменить группу " + 
                        ((StudentsForm)parent).cbGroup.Text + " на " 
                        + comboBoxGroup.Text+". \n Выберите другую группу!");
                    break;
                case (false):
                    DataBaseProcedure procedure = new DataBaseProcedure();
                    procedure.spStudent_Update(student,
                        ((StudentsForm)parent).tbStudentSurname.Text,
                        ((StudentsForm)parent).tbStudentName.Text, 
                        ((StudentsForm)parent).tbStudentMiddleName.Text,
                        ((StudentsForm)parent).mtbTicketNumber.Text, 
                        Convert.ToInt32(comboBoxGroup.SelectedValue.ToString()));
                    break;
            }
        }

        private void ComboBoxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            GroupFill();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            formRedaction.Controls.Remove(buttonCancel);
            formRedaction.Controls.Remove(buttonCommnit);
            formRedaction.Controls.Remove(comboBoxGroup);
            formRedaction.Controls.Remove(comboBoxDepartment);
            formRedaction.Controls.Remove(labelStudentInfo);
            buttonCancel.Click -= ButtonCancel_Click;
            comboBoxDepartment.SelectedValueChanged 
                -= ComboBoxDepartment_SelectedValueChanged;
            buttonCommnit.Click -= ButtonCommnit_Click;
            formRedaction.Close();
        }

        public Form fmNewUser = new Form();
        Label lblNewLogin = new Label();
        Label lblNewPass = new Label();
        Label lblConfPass = new Label();
        TextBox tbNewLogin = new TextBox();
        TextBox tbNewPassword = new TextBox();
        TextBox tbConfPass = new TextBox();
        TextBox tbImagePath = new TextBox();
        PictureBox pbStudent = new PictureBox();
        Button btCommint = new Button();
        Button btCancel = new Button();
        Button btBrowse = new Button();
        Panel pnBrowse = new Panel();
        Panel pnPicture = new Panel();
        Panel pnSelect = new Panel();
        OpenFileDialog fileDialog = new OpenFileDialog();
        public Form parentCreate = new Form();

        public void NewStudentAccountCreate()
        {
            Action action = () =>
            {
                fmNewUser.Text = "Создание новой учётной записи студента";
                fmNewUser.StartPosition = FormStartPosition.CenterScreen;
                fmNewUser.FormBorderStyle = FormBorderStyle.FixedDialog;
                fmNewUser.Size = new System.Drawing.Size(300, 415);

                lblNewLogin.Text = "Новый логин студена";
                lblNewLogin.Dock = DockStyle.Top;

                tbNewLogin.MaxLength = 16;
                tbNewLogin.Dock = DockStyle.Top;
                tbNewLogin.Text = ((StudentsForm)parentCreate)
                .cbStudentLogin.Text;

                lblNewPass.Text = "Новый пароль студента";
                lblNewPass.Dock = DockStyle.Top;

                tbNewPassword.MaxLength = 16;
                tbNewPassword.PasswordChar = '*';
                tbNewPassword.Dock = DockStyle.Top;

                lblConfPass.Text = "Повтрение пароля";
                lblConfPass.Dock = DockStyle.Top;

                tbConfPass.MaxLength = 16;
                tbConfPass.PasswordChar = '*';
                tbConfPass.Dock = DockStyle.Top;

                pnSelect.BorderStyle = BorderStyle.FixedSingle;
                pnSelect.Dock = DockStyle.Top;
                pnSelect.Height = 25;

                pnPicture.BorderStyle = BorderStyle.FixedSingle;
                pnPicture.Width = 200;
                pnPicture.Dock = DockStyle.Fill;

                pbStudent.Dock = DockStyle.Fill;
                pbStudent.SizeMode = PictureBoxSizeMode.Zoom;

                pnBrowse.BorderStyle = BorderStyle.FixedSingle;
                pnBrowse.Height = 200;
                pnBrowse.Dock = DockStyle.Top;

                btBrowse.Size = new System.Drawing.Size(25, 25);
                btBrowse.Text = "...";
                btBrowse.Dock = DockStyle.Right;
                btBrowse.Click += BtBrowse_Click;

                tbImagePath.Enabled = false;
                tbImagePath.Dock = DockStyle.Fill;

                btCommint.Text = "Создать учётную запись";
                btCommint.Dock = DockStyle.Top;
                btCommint.Click += BtCommint_Click;

                btCancel.Text = "Отмена";
                btCancel.Dock = DockStyle.Top;
                btCancel.Click += BtCancel_Click;

                fileDialog.Filter = "Изображение JPG|*.JPG|" +
                "Изображение JPEG|*.JPEG";
                fileDialog.FileOk += FileDialog_FileOk;

                fmNewUser.Controls.Add(btCancel);
                fmNewUser.Controls.Add(btCommint);
                pnPicture.Controls.Add(pbStudent);
                pnSelect.Controls.Add(tbImagePath);
                pnSelect.Controls.Add(btBrowse);
                pnBrowse.Controls.Add(pnPicture);
                pnBrowse.Controls.Add(pnSelect);
                fmNewUser.Controls.Add(pnBrowse);
                fmNewUser.Controls.Add(tbConfPass);
                fmNewUser.Controls.Add(lblConfPass);
                fmNewUser.Controls.Add(tbNewPassword);
                fmNewUser.Controls.Add(lblNewPass);
                fmNewUser.Controls.Add(tbNewLogin);
                fmNewUser.Controls.Add(lblNewLogin);
                fmNewUser.Show(parentCreate);
            };
            parentCreate.Invoke(action);
        }

        private void BtCommint_Click(object sender, EventArgs e)
        {
            switch (tbNewPassword.Text != tbConfPass.Text)
            {
                case (true):
                    tbConfPass.Clear();
                    tbNewPassword.Clear();
                    break;
                case (false):
                    DataBaseProcedure procedure = new DataBaseProcedure();
                    DataBaseTables tables = new DataBaseTables();
                    tables.qrAccess_rights += " and [Access_rights_name] = " +
                        "'Студент'";
                    tables.dtAccess_rightsFill();
                    Int32 Access_Rights_id = 
                        Convert.ToInt32(tables.dtAccess_rights.
                        Rows[0][0].ToString());
                    procedure.spProfile_New_User(tbNewLogin.Text, 
                        tbConfPass.Text, Access_Rights_id, 1, 
                        tbImagePath.Text);
                    procedure.spStudent_Insert(tbNewLogin.Text, 
                        ((StudentsForm)parentCreate).tbStudentSurname.Text, 
                        ((StudentsForm)parentCreate).tbStudentName.Text, 
                        ((StudentsForm)parentCreate).tbStudentMiddleName.Text, 
                        ((StudentsForm)parentCreate).mtbTicketNumber.Text, 
                        Convert.ToInt32(((StudentsForm)parentCreate).
                        cbGroup.SelectedValue.ToString()));
                    BtCancel_Click(sender, e);
                    break;
            }

        }

        private void FileDialog_FileOk(object sender, 
            System.ComponentModel.CancelEventArgs e)
        {
            if (fileDialog.FileName != "")
            {
                pbStudent.Load(fileDialog.FileName);
            }
            
        }

        private void BtBrowse_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            fileDialog.FileOk -= FileDialog_FileOk;
            btCancel.Click -= BtCancel_Click;
            btCommint.Click -= BtCommint_Click;
            btBrowse.Click -= BtBrowse_Click;
            fmNewUser.Close();
        }

        Form CheckPassword = new Form();
        Label lbMessage = new Label();
        TextBox tbOldPassword = new TextBox();
        Button btEnter = new Button();
        Button btCancelCoferm = new Button();
        public Form parentCheck = new Form();
        
        public void createCheckPass()
        {
            CheckPassword.Text = "Подтверждение пароля";
            CheckPassword.Width = 300;
            CheckPassword.Height = 120;
            CheckPassword.FormBorderStyle = FormBorderStyle.FixedDialog;
            CheckPassword.StartPosition = FormStartPosition.CenterScreen;

            lbMessage.Text = "Введите старый пароль, для смены на новый пароль.";
            lbMessage.Dock = DockStyle.Top;
            lbMessage.AutoSize = false;
            lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            tbOldPassword.PasswordChar = '*';
            tbOldPassword.TextAlign = HorizontalAlignment.Center;
            tbOldPassword.Dock = DockStyle.Top;

            btEnter.Text = "Подтвердить";
            btEnter.Dock = DockStyle.Left;
            btEnter.Click += BtEnter_Click;
            btEnter.Width = 100;

            btCancelCoferm.Text = "Отмена";
            btCancelCoferm.Dock = DockStyle.Right;
            btCancelCoferm.Click += BtCancelCoferm_Click;

            CheckPassword.Controls.Add(btCancelCoferm);
            CheckPassword.Controls.Add(btEnter);
            CheckPassword.Controls.Add(tbOldPassword);
            CheckPassword.Controls.Add(lbMessage);

            CheckPassword.Show(parentCheck);
        }

        private void BtCancelCoferm_Click(object sender, EventArgs e)
        {
            btEnter.Click -= BtEnter_Click;
            btCancelCoferm.Click -= BtCancelCoferm_Click;
            CheckPassword.Controls.Remove(btCancel);
            CheckPassword.Controls.Remove(btEnter);
            CheckPassword.Controls.Remove(tbOldPassword);
            CheckPassword.Controls.Remove(lbMessage);
            CheckPassword.Close();
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            int acces = 0;
            switch (((BurdenCombinationEmployeeForm)parentCheck).OldRole 
                == Convert.ToInt32(((BurdenCombinationEmployeeForm)parentCheck).
                cbAccessRights.SelectedValue.ToString()))
            {
                case (true):
                    acces = 1;
                    break;
                case (false):
                    acces = 0;
                    break;
            }
            switch (((BurdenCombinationEmployeeForm)parentCheck).OldPassword 
                == tbOldPassword.Text)
            {
                case (true):
                    DataBaseProcedure procedure = new DataBaseProcedure();
                    procedure.spProfile_Update_User(
                        ((BurdenCombinationEmployeeForm)parentCheck).cbLogin.Text,
                        tbOldPassword.Text,
                        Convert.ToInt32(((BurdenCombinationEmployeeForm)parentCheck).
                        cbAccessRights.SelectedValue.ToString()),
                        acces, ((BurdenCombinationEmployeeForm)parentCheck).
                        tbImagePath.Text);
                    procedure.spEmployee_Update(((BurdenCombinationEmployeeForm)parentCheck)
                        .cbLogin.Text,
                        ((BurdenCombinationEmployeeForm)parentCheck).tbSurName.Text,
                        ((BurdenCombinationEmployeeForm)parentCheck).tbName.Text,
                        ((BurdenCombinationEmployeeForm)parentCheck).tbMiddleName.Text);
                    BtCancelCoferm_Click(sender, e);
                    break;
                case (false):
                    tbConfPass.Clear();
                    break;
            }
        }
    }
}
