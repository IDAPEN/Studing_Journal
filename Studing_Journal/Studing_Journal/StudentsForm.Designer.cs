namespace Studing_Journal
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btError = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbDepartmentGroup = new System.Windows.Forms.GroupBox();
            this.pnLabelStatisticGroup = new System.Windows.Forms.Panel();
            this.lbAvarageValue = new System.Windows.Forms.Label();
            this.lbQualityValue = new System.Windows.Forms.Label();
            this.lblPerfomanceValue = new System.Windows.Forms.Label();
            this.lbStudentValue = new System.Windows.Forms.Label();
            this.lbGroupValue = new System.Windows.Forms.Label();
            this.pnLablesInfoGroup = new System.Windows.Forms.Panel();
            this.lbAvarage = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.lblPerfomance = new System.Windows.Forms.Label();
            this.lbCountStudent = new System.Windows.Forms.Label();
            this.lbCounGroup = new System.Windows.Forms.Label();
            this.pnSpectator2 = new System.Windows.Forms.Panel();
            this.btManupgroup = new System.Windows.Forms.Button();
            this.btManupDepStnd = new System.Windows.Forms.Button();
            this.btStartEnd = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.gbStudentInform = new System.Windows.Forms.GroupBox();
            this.btWordGroupQuality = new System.Windows.Forms.Button();
            this.btExcelGroupList = new System.Windows.Forms.Button();
            this.btWordStudentList = new System.Windows.Forms.Button();
            this.pnSpectator1 = new System.Windows.Forms.Panel();
            this.btStudentDelete = new System.Windows.Forms.Button();
            this.btStudentUpdate = new System.Windows.Forms.Button();
            this.btStudentInsert = new System.Windows.Forms.Button();
            this.mtbTicketNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbTicketNumber = new System.Windows.Forms.Label();
            this.tbStudentMiddleName = new System.Windows.Forms.TextBox();
            this.lbStudentMiddleName = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.tbStudentSurname = new System.Windows.Forms.TextBox();
            this.lbStudentSurname = new System.Windows.Forms.Label();
            this.cbStudentLogin = new System.Windows.Forms.ComboBox();
            this.lbStudentLogin = new System.Windows.Forms.Label();
            this.pnCancel.SuspendLayout();
            this.gbDepartmentGroup.SuspendLayout();
            this.pnLabelStatisticGroup.SuspendLayout();
            this.pnLablesInfoGroup.SuspendLayout();
            this.gbStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.gbStudentInform.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btError);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 365);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(800, 28);
            this.pnCancel.TabIndex = 0;
            // 
            // btError
            // 
            this.btError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btError.Location = new System.Drawing.Point(0, 0);
            this.btError.Name = "btError";
            this.btError.Size = new System.Drawing.Size(75, 28);
            this.btError.TabIndex = 2;
            this.btError.Text = "Ошибки";
            this.btError.UseVisualStyleBackColor = true;
            this.btError.Click += new System.EventHandler(this.btError_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(725, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 28);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // gbDepartmentGroup
            // 
            this.gbDepartmentGroup.Controls.Add(this.pnLabelStatisticGroup);
            this.gbDepartmentGroup.Controls.Add(this.pnLablesInfoGroup);
            this.gbDepartmentGroup.Controls.Add(this.pnSpectator2);
            this.gbDepartmentGroup.Controls.Add(this.btManupgroup);
            this.gbDepartmentGroup.Controls.Add(this.btManupDepStnd);
            this.gbDepartmentGroup.Controls.Add(this.btStartEnd);
            this.gbDepartmentGroup.Controls.Add(this.cbGroup);
            this.gbDepartmentGroup.Controls.Add(this.lblGroup);
            this.gbDepartmentGroup.Controls.Add(this.cbDepartment);
            this.gbDepartmentGroup.Controls.Add(this.lblDepartment);
            this.gbDepartmentGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDepartmentGroup.Location = new System.Drawing.Point(0, 0);
            this.gbDepartmentGroup.Name = "gbDepartmentGroup";
            this.gbDepartmentGroup.Size = new System.Drawing.Size(205, 365);
            this.gbDepartmentGroup.TabIndex = 1;
            this.gbDepartmentGroup.TabStop = false;
            this.gbDepartmentGroup.Text = "Выбор группы ит специальности";
            // 
            // pnLabelStatisticGroup
            // 
            this.pnLabelStatisticGroup.Controls.Add(this.lbAvarageValue);
            this.pnLabelStatisticGroup.Controls.Add(this.lbQualityValue);
            this.pnLabelStatisticGroup.Controls.Add(this.lblPerfomanceValue);
            this.pnLabelStatisticGroup.Controls.Add(this.lbStudentValue);
            this.pnLabelStatisticGroup.Controls.Add(this.lbGroupValue);
            this.pnLabelStatisticGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLabelStatisticGroup.Location = new System.Drawing.Point(130, 220);
            this.pnLabelStatisticGroup.Name = "pnLabelStatisticGroup";
            this.pnLabelStatisticGroup.Size = new System.Drawing.Size(72, 119);
            this.pnLabelStatisticGroup.TabIndex = 9;
            // 
            // lbAvarageValue
            // 
            this.lbAvarageValue.AutoSize = true;
            this.lbAvarageValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbAvarageValue.Location = new System.Drawing.Point(0, 80);
            this.lbAvarageValue.Name = "lbAvarageValue";
            this.lbAvarageValue.Size = new System.Drawing.Size(28, 13);
            this.lbAvarageValue.TabIndex = 4;
            this.lbAvarageValue.Text = "0,00";
            // 
            // lbQualityValue
            // 
            this.lbQualityValue.AutoSize = true;
            this.lbQualityValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbQualityValue.Location = new System.Drawing.Point(0, 93);
            this.lbQualityValue.Name = "lbQualityValue";
            this.lbQualityValue.Size = new System.Drawing.Size(28, 13);
            this.lbQualityValue.TabIndex = 3;
            this.lbQualityValue.Text = "0,00";
            // 
            // lblPerfomanceValue
            // 
            this.lblPerfomanceValue.AutoSize = true;
            this.lblPerfomanceValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPerfomanceValue.Location = new System.Drawing.Point(0, 106);
            this.lblPerfomanceValue.Name = "lblPerfomanceValue";
            this.lblPerfomanceValue.Size = new System.Drawing.Size(28, 13);
            this.lblPerfomanceValue.TabIndex = 2;
            this.lblPerfomanceValue.Text = "0,00";
            // 
            // lbStudentValue
            // 
            this.lbStudentValue.AutoSize = true;
            this.lbStudentValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStudentValue.Location = new System.Drawing.Point(0, 13);
            this.lbStudentValue.Name = "lbStudentValue";
            this.lbStudentValue.Size = new System.Drawing.Size(13, 13);
            this.lbStudentValue.TabIndex = 1;
            this.lbStudentValue.Text = "0";
            // 
            // lbGroupValue
            // 
            this.lbGroupValue.AutoSize = true;
            this.lbGroupValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGroupValue.Location = new System.Drawing.Point(0, 0);
            this.lbGroupValue.Name = "lbGroupValue";
            this.lbGroupValue.Size = new System.Drawing.Size(13, 13);
            this.lbGroupValue.TabIndex = 0;
            this.lbGroupValue.Text = "0";
            // 
            // pnLablesInfoGroup
            // 
            this.pnLablesInfoGroup.Controls.Add(this.lbAvarage);
            this.pnLablesInfoGroup.Controls.Add(this.lbQuality);
            this.pnLablesInfoGroup.Controls.Add(this.lblPerfomance);
            this.pnLablesInfoGroup.Controls.Add(this.lbCountStudent);
            this.pnLablesInfoGroup.Controls.Add(this.lbCounGroup);
            this.pnLablesInfoGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLablesInfoGroup.Location = new System.Drawing.Point(3, 220);
            this.pnLablesInfoGroup.Name = "pnLablesInfoGroup";
            this.pnLablesInfoGroup.Size = new System.Drawing.Size(127, 119);
            this.pnLablesInfoGroup.TabIndex = 8;
            // 
            // lbAvarage
            // 
            this.lbAvarage.AutoSize = true;
            this.lbAvarage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbAvarage.Location = new System.Drawing.Point(0, 80);
            this.lbAvarage.Name = "lbAvarage";
            this.lbAvarage.Size = new System.Drawing.Size(74, 13);
            this.lbAvarage.TabIndex = 4;
            this.lbAvarage.Text = "Средний бал:";
            // 
            // lbQuality
            // 
            this.lbQuality.AutoSize = true;
            this.lbQuality.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbQuality.Location = new System.Drawing.Point(0, 93);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(67, 13);
            this.lbQuality.TabIndex = 3;
            this.lbQuality.Text = "% качества:";
            // 
            // lblPerfomance
            // 
            this.lblPerfomance.AutoSize = true;
            this.lblPerfomance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPerfomance.Location = new System.Drawing.Point(0, 106);
            this.lblPerfomance.Name = "lblPerfomance";
            this.lblPerfomance.Size = new System.Drawing.Size(93, 13);
            this.lblPerfomance.TabIndex = 2;
            this.lblPerfomance.Text = "% успеваемости:";
            // 
            // lbCountStudent
            // 
            this.lbCountStudent.AutoSize = true;
            this.lbCountStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCountStudent.Location = new System.Drawing.Point(0, 13);
            this.lbCountStudent.Name = "lbCountStudent";
            this.lbCountStudent.Size = new System.Drawing.Size(123, 13);
            this.lbCountStudent.TabIndex = 1;
            this.lbCountStudent.Text = "Количество студентов:";
            // 
            // lbCounGroup
            // 
            this.lbCounGroup.AutoSize = true;
            this.lbCounGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCounGroup.Location = new System.Drawing.Point(0, 0);
            this.lbCounGroup.Name = "lbCounGroup";
            this.lbCounGroup.Size = new System.Drawing.Size(100, 13);
            this.lbCounGroup.TabIndex = 0;
            this.lbCounGroup.Text = "Количество групп:";
            // 
            // pnSpectator2
            // 
            this.pnSpectator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpectator2.Location = new System.Drawing.Point(3, 177);
            this.pnSpectator2.Name = "pnSpectator2";
            this.pnSpectator2.Size = new System.Drawing.Size(199, 43);
            this.pnSpectator2.TabIndex = 7;
            // 
            // btManupgroup
            // 
            this.btManupgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btManupgroup.Location = new System.Drawing.Point(3, 130);
            this.btManupgroup.Name = "btManupgroup";
            this.btManupgroup.Size = new System.Drawing.Size(199, 47);
            this.btManupgroup.TabIndex = 6;
            this.btManupgroup.Text = "Редактировать группы";
            this.btManupgroup.UseVisualStyleBackColor = true;
            this.btManupgroup.Click += new System.EventHandler(this.dtManupgroup_Click);
            // 
            // btManupDepStnd
            // 
            this.btManupDepStnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btManupDepStnd.Location = new System.Drawing.Point(3, 84);
            this.btManupDepStnd.Name = "btManupDepStnd";
            this.btManupDepStnd.Size = new System.Drawing.Size(199, 46);
            this.btManupDepStnd.TabIndex = 5;
            this.btManupDepStnd.Text = "Редактировать стандарты, специальности";
            this.btManupDepStnd.UseVisualStyleBackColor = true;
            this.btManupDepStnd.Click += new System.EventHandler(this.btManupDepStnd_Click);
            // 
            // btStartEnd
            // 
            this.btStartEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStartEnd.Enabled = false;
            this.btStartEnd.Location = new System.Drawing.Point(3, 339);
            this.btStartEnd.Name = "btStartEnd";
            this.btStartEnd.Size = new System.Drawing.Size(199, 23);
            this.btStartEnd.TabIndex = 4;
            this.btStartEnd.Text = "Актуализация списка";
            this.btStartEnd.UseVisualStyleBackColor = true;
            this.btStartEnd.Click += new System.EventHandler(this.btStartEnd_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.Enabled = false;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(3, 63);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(199, 21);
            this.cbGroup.TabIndex = 3;
            this.cbGroup.SelectedValueChanged += new System.EventHandler(this.cbGroup_SelectedValueChanged);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGroup.Location = new System.Drawing.Point(3, 50);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(42, 13);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Группа";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(3, 29);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(199, 21);
            this.cbDepartment.TabIndex = 1;
            this.cbDepartment.SelectedValueChanged += new System.EventHandler(this.cbDepartment_SelectedValueChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartment.Location = new System.Drawing.Point(3, 16);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(88, 13);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Специальность:";
            // 
            // gbStudents
            // 
            this.gbStudents.Controls.Add(this.dgvStudents);
            this.gbStudents.Controls.Add(this.gbStudentInform);
            this.gbStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStudents.Location = new System.Drawing.Point(205, 0);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.Size = new System.Drawing.Size(595, 365);
            this.gbStudents.TabIndex = 2;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Списки студентов";
            this.gbStudents.Visible = false;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Enabled = false;
            this.dgvStudents.Location = new System.Drawing.Point(232, 16);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(360, 346);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.Visible = false;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // gbStudentInform
            // 
            this.gbStudentInform.Controls.Add(this.btWordGroupQuality);
            this.gbStudentInform.Controls.Add(this.btExcelGroupList);
            this.gbStudentInform.Controls.Add(this.btWordStudentList);
            this.gbStudentInform.Controls.Add(this.pnSpectator1);
            this.gbStudentInform.Controls.Add(this.btStudentDelete);
            this.gbStudentInform.Controls.Add(this.btStudentUpdate);
            this.gbStudentInform.Controls.Add(this.btStudentInsert);
            this.gbStudentInform.Controls.Add(this.mtbTicketNumber);
            this.gbStudentInform.Controls.Add(this.lbTicketNumber);
            this.gbStudentInform.Controls.Add(this.tbStudentMiddleName);
            this.gbStudentInform.Controls.Add(this.lbStudentMiddleName);
            this.gbStudentInform.Controls.Add(this.tbStudentName);
            this.gbStudentInform.Controls.Add(this.lbStudentName);
            this.gbStudentInform.Controls.Add(this.tbStudentSurname);
            this.gbStudentInform.Controls.Add(this.lbStudentSurname);
            this.gbStudentInform.Controls.Add(this.cbStudentLogin);
            this.gbStudentInform.Controls.Add(this.lbStudentLogin);
            this.gbStudentInform.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbStudentInform.Enabled = false;
            this.gbStudentInform.Location = new System.Drawing.Point(3, 16);
            this.gbStudentInform.Name = "gbStudentInform";
            this.gbStudentInform.Size = new System.Drawing.Size(229, 346);
            this.gbStudentInform.TabIndex = 0;
            this.gbStudentInform.TabStop = false;
            this.gbStudentInform.Text = "Информация о студенте";
            // 
            // btWordGroupQuality
            // 
            this.btWordGroupQuality.Dock = System.Windows.Forms.DockStyle.Top;
            this.btWordGroupQuality.Location = new System.Drawing.Point(3, 324);
            this.btWordGroupQuality.Name = "btWordGroupQuality";
            this.btWordGroupQuality.Size = new System.Drawing.Size(223, 23);
            this.btWordGroupQuality.TabIndex = 31;
            this.btWordGroupQuality.Text = "Успеваемость";
            this.btWordGroupQuality.UseVisualStyleBackColor = true;
            this.btWordGroupQuality.Click += new System.EventHandler(this.btWordGroupQuality_Click);
            // 
            // btExcelGroupList
            // 
            this.btExcelGroupList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExcelGroupList.Location = new System.Drawing.Point(3, 301);
            this.btExcelGroupList.Name = "btExcelGroupList";
            this.btExcelGroupList.Size = new System.Drawing.Size(223, 23);
            this.btExcelGroupList.TabIndex = 30;
            this.btExcelGroupList.Text = "Сводная ведомость";
            this.btExcelGroupList.UseVisualStyleBackColor = true;
            this.btExcelGroupList.Click += new System.EventHandler(this.btExcelGroupList_Click);
            // 
            // btWordStudentList
            // 
            this.btWordStudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btWordStudentList.Location = new System.Drawing.Point(3, 278);
            this.btWordStudentList.Name = "btWordStudentList";
            this.btWordStudentList.Size = new System.Drawing.Size(223, 23);
            this.btWordStudentList.TabIndex = 29;
            this.btWordStudentList.Text = "Список группы";
            this.btWordStudentList.UseVisualStyleBackColor = true;
            this.btWordStudentList.Click += new System.EventHandler(this.btWordStudentList_Click);
            // 
            // pnSpectator1
            // 
            this.pnSpectator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpectator1.Location = new System.Drawing.Point(3, 251);
            this.pnSpectator1.Name = "pnSpectator1";
            this.pnSpectator1.Size = new System.Drawing.Size(223, 27);
            this.pnSpectator1.TabIndex = 28;
            // 
            // btStudentDelete
            // 
            this.btStudentDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStudentDelete.Location = new System.Drawing.Point(3, 228);
            this.btStudentDelete.Name = "btStudentDelete";
            this.btStudentDelete.Size = new System.Drawing.Size(223, 23);
            this.btStudentDelete.TabIndex = 27;
            this.btStudentDelete.Text = "Удалить данные студента";
            this.btStudentDelete.UseVisualStyleBackColor = true;
            this.btStudentDelete.Click += new System.EventHandler(this.btStudentDelete_Click);
            // 
            // btStudentUpdate
            // 
            this.btStudentUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStudentUpdate.Location = new System.Drawing.Point(3, 205);
            this.btStudentUpdate.Name = "btStudentUpdate";
            this.btStudentUpdate.Size = new System.Drawing.Size(223, 23);
            this.btStudentUpdate.TabIndex = 26;
            this.btStudentUpdate.Text = "Изменить данные студента";
            this.btStudentUpdate.UseVisualStyleBackColor = true;
            this.btStudentUpdate.Click += new System.EventHandler(this.btStudentUpdate_Click);
            // 
            // btStudentInsert
            // 
            this.btStudentInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStudentInsert.Location = new System.Drawing.Point(3, 182);
            this.btStudentInsert.Name = "btStudentInsert";
            this.btStudentInsert.Size = new System.Drawing.Size(223, 23);
            this.btStudentInsert.TabIndex = 25;
            this.btStudentInsert.Text = "Добавить студента";
            this.btStudentInsert.UseVisualStyleBackColor = true;
            this.btStudentInsert.Click += new System.EventHandler(this.btStudentInsert_Click);
            // 
            // mtbTicketNumber
            // 
            this.mtbTicketNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbTicketNumber.Location = new System.Drawing.Point(3, 162);
            this.mtbTicketNumber.Mask = "00-00-00\\/00";
            this.mtbTicketNumber.Name = "mtbTicketNumber";
            this.mtbTicketNumber.Size = new System.Drawing.Size(223, 20);
            this.mtbTicketNumber.TabIndex = 24;
            this.mtbTicketNumber.ValidatingType = typeof(System.DateTime);
            // 
            // lbTicketNumber
            // 
            this.lbTicketNumber.AutoSize = true;
            this.lbTicketNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTicketNumber.Location = new System.Drawing.Point(3, 149);
            this.lbTicketNumber.Name = "lbTicketNumber";
            this.lbTicketNumber.Size = new System.Drawing.Size(131, 13);
            this.lbTicketNumber.TabIndex = 23;
            this.lbTicketNumber.Text = "Номер зачётной книжки";
            // 
            // tbStudentMiddleName
            // 
            this.tbStudentMiddleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStudentMiddleName.Location = new System.Drawing.Point(3, 129);
            this.tbStudentMiddleName.Name = "tbStudentMiddleName";
            this.tbStudentMiddleName.Size = new System.Drawing.Size(223, 20);
            this.tbStudentMiddleName.TabIndex = 22;
            // 
            // lbStudentMiddleName
            // 
            this.lbStudentMiddleName.AutoSize = true;
            this.lbStudentMiddleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStudentMiddleName.Location = new System.Drawing.Point(3, 116);
            this.lbStudentMiddleName.Name = "lbStudentMiddleName";
            this.lbStudentMiddleName.Size = new System.Drawing.Size(102, 13);
            this.lbStudentMiddleName.TabIndex = 21;
            this.lbStudentMiddleName.Text = "Отчество студента";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStudentName.Location = new System.Drawing.Point(3, 96);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(223, 20);
            this.tbStudentName.TabIndex = 20;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStudentName.Location = new System.Drawing.Point(3, 83);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(77, 13);
            this.lbStudentName.TabIndex = 19;
            this.lbStudentName.Text = "Имя студента";
            // 
            // tbStudentSurname
            // 
            this.tbStudentSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStudentSurname.Location = new System.Drawing.Point(3, 63);
            this.tbStudentSurname.Name = "tbStudentSurname";
            this.tbStudentSurname.Size = new System.Drawing.Size(223, 20);
            this.tbStudentSurname.TabIndex = 18;
            // 
            // lbStudentSurname
            // 
            this.lbStudentSurname.AutoSize = true;
            this.lbStudentSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStudentSurname.Location = new System.Drawing.Point(3, 50);
            this.lbStudentSurname.Name = "lbStudentSurname";
            this.lbStudentSurname.Size = new System.Drawing.Size(104, 13);
            this.lbStudentSurname.TabIndex = 17;
            this.lbStudentSurname.Text = "Фамилия студента";
            // 
            // cbStudentLogin
            // 
            this.cbStudentLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbStudentLogin.FormattingEnabled = true;
            this.cbStudentLogin.Location = new System.Drawing.Point(3, 29);
            this.cbStudentLogin.Name = "cbStudentLogin";
            this.cbStudentLogin.Size = new System.Drawing.Size(223, 21);
            this.cbStudentLogin.TabIndex = 1;
            this.cbStudentLogin.TextUpdate += new System.EventHandler(this.cbStudentLogin_TextUpdate);
            this.cbStudentLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStudentLogin_KeyPress);
            this.cbStudentLogin.Leave += new System.EventHandler(this.cbStudentLogin_Leave);
            // 
            // lbStudentLogin
            // 
            this.lbStudentLogin.AutoSize = true;
            this.lbStudentLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStudentLogin.Location = new System.Drawing.Point(3, 16);
            this.lbStudentLogin.Name = "lbStudentLogin";
            this.lbStudentLogin.Size = new System.Drawing.Size(86, 13);
            this.lbStudentLogin.TabIndex = 0;
            this.lbStudentLogin.Text = "Логин студента";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.gbStudents);
            this.Controls.Add(this.gbDepartmentGroup);
            this.Controls.Add(this.pnCancel);
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Студентов\"";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbDepartmentGroup.ResumeLayout(false);
            this.gbDepartmentGroup.PerformLayout();
            this.pnLabelStatisticGroup.ResumeLayout(false);
            this.pnLabelStatisticGroup.PerformLayout();
            this.pnLablesInfoGroup.ResumeLayout(false);
            this.pnLablesInfoGroup.PerformLayout();
            this.gbStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.gbStudentInform.ResumeLayout(false);
            this.gbStudentInform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbDepartmentGroup;
        private System.Windows.Forms.Button btStartEnd;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.GroupBox gbStudents;
        private System.Windows.Forms.GroupBox gbStudentInform;
        private System.Windows.Forms.Label lbStudentLogin;
        private System.Windows.Forms.Button btManupgroup;
        private System.Windows.Forms.Button btManupDepStnd;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Panel pnLabelStatisticGroup;
        private System.Windows.Forms.Label lbAvarageValue;
        private System.Windows.Forms.Label lbQualityValue;
        private System.Windows.Forms.Label lblPerfomanceValue;
        private System.Windows.Forms.Label lbStudentValue;
        private System.Windows.Forms.Label lbGroupValue;
        private System.Windows.Forms.Panel pnLablesInfoGroup;
        private System.Windows.Forms.Label lbAvarage;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.Label lblPerfomance;
        private System.Windows.Forms.Label lbCountStudent;
        private System.Windows.Forms.Label lbCounGroup;
        private System.Windows.Forms.Panel pnSpectator2;
        private System.Windows.Forms.Button btError;
        private System.Windows.Forms.Button btWordGroupQuality;
        private System.Windows.Forms.Button btExcelGroupList;
        private System.Windows.Forms.Button btWordStudentList;
        private System.Windows.Forms.Panel pnSpectator1;
        private System.Windows.Forms.Button btStudentDelete;
        private System.Windows.Forms.Button btStudentUpdate;
        private System.Windows.Forms.Button btStudentInsert;
        private System.Windows.Forms.Label lbTicketNumber;
        private System.Windows.Forms.Label lbStudentMiddleName;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbStudentSurname;
        public System.Windows.Forms.MaskedTextBox mtbTicketNumber;
        public System.Windows.Forms.TextBox tbStudentMiddleName;
        public System.Windows.Forms.TextBox tbStudentName;
        public System.Windows.Forms.TextBox tbStudentSurname;
        public System.Windows.Forms.ComboBox cbStudentLogin;
        public System.Windows.Forms.ComboBox cbGroup;
    }
}