namespace Studing_Journal
{
    partial class PostForm
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
            this.btError = new System.Windows.Forms.Button();
            this.gbManup = new System.Windows.Forms.GroupBox();
            this.ltbPost = new System.Windows.Forms.ListBox();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.lblPostParent = new System.Windows.Forms.Label();
            this.cbPostParent = new System.Windows.Forms.ComboBox();
            this.lbPostName = new System.Windows.Forms.Label();
            this.tbPostName = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.pnCancel.SuspendLayout();
            this.gbManup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btError);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 328);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(273, 28);
            this.pnCancel.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(198, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 28);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btError
            // 
            this.btError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btError.Location = new System.Drawing.Point(0, 0);
            this.btError.Name = "btError";
            this.btError.Size = new System.Drawing.Size(75, 28);
            this.btError.TabIndex = 1;
            this.btError.Text = "Ошибки";
            this.btError.UseVisualStyleBackColor = true;
            this.btError.Click += new System.EventHandler(this.btError_Click);
            // 
            // gbManup
            // 
            this.gbManup.Controls.Add(this.btDelete);
            this.gbManup.Controls.Add(this.btUpdate);
            this.gbManup.Controls.Add(this.btInsert);
            this.gbManup.Controls.Add(this.tbPostName);
            this.gbManup.Controls.Add(this.lbPostName);
            this.gbManup.Controls.Add(this.cbPostParent);
            this.gbManup.Controls.Add(this.lblPostParent);
            this.gbManup.Controls.Add(this.cbFilter);
            this.gbManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManup.Location = new System.Drawing.Point(0, 158);
            this.gbManup.Name = "gbManup";
            this.gbManup.Size = new System.Drawing.Size(273, 170);
            this.gbManup.TabIndex = 1;
            this.gbManup.TabStop = false;
            this.gbManup.Text = "Манипулирование:";
            // 
            // ltbPost
            // 
            this.ltbPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbPost.FormattingEnabled = true;
            this.ltbPost.Location = new System.Drawing.Point(0, 0);
            this.ltbPost.Name = "ltbPost";
            this.ltbPost.Size = new System.Drawing.Size(273, 158);
            this.ltbPost.TabIndex = 2;
            this.ltbPost.SelectedIndexChanged += new System.EventHandler(this.ltbPost_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFilter.Location = new System.Drawing.Point(3, 16);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(267, 17);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.Text = "Вывод подчинённых должностей";
            this.cbFilter.UseVisualStyleBackColor = true;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.cbFilter_CheckedChanged);
            // 
            // lblPostParent
            // 
            this.lblPostParent.AutoSize = true;
            this.lblPostParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPostParent.Location = new System.Drawing.Point(3, 33);
            this.lblPostParent.Name = "lblPostParent";
            this.lblPostParent.Size = new System.Drawing.Size(141, 13);
            this.lblPostParent.TabIndex = 1;
            this.lblPostParent.Text = "Вышестоящяя должность:";
            // 
            // cbPostParent
            // 
            this.cbPostParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPostParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostParent.FormattingEnabled = true;
            this.cbPostParent.Location = new System.Drawing.Point(3, 46);
            this.cbPostParent.Name = "cbPostParent";
            this.cbPostParent.Size = new System.Drawing.Size(267, 21);
            this.cbPostParent.TabIndex = 2;
            this.cbPostParent.SelectedIndexChanged += new System.EventHandler(this.cbPostParent_SelectedIndexChanged);
            // 
            // lbPostName
            // 
            this.lbPostName.AutoSize = true;
            this.lbPostName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPostName.Location = new System.Drawing.Point(3, 67);
            this.lbPostName.Name = "lbPostName";
            this.lbPostName.Size = new System.Drawing.Size(118, 13);
            this.lbPostName.TabIndex = 3;
            this.lbPostName.Text = "Название должности:";
            // 
            // tbPostName
            // 
            this.tbPostName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPostName.Location = new System.Drawing.Point(3, 80);
            this.tbPostName.Name = "tbPostName";
            this.tbPostName.Size = new System.Drawing.Size(267, 20);
            this.tbPostName.TabIndex = 4;
            // 
            // btInsert
            // 
            this.btInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInsert.Location = new System.Drawing.Point(3, 100);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(267, 23);
            this.btInsert.TabIndex = 5;
            this.btInsert.Text = "Добавить новую должность";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Location = new System.Drawing.Point(3, 123);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(267, 23);
            this.btUpdate.TabIndex = 6;
            this.btUpdate.Text = "Изменить данные";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelete.Location = new System.Drawing.Point(3, 146);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(267, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Удалить должность";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 356);
            this.Controls.Add(this.ltbPost);
            this.Controls.Add(this.gbManup);
            this.Controls.Add(this.pnCancel);
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Должности\"";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbManup.ResumeLayout(false);
            this.gbManup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btError;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbManup;
        private System.Windows.Forms.ListBox ltbPost;
        private System.Windows.Forms.ComboBox cbPostParent;
        private System.Windows.Forms.Label lblPostParent;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbPostName;
        private System.Windows.Forms.Label lbPostName;
    }
}