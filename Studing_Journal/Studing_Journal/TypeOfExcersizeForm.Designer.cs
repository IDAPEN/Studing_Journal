namespace Studing_Journal
{
    partial class TypeOfExcersizeForm
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
            this.lblTypeName = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.ltbTypeOfExcersize = new System.Windows.Forms.ListBox();
            this.pnCancel.SuspendLayout();
            this.gbManup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btError);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 272);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(328, 28);
            this.pnCancel.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(253, 0);
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
            this.gbManup.Controls.Add(this.tbTypeName);
            this.gbManup.Controls.Add(this.lblTypeName);
            this.gbManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManup.Location = new System.Drawing.Point(0, 152);
            this.gbManup.Name = "gbManup";
            this.gbManup.Size = new System.Drawing.Size(328, 120);
            this.gbManup.TabIndex = 1;
            this.gbManup.TabStop = false;
            this.gbManup.Text = "Манипулирование:";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTypeName.Location = new System.Drawing.Point(3, 16);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(151, 13);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Название типа дисциплины:";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTypeName.Location = new System.Drawing.Point(3, 29);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(322, 20);
            this.tbTypeName.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInsert.Location = new System.Drawing.Point(3, 49);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(322, 23);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Добавить новый тип";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Location = new System.Drawing.Point(3, 72);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(322, 23);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Изменить данные";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelete.Location = new System.Drawing.Point(3, 95);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(322, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Удалить тип учебного занятия";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ltbTypeOfExcersize
            // 
            this.ltbTypeOfExcersize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbTypeOfExcersize.FormattingEnabled = true;
            this.ltbTypeOfExcersize.Location = new System.Drawing.Point(0, 0);
            this.ltbTypeOfExcersize.Name = "ltbTypeOfExcersize";
            this.ltbTypeOfExcersize.Size = new System.Drawing.Size(328, 152);
            this.ltbTypeOfExcersize.TabIndex = 2;
            this.ltbTypeOfExcersize.SelectedIndexChanged += new System.EventHandler(this.ltbTypeOfExcersize_SelectedIndexChanged);
            // 
            // TypeOfExcersizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 300);
            this.Controls.Add(this.ltbTypeOfExcersize);
            this.Controls.Add(this.gbManup);
            this.Controls.Add(this.pnCancel);
            this.Name = "TypeOfExcersizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Тип учебного занятия\"";
            this.Load += new System.EventHandler(this.TypeOfExcersizeForm_Load);
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
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.ListBox ltbTypeOfExcersize;
    }
}