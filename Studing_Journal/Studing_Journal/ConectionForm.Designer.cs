namespace Studing_Journal
{
    partial class ConectionForm
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
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btConect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.lblServers = new System.Windows.Forms.Label();
            this.cbIPServer = new System.Windows.Forms.ComboBox();
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.statusConect.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusConect
            // 
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 202);
            this.statusConect.Name = "statusConect";
            this.statusConect.Size = new System.Drawing.Size(291, 22);
            this.statusConect.TabIndex = 3;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(12, 17);
            this.tsslStatus.Text = "-";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btConect);
            this.pnControl.Controls.Add(this.btCancel);
            this.pnControl.Controls.Add(this.btCheck);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 170);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(291, 32);
            this.pnControl.TabIndex = 12;
            // 
            // btConect
            // 
            this.btConect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConect.Enabled = false;
            this.btConect.Location = new System.Drawing.Point(75, 0);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(141, 32);
            this.btConect.TabIndex = 13;
            this.btConect.Text = "Подключить";
            this.btConect.UseVisualStyleBackColor = true;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(216, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 32);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCheck
            // 
            this.btCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(0, 0);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 32);
            this.btCheck.TabIndex = 10;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(86, 13);
            this.lblServers.TabIndex = 16;
            this.lblServers.Text = "Адрес сервера:";
            // 
            // cbIPServer
            // 
            this.cbIPServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbIPServer.Enabled = false;
            this.cbIPServer.FormattingEnabled = true;
            this.cbIPServer.Location = new System.Drawing.Point(0, 13);
            this.cbIPServer.Name = "cbIPServer";
            this.cbIPServer.Size = new System.Drawing.Size(291, 21);
            this.cbIPServer.TabIndex = 34;
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInitialCatalog.Enabled = false;
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(0, 147);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(291, 21);
            this.cbInitialCatalog.TabIndex = 42;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataSource.Location = new System.Drawing.Point(0, 134);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(148, 13);
            this.lblDataSource.TabIndex = 41;
            this.lblDataSource.Text = "Список источников данных:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(0, 114);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(291, 20);
            this.tbPassword.TabIndex = 40;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 13);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Пароль пользователя:";
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(0, 81);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '*';
            this.tbUserID.Size = new System.Drawing.Size(291, 20);
            this.tbUserID.TabIndex = 38;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsers.Location = new System.Drawing.Point(0, 68);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(128, 13);
            this.lblUsers.TabIndex = 37;
            this.lblUsers.Text = "Пользователь сервера:";
            // 
            // cbDataSource
            // 
            this.cbDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDataSource.Enabled = false;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(0, 47);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(291, 21);
            this.cbDataSource.TabIndex = 36;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbServer.Location = new System.Drawing.Point(0, 34);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(102, 13);
            this.lbServer.TabIndex = 35;
            this.lbServer.Text = "Название сервера";
            // 
            // ConectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 224);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.cbDataSource);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.cbIPServer);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.statusConect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка подлючения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConectionForm_Load);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusConect;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox cbIPServer;
        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lbServer;
        public System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}