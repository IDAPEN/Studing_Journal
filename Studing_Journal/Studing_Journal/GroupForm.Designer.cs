namespace Studing_Journal
{
    partial class GroupForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.pnGroupSearch = new System.Windows.Forms.Panel();
            this.tbGroupSearch = new System.Windows.Forms.TextBox();
            this.gbManup = new System.Windows.Forms.GroupBox();
            this.btGroupDelete = new System.Windows.Forms.Button();
            this.btGroupUpdate = new System.Windows.Forms.Button();
            this.btGroupInsert = new System.Windows.Forms.Button();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lbGroupName = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lstbGroup = new System.Windows.Forms.ListBox();
            this.btError = new System.Windows.Forms.Button();
            this.pnCancel.SuspendLayout();
            this.pnGroupSearch.SuspendLayout();
            this.gbManup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btError);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 448);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(253, 28);
            this.pnCancel.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(178, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 28);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pnGroupSearch
            // 
            this.pnGroupSearch.Controls.Add(this.tbGroupSearch);
            this.pnGroupSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGroupSearch.Location = new System.Drawing.Point(0, 0);
            this.pnGroupSearch.Name = "pnGroupSearch";
            this.pnGroupSearch.Size = new System.Drawing.Size(253, 22);
            this.pnGroupSearch.TabIndex = 1;
            // 
            // tbGroupSearch
            // 
            this.tbGroupSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGroupSearch.Location = new System.Drawing.Point(0, 0);
            this.tbGroupSearch.Name = "tbGroupSearch";
            this.tbGroupSearch.Size = new System.Drawing.Size(253, 20);
            this.tbGroupSearch.TabIndex = 0;
            this.tbGroupSearch.Text = "Введите название группы...";
            this.tbGroupSearch.TextChanged += new System.EventHandler(this.tbGroupSearch_TextChanged);
            this.tbGroupSearch.Enter += new System.EventHandler(this.tbGroupSearch_Enter);
            this.tbGroupSearch.Leave += new System.EventHandler(this.tbGroupSearch_Leave);
            // 
            // gbManup
            // 
            this.gbManup.Controls.Add(this.btGroupDelete);
            this.gbManup.Controls.Add(this.btGroupUpdate);
            this.gbManup.Controls.Add(this.btGroupInsert);
            this.gbManup.Controls.Add(this.tbGroupName);
            this.gbManup.Controls.Add(this.lbGroupName);
            this.gbManup.Controls.Add(this.cbDepartment);
            this.gbManup.Controls.Add(this.lbDepartment);
            this.gbManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManup.Location = new System.Drawing.Point(0, 294);
            this.gbManup.Name = "gbManup";
            this.gbManup.Size = new System.Drawing.Size(253, 154);
            this.gbManup.TabIndex = 2;
            this.gbManup.TabStop = false;
            this.gbManup.Text = "Манипулирование:";
            // 
            // btGroupDelete
            // 
            this.btGroupDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGroupDelete.Location = new System.Drawing.Point(3, 129);
            this.btGroupDelete.Name = "btGroupDelete";
            this.btGroupDelete.Size = new System.Drawing.Size(247, 23);
            this.btGroupDelete.TabIndex = 6;
            this.btGroupDelete.Text = "Удалить запись";
            this.btGroupDelete.UseVisualStyleBackColor = true;
            this.btGroupDelete.Click += new System.EventHandler(this.btGroupDelete_Click);
            // 
            // btGroupUpdate
            // 
            this.btGroupUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGroupUpdate.Location = new System.Drawing.Point(3, 106);
            this.btGroupUpdate.Name = "btGroupUpdate";
            this.btGroupUpdate.Size = new System.Drawing.Size(247, 23);
            this.btGroupUpdate.TabIndex = 5;
            this.btGroupUpdate.Text = "Изменить запись";
            this.btGroupUpdate.UseVisualStyleBackColor = true;
            this.btGroupUpdate.Click += new System.EventHandler(this.btGroupUpdate_Click);
            // 
            // btGroupInsert
            // 
            this.btGroupInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGroupInsert.Location = new System.Drawing.Point(3, 83);
            this.btGroupInsert.Name = "btGroupInsert";
            this.btGroupInsert.Size = new System.Drawing.Size(247, 23);
            this.btGroupInsert.TabIndex = 4;
            this.btGroupInsert.Text = "Добавить запись";
            this.btGroupInsert.UseVisualStyleBackColor = true;
            this.btGroupInsert.Click += new System.EventHandler(this.btGroupInsert_Click);
            // 
            // tbGroupName
            // 
            this.tbGroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGroupName.Location = new System.Drawing.Point(3, 63);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(247, 20);
            this.tbGroupName.TabIndex = 3;
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGroupName.Location = new System.Drawing.Point(3, 50);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(99, 13);
            this.lbGroupName.TabIndex = 2;
            this.lbGroupName.Text = "Название группы:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(3, 29);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(247, 21);
            this.cbDepartment.TabIndex = 1;
            this.cbDepartment.SelectedValueChanged += new System.EventHandler(this.cbDepartment_SelectedValueChanged);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDepartment.Location = new System.Drawing.Point(3, 16);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(88, 13);
            this.lbDepartment.TabIndex = 0;
            this.lbDepartment.Text = "Специальность:";
            // 
            // lstbGroup
            // 
            this.lstbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbGroup.FormattingEnabled = true;
            this.lstbGroup.Location = new System.Drawing.Point(0, 22);
            this.lstbGroup.Name = "lstbGroup";
            this.lstbGroup.Size = new System.Drawing.Size(253, 272);
            this.lstbGroup.TabIndex = 3;
            this.lstbGroup.Click += new System.EventHandler(this.lstbGroup_Click);
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
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 476);
            this.Controls.Add(this.lstbGroup);
            this.Controls.Add(this.gbManup);
            this.Controls.Add(this.pnGroupSearch);
            this.Controls.Add(this.pnCancel);
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Группы\"";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.pnGroupSearch.ResumeLayout(false);
            this.pnGroupSearch.PerformLayout();
            this.gbManup.ResumeLayout(false);
            this.gbManup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel pnGroupSearch;
        private System.Windows.Forms.TextBox tbGroupSearch;
        private System.Windows.Forms.GroupBox gbManup;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btGroupDelete;
        private System.Windows.Forms.Button btGroupUpdate;
        private System.Windows.Forms.Button btGroupInsert;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.ListBox lstbGroup;
        private System.Windows.Forms.Button btError;
    }
}