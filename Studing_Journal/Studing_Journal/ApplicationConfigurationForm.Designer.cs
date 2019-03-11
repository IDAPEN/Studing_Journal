namespace Studing_Journal
{
    partial class ApplicationConfigurationForm
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
            this.btSave = new System.Windows.Forms.Button();
            this.btApplye = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tcConfig = new System.Windows.Forms.TabControl();
            this.tpMajorConfig = new System.Windows.Forms.TabPage();
            this.rtbOrganizationName = new System.Windows.Forms.RichTextBox();
            this.lbOrgName = new System.Windows.Forms.Label();
            this.tpDocument = new System.Windows.Forms.TabPage();
            this.gbDocumentMerge = new System.Windows.Forms.GroupBox();
            this.pnPage = new System.Windows.Forms.Panel();
            this.pnText = new System.Windows.Forms.Panel();
            this.gbRightMerj = new System.Windows.Forms.GroupBox();
            this.nudRightMerg = new System.Windows.Forms.NumericUpDown();
            this.gbLeftMerg = new System.Windows.Forms.GroupBox();
            this.nudLeftMerg = new System.Windows.Forms.NumericUpDown();
            this.gbBottomMerg = new System.Windows.Forms.GroupBox();
            this.nudBottomMerg = new System.Windows.Forms.NumericUpDown();
            this.gbTopMerg = new System.Windows.Forms.GroupBox();
            this.nudTopMerg = new System.Windows.Forms.NumericUpDown();
            this.lbWarningPath = new System.Windows.Forms.Label();
            this.pnPath = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnCancel.SuspendLayout();
            this.tcConfig.SuspendLayout();
            this.tpMajorConfig.SuspendLayout();
            this.tpDocument.SuspendLayout();
            this.gbDocumentMerge.SuspendLayout();
            this.pnPage.SuspendLayout();
            this.gbRightMerj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMerg)).BeginInit();
            this.gbLeftMerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMerg)).BeginInit();
            this.gbBottomMerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMerg)).BeginInit();
            this.gbTopMerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMerg)).BeginInit();
            this.pnPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btSave);
            this.pnCancel.Controls.Add(this.btApplye);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 344);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(364, 25);
            this.pnCancel.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(139, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 25);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btApplye
            // 
            this.btApplye.Dock = System.Windows.Forms.DockStyle.Right;
            this.btApplye.Location = new System.Drawing.Point(214, 0);
            this.btApplye.Name = "btApplye";
            this.btApplye.Size = new System.Drawing.Size(75, 25);
            this.btApplye.TabIndex = 1;
            this.btApplye.Text = "Применить";
            this.btApplye.UseVisualStyleBackColor = true;
            this.btApplye.Click += new System.EventHandler(this.Button_Change);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(289, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 25);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tcConfig
            // 
            this.tcConfig.Controls.Add(this.tpMajorConfig);
            this.tcConfig.Controls.Add(this.tpDocument);
            this.tcConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConfig.Location = new System.Drawing.Point(0, 0);
            this.tcConfig.Name = "tcConfig";
            this.tcConfig.SelectedIndex = 0;
            this.tcConfig.Size = new System.Drawing.Size(364, 344);
            this.tcConfig.TabIndex = 1;
            // 
            // tpMajorConfig
            // 
            this.tpMajorConfig.Controls.Add(this.rtbOrganizationName);
            this.tpMajorConfig.Controls.Add(this.lbOrgName);
            this.tpMajorConfig.Location = new System.Drawing.Point(4, 22);
            this.tpMajorConfig.Name = "tpMajorConfig";
            this.tpMajorConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpMajorConfig.Size = new System.Drawing.Size(356, 318);
            this.tpMajorConfig.TabIndex = 0;
            this.tpMajorConfig.Text = "Глобальные";
            this.tpMajorConfig.UseVisualStyleBackColor = true;
            // 
            // rtbOrganizationName
            // 
            this.rtbOrganizationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOrganizationName.Location = new System.Drawing.Point(3, 29);
            this.rtbOrganizationName.Name = "rtbOrganizationName";
            this.rtbOrganizationName.Size = new System.Drawing.Size(350, 286);
            this.rtbOrganizationName.TabIndex = 1;
            this.rtbOrganizationName.Text = "";
            // 
            // lbOrgName
            // 
            this.lbOrgName.AutoSize = true;
            this.lbOrgName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbOrgName.Location = new System.Drawing.Point(3, 3);
            this.lbOrgName.Name = "lbOrgName";
            this.lbOrgName.Size = new System.Drawing.Size(485, 26);
            this.lbOrgName.TabIndex = 0;
            this.lbOrgName.Text = "В поле, необходимо указать название учёбного заведения, для дальнейшего использов" +
    "ания \r\nв качестве \"шапок\" для документов.";
            // 
            // tpDocument
            // 
            this.tpDocument.Controls.Add(this.gbDocumentMerge);
            this.tpDocument.Controls.Add(this.lbWarningPath);
            this.tpDocument.Controls.Add(this.pnPath);
            this.tpDocument.Controls.Add(this.lbPath);
            this.tpDocument.Location = new System.Drawing.Point(4, 22);
            this.tpDocument.Name = "tpDocument";
            this.tpDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tpDocument.Size = new System.Drawing.Size(356, 318);
            this.tpDocument.TabIndex = 1;
            this.tpDocument.Text = "Документы";
            this.tpDocument.UseVisualStyleBackColor = true;
            // 
            // gbDocumentMerge
            // 
            this.gbDocumentMerge.Controls.Add(this.pnPage);
            this.gbDocumentMerge.Controls.Add(this.gbRightMerj);
            this.gbDocumentMerge.Controls.Add(this.gbLeftMerg);
            this.gbDocumentMerge.Controls.Add(this.gbBottomMerg);
            this.gbDocumentMerge.Controls.Add(this.gbTopMerg);
            this.gbDocumentMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDocumentMerge.Location = new System.Drawing.Point(3, 53);
            this.gbDocumentMerge.Name = "gbDocumentMerge";
            this.gbDocumentMerge.Size = new System.Drawing.Size(350, 262);
            this.gbDocumentMerge.TabIndex = 3;
            this.gbDocumentMerge.TabStop = false;
            this.gbDocumentMerge.Text = "Отступы в документе";
            // 
            // pnPage
            // 
            this.pnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPage.Controls.Add(this.pnText);
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(103, 51);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(144, 173);
            this.pnPage.TabIndex = 4;
            // 
            // pnText
            // 
            this.pnText.BackColor = System.Drawing.Color.Gray;
            this.pnText.Location = new System.Drawing.Point(-1, -1);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(144, 173);
            this.pnText.TabIndex = 0;
            // 
            // gbRightMerj
            // 
            this.gbRightMerj.Controls.Add(this.nudRightMerg);
            this.gbRightMerj.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbRightMerj.Location = new System.Drawing.Point(247, 51);
            this.gbRightMerj.Name = "gbRightMerj";
            this.gbRightMerj.Size = new System.Drawing.Size(100, 173);
            this.gbRightMerj.TabIndex = 3;
            this.gbRightMerj.TabStop = false;
            this.gbRightMerj.Text = "Правый отступ";
            // 
            // nudRightMerg
            // 
            this.nudRightMerg.DecimalPlaces = 1;
            this.nudRightMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudRightMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRightMerg.Location = new System.Drawing.Point(3, 16);
            this.nudRightMerg.Name = "nudRightMerg";
            this.nudRightMerg.Size = new System.Drawing.Size(94, 20);
            this.nudRightMerg.TabIndex = 0;
            this.nudRightMerg.ValueChanged += new System.EventHandler(this.nudRightMerg_ValueChanged);
            // 
            // gbLeftMerg
            // 
            this.gbLeftMerg.Controls.Add(this.nudLeftMerg);
            this.gbLeftMerg.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLeftMerg.Location = new System.Drawing.Point(3, 51);
            this.gbLeftMerg.Name = "gbLeftMerg";
            this.gbLeftMerg.Size = new System.Drawing.Size(100, 173);
            this.gbLeftMerg.TabIndex = 2;
            this.gbLeftMerg.TabStop = false;
            this.gbLeftMerg.Text = "Левый отступ";
            // 
            // nudLeftMerg
            // 
            this.nudLeftMerg.DecimalPlaces = 1;
            this.nudLeftMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudLeftMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLeftMerg.Location = new System.Drawing.Point(3, 16);
            this.nudLeftMerg.Name = "nudLeftMerg";
            this.nudLeftMerg.Size = new System.Drawing.Size(94, 20);
            this.nudLeftMerg.TabIndex = 0;
            this.nudLeftMerg.ValueChanged += new System.EventHandler(this.nudLeftMerg_ValueChanged);
            // 
            // gbBottomMerg
            // 
            this.gbBottomMerg.Controls.Add(this.nudBottomMerg);
            this.gbBottomMerg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbBottomMerg.Location = new System.Drawing.Point(3, 224);
            this.gbBottomMerg.Name = "gbBottomMerg";
            this.gbBottomMerg.Size = new System.Drawing.Size(344, 35);
            this.gbBottomMerg.TabIndex = 1;
            this.gbBottomMerg.TabStop = false;
            this.gbBottomMerg.Text = "Нижний отступ";
            // 
            // nudBottomMerg
            // 
            this.nudBottomMerg.DecimalPlaces = 1;
            this.nudBottomMerg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudBottomMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBottomMerg.Location = new System.Drawing.Point(3, 12);
            this.nudBottomMerg.Name = "nudBottomMerg";
            this.nudBottomMerg.Size = new System.Drawing.Size(338, 20);
            this.nudBottomMerg.TabIndex = 0;
            this.nudBottomMerg.ValueChanged += new System.EventHandler(this.nudBottomMerg_ValueChanged);
            // 
            // gbTopMerg
            // 
            this.gbTopMerg.Controls.Add(this.nudTopMerg);
            this.gbTopMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTopMerg.Location = new System.Drawing.Point(3, 16);
            this.gbTopMerg.Name = "gbTopMerg";
            this.gbTopMerg.Size = new System.Drawing.Size(344, 35);
            this.gbTopMerg.TabIndex = 0;
            this.gbTopMerg.TabStop = false;
            this.gbTopMerg.Text = "Верхний отступ";
            // 
            // nudTopMerg
            // 
            this.nudTopMerg.DecimalPlaces = 1;
            this.nudTopMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTopMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTopMerg.Location = new System.Drawing.Point(3, 16);
            this.nudTopMerg.Name = "nudTopMerg";
            this.nudTopMerg.Size = new System.Drawing.Size(338, 20);
            this.nudTopMerg.TabIndex = 0;
            this.nudTopMerg.ValueChanged += new System.EventHandler(this.nudTopMerg_ValueChanged);
            // 
            // lbWarningPath
            // 
            this.lbWarningPath.AutoSize = true;
            this.lbWarningPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWarningPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWarningPath.Location = new System.Drawing.Point(3, 40);
            this.lbWarningPath.Name = "lbWarningPath";
            this.lbWarningPath.Size = new System.Drawing.Size(350, 13);
            this.lbWarningPath.TabIndex = 2;
            this.lbWarningPath.Text = "По умолчанию файлы будут импортироваться в папку с приложением";
            // 
            // pnPath
            // 
            this.pnPath.Controls.Add(this.tbPath);
            this.pnPath.Controls.Add(this.btBrowse);
            this.pnPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPath.Location = new System.Drawing.Point(3, 16);
            this.pnPath.Name = "pnPath";
            this.pnPath.Size = new System.Drawing.Size(350, 24);
            this.pnPath.TabIndex = 1;
            // 
            // tbPath
            // 
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPath.Location = new System.Drawing.Point(0, 0);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(326, 20);
            this.tbPath.TabIndex = 1;
            // 
            // btBrowse
            // 
            this.btBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btBrowse.Location = new System.Drawing.Point(326, 0);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(24, 24);
            this.btBrowse.TabIndex = 0;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPath.Location = new System.Drawing.Point(3, 3);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(323, 13);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "Выберите папку для сохраненияэкспортируемых документов:";
            // 
            // ApplicationConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 369);
            this.Controls.Add(this.tcConfig);
            this.Controls.Add(this.pnCancel);
            this.Name = "ApplicationConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка приложения";
            this.Load += new System.EventHandler(this.ApplicationConfigurationForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.tcConfig.ResumeLayout(false);
            this.tpMajorConfig.ResumeLayout(false);
            this.tpMajorConfig.PerformLayout();
            this.tpDocument.ResumeLayout(false);
            this.tpDocument.PerformLayout();
            this.gbDocumentMerge.ResumeLayout(false);
            this.pnPage.ResumeLayout(false);
            this.gbRightMerj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMerg)).EndInit();
            this.gbLeftMerg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMerg)).EndInit();
            this.gbBottomMerg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMerg)).EndInit();
            this.gbTopMerg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMerg)).EndInit();
            this.pnPath.ResumeLayout(false);
            this.pnPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btApplye;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TabControl tcConfig;
        private System.Windows.Forms.TabPage tpMajorConfig;
        private System.Windows.Forms.RichTextBox rtbOrganizationName;
        private System.Windows.Forms.Label lbOrgName;
        private System.Windows.Forms.TabPage tpDocument;
        private System.Windows.Forms.GroupBox gbDocumentMerge;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.Panel pnText;
        private System.Windows.Forms.GroupBox gbRightMerj;
        private System.Windows.Forms.NumericUpDown nudRightMerg;
        private System.Windows.Forms.GroupBox gbLeftMerg;
        private System.Windows.Forms.NumericUpDown nudLeftMerg;
        private System.Windows.Forms.GroupBox gbBottomMerg;
        private System.Windows.Forms.NumericUpDown nudBottomMerg;
        private System.Windows.Forms.GroupBox gbTopMerg;
        private System.Windows.Forms.NumericUpDown nudTopMerg;
        private System.Windows.Forms.Label lbWarningPath;
        private System.Windows.Forms.Panel pnPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}