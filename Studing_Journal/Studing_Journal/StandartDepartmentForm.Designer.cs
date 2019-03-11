namespace Studing_Journal
{
    partial class StandartDepartmentForm
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
            this.pnManup = new System.Windows.Forms.Panel();
            this.btError = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.gbStandart = new System.Windows.Forms.GroupBox();
            this.lstbStandart = new System.Windows.Forms.ListBox();
            this.gbStandartManup = new System.Windows.Forms.GroupBox();
            this.tbStandartName = new System.Windows.Forms.TextBox();
            this.lblStandartName = new System.Windows.Forms.Label();
            this.btStandartInsert = new System.Windows.Forms.Button();
            this.btStandartUpdate = new System.Windows.Forms.Button();
            this.btStandartDelete = new System.Windows.Forms.Button();
            this.pnStandartSearch = new System.Windows.Forms.Panel();
            this.tbStandartSearch = new System.Windows.Forms.TextBox();
            this.gbDepartment = new System.Windows.Forms.GroupBox();
            this.pndgv = new System.Windows.Forms.Panel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.gbDepartmentManup = new System.Windows.Forms.GroupBox();
            this.pnDepartmentManup2 = new System.Windows.Forms.Panel();
            this.btDepartmentDelete = new System.Windows.Forms.Button();
            this.btDepartmentUpdate = new System.Windows.Forms.Button();
            this.btDepartmentInsert = new System.Windows.Forms.Button();
            this.pnDepartmentManup1 = new System.Windows.Forms.Panel();
            this.cbstandartDepartment = new System.Windows.Forms.ComboBox();
            this.lblStandartDepartment = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.mtbDepartmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblDepartmentNumber = new System.Windows.Forms.Label();
            this.gbDepartmentSearchFilter = new System.Windows.Forms.GroupBox();
            this.cbFilterStandart = new System.Windows.Forms.CheckBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbDepartmentSearch = new System.Windows.Forms.TextBox();
            this.pnManup.SuspendLayout();
            this.gbStandart.SuspendLayout();
            this.gbStandartManup.SuspendLayout();
            this.pnStandartSearch.SuspendLayout();
            this.gbDepartment.SuspendLayout();
            this.pndgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.gbDepartmentManup.SuspendLayout();
            this.pnDepartmentManup2.SuspendLayout();
            this.pnDepartmentManup1.SuspendLayout();
            this.gbDepartmentSearchFilter.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnManup
            // 
            this.pnManup.Controls.Add(this.btError);
            this.pnManup.Controls.Add(this.btClose);
            this.pnManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManup.Location = new System.Drawing.Point(0, 447);
            this.pnManup.Name = "pnManup";
            this.pnManup.Size = new System.Drawing.Size(799, 34);
            this.pnManup.TabIndex = 0;
            // 
            // btError
            // 
            this.btError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btError.Location = new System.Drawing.Point(0, 0);
            this.btError.Name = "btError";
            this.btError.Size = new System.Drawing.Size(75, 34);
            this.btError.TabIndex = 1;
            this.btError.Text = "Ошибки";
            this.btError.UseVisualStyleBackColor = true;
            this.btError.Click += new System.EventHandler(this.btError_Click);
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(724, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 34);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gbStandart
            // 
            this.gbStandart.Controls.Add(this.lstbStandart);
            this.gbStandart.Controls.Add(this.gbStandartManup);
            this.gbStandart.Controls.Add(this.pnStandartSearch);
            this.gbStandart.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbStandart.Location = new System.Drawing.Point(0, 0);
            this.gbStandart.Name = "gbStandart";
            this.gbStandart.Size = new System.Drawing.Size(252, 447);
            this.gbStandart.TabIndex = 1;
            this.gbStandart.TabStop = false;
            this.gbStandart.Text = "Справочник \"Стандарты\"";
            // 
            // lstbStandart
            // 
            this.lstbStandart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbStandart.FormattingEnabled = true;
            this.lstbStandart.Location = new System.Drawing.Point(3, 40);
            this.lstbStandart.Name = "lstbStandart";
            this.lstbStandart.Size = new System.Drawing.Size(246, 281);
            this.lstbStandart.TabIndex = 2;
            this.lstbStandart.SelectedValueChanged += new System.EventHandler(this.lstbStandart_SelectedValueChanged);
            // 
            // gbStandartManup
            // 
            this.gbStandartManup.Controls.Add(this.tbStandartName);
            this.gbStandartManup.Controls.Add(this.lblStandartName);
            this.gbStandartManup.Controls.Add(this.btStandartInsert);
            this.gbStandartManup.Controls.Add(this.btStandartUpdate);
            this.gbStandartManup.Controls.Add(this.btStandartDelete);
            this.gbStandartManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbStandartManup.Location = new System.Drawing.Point(3, 321);
            this.gbStandartManup.Name = "gbStandartManup";
            this.gbStandartManup.Size = new System.Drawing.Size(246, 123);
            this.gbStandartManup.TabIndex = 1;
            this.gbStandartManup.TabStop = false;
            this.gbStandartManup.Text = "Манипулирование:";
            // 
            // tbStandartName
            // 
            this.tbStandartName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStandartName.Location = new System.Drawing.Point(3, 29);
            this.tbStandartName.Name = "tbStandartName";
            this.tbStandartName.Size = new System.Drawing.Size(240, 20);
            this.tbStandartName.TabIndex = 4;
            // 
            // lblStandartName
            // 
            this.lblStandartName.AutoSize = true;
            this.lblStandartName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStandartName.Location = new System.Drawing.Point(3, 16);
            this.lblStandartName.Name = "lblStandartName";
            this.lblStandartName.Size = new System.Drawing.Size(115, 13);
            this.lblStandartName.TabIndex = 3;
            this.lblStandartName.Text = "Название стандарта:";
            // 
            // btStandartInsert
            // 
            this.btStandartInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStandartInsert.Location = new System.Drawing.Point(3, 51);
            this.btStandartInsert.Name = "btStandartInsert";
            this.btStandartInsert.Size = new System.Drawing.Size(240, 23);
            this.btStandartInsert.TabIndex = 2;
            this.btStandartInsert.Text = "Добавить запись";
            this.btStandartInsert.UseVisualStyleBackColor = true;
            this.btStandartInsert.Click += new System.EventHandler(this.btStandartInsert_Click);
            // 
            // btStandartUpdate
            // 
            this.btStandartUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStandartUpdate.Location = new System.Drawing.Point(3, 74);
            this.btStandartUpdate.Name = "btStandartUpdate";
            this.btStandartUpdate.Size = new System.Drawing.Size(240, 23);
            this.btStandartUpdate.TabIndex = 1;
            this.btStandartUpdate.Text = "Изменить запись";
            this.btStandartUpdate.UseVisualStyleBackColor = true;
            this.btStandartUpdate.Click += new System.EventHandler(this.btStandartUpdate_Click);
            // 
            // btStandartDelete
            // 
            this.btStandartDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStandartDelete.Location = new System.Drawing.Point(3, 97);
            this.btStandartDelete.Name = "btStandartDelete";
            this.btStandartDelete.Size = new System.Drawing.Size(240, 23);
            this.btStandartDelete.TabIndex = 0;
            this.btStandartDelete.Text = "Удалить запись";
            this.btStandartDelete.UseVisualStyleBackColor = true;
            this.btStandartDelete.Click += new System.EventHandler(this.btStandartDelete_Click);
            // 
            // pnStandartSearch
            // 
            this.pnStandartSearch.Controls.Add(this.tbStandartSearch);
            this.pnStandartSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStandartSearch.Location = new System.Drawing.Point(3, 16);
            this.pnStandartSearch.Name = "pnStandartSearch";
            this.pnStandartSearch.Size = new System.Drawing.Size(246, 24);
            this.pnStandartSearch.TabIndex = 0;
            // 
            // tbStandartSearch
            // 
            this.tbStandartSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStandartSearch.Location = new System.Drawing.Point(0, 0);
            this.tbStandartSearch.Name = "tbStandartSearch";
            this.tbStandartSearch.Size = new System.Drawing.Size(246, 20);
            this.tbStandartSearch.TabIndex = 0;
            this.tbStandartSearch.Text = "Введите название...";
            this.tbStandartSearch.TextChanged += new System.EventHandler(this.tbStandartSearch_TextChanged);
            this.tbStandartSearch.Enter += new System.EventHandler(this.tbStandartSearch_Enter);
            this.tbStandartSearch.Leave += new System.EventHandler(this.tbStandartSearch_Leave);
            // 
            // gbDepartment
            // 
            this.gbDepartment.Controls.Add(this.pndgv);
            this.gbDepartment.Controls.Add(this.gbDepartmentManup);
            this.gbDepartment.Controls.Add(this.gbDepartmentSearchFilter);
            this.gbDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDepartment.Location = new System.Drawing.Point(252, 0);
            this.gbDepartment.Name = "gbDepartment";
            this.gbDepartment.Size = new System.Drawing.Size(547, 447);
            this.gbDepartment.TabIndex = 2;
            this.gbDepartment.TabStop = false;
            this.gbDepartment.Text = "Справочник \"Специальности\"";
            // 
            // pndgv
            // 
            this.pndgv.Controls.Add(this.dgvDepartment);
            this.pndgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndgv.Location = new System.Drawing.Point(3, 56);
            this.pndgv.Name = "pndgv";
            this.pndgv.Size = new System.Drawing.Size(541, 265);
            this.pndgv.TabIndex = 3;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(541, 265);
            this.dgvDepartment.TabIndex = 1;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            // 
            // gbDepartmentManup
            // 
            this.gbDepartmentManup.Controls.Add(this.pnDepartmentManup2);
            this.gbDepartmentManup.Controls.Add(this.pnDepartmentManup1);
            this.gbDepartmentManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDepartmentManup.Location = new System.Drawing.Point(3, 321);
            this.gbDepartmentManup.Name = "gbDepartmentManup";
            this.gbDepartmentManup.Size = new System.Drawing.Size(541, 123);
            this.gbDepartmentManup.TabIndex = 2;
            this.gbDepartmentManup.TabStop = false;
            this.gbDepartmentManup.Text = "Манипулирование:";
            // 
            // pnDepartmentManup2
            // 
            this.pnDepartmentManup2.Controls.Add(this.btDepartmentDelete);
            this.pnDepartmentManup2.Controls.Add(this.btDepartmentUpdate);
            this.pnDepartmentManup2.Controls.Add(this.btDepartmentInsert);
            this.pnDepartmentManup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDepartmentManup2.Location = new System.Drawing.Point(354, 16);
            this.pnDepartmentManup2.Name = "pnDepartmentManup2";
            this.pnDepartmentManup2.Size = new System.Drawing.Size(184, 104);
            this.pnDepartmentManup2.TabIndex = 1;
            // 
            // btDepartmentDelete
            // 
            this.btDepartmentDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDepartmentDelete.Location = new System.Drawing.Point(0, 46);
            this.btDepartmentDelete.Name = "btDepartmentDelete";
            this.btDepartmentDelete.Size = new System.Drawing.Size(184, 23);
            this.btDepartmentDelete.TabIndex = 2;
            this.btDepartmentDelete.Text = "Удалить запись";
            this.btDepartmentDelete.UseVisualStyleBackColor = true;
            this.btDepartmentDelete.Click += new System.EventHandler(this.btDepartmentDelete_Click);
            // 
            // btDepartmentUpdate
            // 
            this.btDepartmentUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDepartmentUpdate.Location = new System.Drawing.Point(0, 23);
            this.btDepartmentUpdate.Name = "btDepartmentUpdate";
            this.btDepartmentUpdate.Size = new System.Drawing.Size(184, 23);
            this.btDepartmentUpdate.TabIndex = 1;
            this.btDepartmentUpdate.Text = "Изменить запись";
            this.btDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btDepartmentUpdate.Click += new System.EventHandler(this.btDepartmentUpdate_Click);
            // 
            // btDepartmentInsert
            // 
            this.btDepartmentInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDepartmentInsert.Location = new System.Drawing.Point(0, 0);
            this.btDepartmentInsert.Name = "btDepartmentInsert";
            this.btDepartmentInsert.Size = new System.Drawing.Size(184, 23);
            this.btDepartmentInsert.TabIndex = 0;
            this.btDepartmentInsert.Text = "Добавить запись";
            this.btDepartmentInsert.UseVisualStyleBackColor = true;
            this.btDepartmentInsert.Click += new System.EventHandler(this.btDepartmentInsert_Click);
            // 
            // pnDepartmentManup1
            // 
            this.pnDepartmentManup1.Controls.Add(this.cbstandartDepartment);
            this.pnDepartmentManup1.Controls.Add(this.lblStandartDepartment);
            this.pnDepartmentManup1.Controls.Add(this.tbDepartmentName);
            this.pnDepartmentManup1.Controls.Add(this.lblDepartmentName);
            this.pnDepartmentManup1.Controls.Add(this.mtbDepartmentNumber);
            this.pnDepartmentManup1.Controls.Add(this.lblDepartmentNumber);
            this.pnDepartmentManup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDepartmentManup1.Location = new System.Drawing.Point(3, 16);
            this.pnDepartmentManup1.Name = "pnDepartmentManup1";
            this.pnDepartmentManup1.Size = new System.Drawing.Size(351, 104);
            this.pnDepartmentManup1.TabIndex = 0;
            // 
            // cbstandartDepartment
            // 
            this.cbstandartDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbstandartDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstandartDepartment.FormattingEnabled = true;
            this.cbstandartDepartment.Location = new System.Drawing.Point(0, 79);
            this.cbstandartDepartment.Name = "cbstandartDepartment";
            this.cbstandartDepartment.Size = new System.Drawing.Size(351, 21);
            this.cbstandartDepartment.TabIndex = 5;
            // 
            // lblStandartDepartment
            // 
            this.lblStandartDepartment.AutoSize = true;
            this.lblStandartDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStandartDepartment.Location = new System.Drawing.Point(0, 66);
            this.lblStandartDepartment.Name = "lblStandartDepartment";
            this.lblStandartDepartment.Size = new System.Drawing.Size(106, 13);
            this.lblStandartDepartment.TabIndex = 4;
            this.lblStandartDepartment.Text = "Группа стандартов:";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDepartmentName.Location = new System.Drawing.Point(0, 46);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(351, 20);
            this.tbDepartmentName.TabIndex = 3;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartmentName.Location = new System.Drawing.Point(0, 33);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(140, 13);
            this.lblDepartmentName.TabIndex = 2;
            this.lblDepartmentName.Text = "Название специальности:";
            // 
            // mtbDepartmentNumber
            // 
            this.mtbDepartmentNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbDepartmentNumber.Location = new System.Drawing.Point(0, 13);
            this.mtbDepartmentNumber.Mask = "00/00/00";
            this.mtbDepartmentNumber.Name = "mtbDepartmentNumber";
            this.mtbDepartmentNumber.Size = new System.Drawing.Size(351, 20);
            this.mtbDepartmentNumber.TabIndex = 1;
            // 
            // lblDepartmentNumber
            // 
            this.lblDepartmentNumber.AutoSize = true;
            this.lblDepartmentNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartmentNumber.Location = new System.Drawing.Point(0, 0);
            this.lblDepartmentNumber.Name = "lblDepartmentNumber";
            this.lblDepartmentNumber.Size = new System.Drawing.Size(124, 13);
            this.lblDepartmentNumber.TabIndex = 0;
            this.lblDepartmentNumber.Text = "Номер специальности:";
            // 
            // gbDepartmentSearchFilter
            // 
            this.gbDepartmentSearchFilter.Controls.Add(this.cbFilterStandart);
            this.gbDepartmentSearchFilter.Controls.Add(this.pnSearch);
            this.gbDepartmentSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDepartmentSearchFilter.Location = new System.Drawing.Point(3, 16);
            this.gbDepartmentSearchFilter.Name = "gbDepartmentSearchFilter";
            this.gbDepartmentSearchFilter.Size = new System.Drawing.Size(541, 40);
            this.gbDepartmentSearchFilter.TabIndex = 1;
            this.gbDepartmentSearchFilter.TabStop = false;
            this.gbDepartmentSearchFilter.Text = "Поиск и фильтрация:";
            // 
            // cbFilterStandart
            // 
            this.cbFilterStandart.AutoSize = true;
            this.cbFilterStandart.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbFilterStandart.Location = new System.Drawing.Point(419, 16);
            this.cbFilterStandart.Name = "cbFilterStandart";
            this.cbFilterStandart.Size = new System.Drawing.Size(119, 21);
            this.cbFilterStandart.TabIndex = 1;
            this.cbFilterStandart.Text = "Отфильтровывать";
            this.cbFilterStandart.UseVisualStyleBackColor = true;
            this.cbFilterStandart.CheckedChanged += new System.EventHandler(this.cbFilterStandart_CheckedChanged);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbDepartmentSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSearch.Location = new System.Drawing.Point(3, 16);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(411, 21);
            this.pnSearch.TabIndex = 0;
            // 
            // tbDepartmentSearch
            // 
            this.tbDepartmentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDepartmentSearch.Location = new System.Drawing.Point(0, 0);
            this.tbDepartmentSearch.Name = "tbDepartmentSearch";
            this.tbDepartmentSearch.Size = new System.Drawing.Size(411, 20);
            this.tbDepartmentSearch.TabIndex = 0;
            this.tbDepartmentSearch.Text = "Введите название специальности...";
            this.tbDepartmentSearch.TextChanged += new System.EventHandler(this.tbDepartmentSearch_TextChanged);
            this.tbDepartmentSearch.Enter += new System.EventHandler(this.tbDepartmentSearch_Enter);
            this.tbDepartmentSearch.Leave += new System.EventHandler(this.tbDepartmentSearch_Leave);
            // 
            // StandartDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.gbDepartment);
            this.Controls.Add(this.gbStandart);
            this.Controls.Add(this.pnManup);
            this.Name = "StandartDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Стандарты\" и \"Специальности\"";
            this.Load += new System.EventHandler(this.StandartDepartmentForm_Load);
            this.pnManup.ResumeLayout(false);
            this.gbStandart.ResumeLayout(false);
            this.gbStandartManup.ResumeLayout(false);
            this.gbStandartManup.PerformLayout();
            this.pnStandartSearch.ResumeLayout(false);
            this.pnStandartSearch.PerformLayout();
            this.gbDepartment.ResumeLayout(false);
            this.pndgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.gbDepartmentManup.ResumeLayout(false);
            this.pnDepartmentManup2.ResumeLayout(false);
            this.pnDepartmentManup1.ResumeLayout(false);
            this.pnDepartmentManup1.PerformLayout();
            this.gbDepartmentSearchFilter.ResumeLayout(false);
            this.gbDepartmentSearchFilter.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnManup;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox gbStandart;
        private System.Windows.Forms.ListBox lstbStandart;
        private System.Windows.Forms.GroupBox gbStandartManup;
        private System.Windows.Forms.TextBox tbStandartName;
        private System.Windows.Forms.Label lblStandartName;
        private System.Windows.Forms.Button btStandartInsert;
        private System.Windows.Forms.Button btStandartUpdate;
        private System.Windows.Forms.Button btStandartDelete;
        private System.Windows.Forms.Panel pnStandartSearch;
        private System.Windows.Forms.TextBox tbStandartSearch;
        private System.Windows.Forms.GroupBox gbDepartment;
        private System.Windows.Forms.GroupBox gbDepartmentSearchFilter;
        private System.Windows.Forms.GroupBox gbDepartmentManup;
        private System.Windows.Forms.Panel pnDepartmentManup2;
        private System.Windows.Forms.Panel pnDepartmentManup1;
        private System.Windows.Forms.Button btDepartmentDelete;
        private System.Windows.Forms.Button btDepartmentUpdate;
        private System.Windows.Forms.Button btDepartmentInsert;
        private System.Windows.Forms.CheckBox cbFilterStandart;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbDepartmentSearch;
        private System.Windows.Forms.ComboBox cbstandartDepartment;
        private System.Windows.Forms.Label lblStandartDepartment;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.MaskedTextBox mtbDepartmentNumber;
        private System.Windows.Forms.Label lblDepartmentNumber;
        private System.Windows.Forms.Panel pndgv;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Button btError;
    }
}