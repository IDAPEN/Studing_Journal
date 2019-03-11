namespace Studing_Journal
{
    partial class DisciplineForm
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
            this.gbDiscipline = new System.Windows.Forms.GroupBox();
            this.ltbDiscipline = new System.Windows.Forms.ListBox();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnCancel.SuspendLayout();
            this.gbDiscipline.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btError);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 370);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(284, 28);
            this.pnCancel.TabIndex = 0;
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
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(209, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 28);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // gbDiscipline
            // 
            this.gbDiscipline.Controls.Add(this.ltbDiscipline);
            this.gbDiscipline.Controls.Add(this.gbManipulation);
            this.gbDiscipline.Controls.Add(this.gbSearch);
            this.gbDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDiscipline.Location = new System.Drawing.Point(0, 0);
            this.gbDiscipline.Name = "gbDiscipline";
            this.gbDiscipline.Size = new System.Drawing.Size(284, 370);
            this.gbDiscipline.TabIndex = 1;
            this.gbDiscipline.TabStop = false;
            this.gbDiscipline.Text = "Список дисциплин";
            // 
            // ltbDiscipline
            // 
            this.ltbDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbDiscipline.FormattingEnabled = true;
            this.ltbDiscipline.Location = new System.Drawing.Point(3, 56);
            this.ltbDiscipline.Name = "ltbDiscipline";
            this.ltbDiscipline.Size = new System.Drawing.Size(278, 155);
            this.ltbDiscipline.TabIndex = 2;
            this.ltbDiscipline.Click += new System.EventHandler(this.ltbDiscipline_Click);
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.btDelete);
            this.gbManipulation.Controls.Add(this.btUpdate);
            this.gbManipulation.Controls.Add(this.btInsert);
            this.gbManipulation.Controls.Add(this.tbName);
            this.gbManipulation.Controls.Add(this.lblName);
            this.gbManipulation.Controls.Add(this.tbPrefix);
            this.gbManipulation.Controls.Add(this.lblPrefix);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(3, 211);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(278, 156);
            this.gbManipulation.TabIndex = 1;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипулирование";
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelete.Location = new System.Drawing.Point(3, 128);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(272, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Удалить дисциплину";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Location = new System.Drawing.Point(3, 105);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(272, 23);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Изменить данные дисциплины";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInsert.Location = new System.Drawing.Point(3, 82);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(272, 23);
            this.btInsert.TabIndex = 4;
            this.btInsert.Text = "Добавить дисциплину";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(272, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Название дисциплины:";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrefix.Location = new System.Drawing.Point(3, 29);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(272, 20);
            this.tbPrefix.TabIndex = 1;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrefix.Location = new System.Drawing.Point(3, 16);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(94, 13);
            this.lblPrefix.TabIndex = 0;
            this.lblPrefix.Text = "Код дисциплины:";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(3, 16);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(278, 40);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск дисциплины";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(3, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(272, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите название или код дисциплины...";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 398);
            this.Controls.Add(this.gbDiscipline);
            this.Controls.Add(this.pnCancel);
            this.Name = "DisciplineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Дисциплины\"";
            this.Load += new System.EventHandler(this.DisciplineForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbDiscipline.ResumeLayout(false);
            this.gbManipulation.ResumeLayout(false);
            this.gbManipulation.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btError;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbDiscipline;
        private System.Windows.Forms.ListBox ltbDiscipline;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}