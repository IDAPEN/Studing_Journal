namespace Studing_Journal
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.strpInfo = new System.Windows.Forms.StatusStrip();
            this.tssldateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрофиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.настрокаПрофиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конфигурацияПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конфигурацияПодключенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.системаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.завершитьРаботуИнформационнойСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартыСпециальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебныеГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типУчебныхЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кадровоеОбеспечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распределениеНагрузокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.совместительствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strpInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strpInfo
            // 
            this.strpInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssldateTime,
            this.tsslCon});
            this.strpInfo.Location = new System.Drawing.Point(0, 392);
            this.strpInfo.Name = "strpInfo";
            this.strpInfo.Size = new System.Drawing.Size(688, 22);
            this.strpInfo.TabIndex = 0;
            this.strpInfo.Text = "statusStrip1";
            // 
            // tssldateTime
            // 
            this.tssldateTime.Name = "tssldateTime";
            this.tssldateTime.Size = new System.Drawing.Size(108, 17);
            this.tssldateTime.Text = "00:00:00/00.00.0000";
            // 
            // tsslCon
            // 
            this.tsslCon.Name = "tsslCon";
            this.tsslCon.Size = new System.Drawing.Size(12, 17);
            this.tsslCon.Text = "-";
            this.tsslCon.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // системаToolStripMenuItem
            // 
            this.системаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem,
            this.выходИзПрофиляToolStripMenuItem,
            this.toolStripMenuItem1,
            this.настрокаПрофиляToolStripMenuItem,
            this.конфигурацияПодключенияToolStripMenuItem,
            this.toolStripMenuItem2,
            this.завершитьРаботуИнформационнойСистемыToolStripMenuItem});
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.системаToolStripMenuItem.Text = "Система";
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.авторизацияToolStripMenuItem.Text = "Авторизация...";
            // 
            // выходИзПрофиляToolStripMenuItem
            // 
            this.выходИзПрофиляToolStripMenuItem.Name = "выходИзПрофиляToolStripMenuItem";
            this.выходИзПрофиляToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.выходИзПрофиляToolStripMenuItem.Text = "Выход из профиля";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(328, 6);
            // 
            // настрокаПрофиляToolStripMenuItem
            // 
            this.настрокаПрофиляToolStripMenuItem.Name = "настрокаПрофиляToolStripMenuItem";
            this.настрокаПрофиляToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.настрокаПрофиляToolStripMenuItem.Text = "Настрока профиля...";
            // 
            // конфигурацияПодключенияToolStripMenuItem
            // 
            this.конфигурацияПодключенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конфигурацияПодключенияToolStripMenuItem1,
            this.системаToolStripMenuItem1});
            this.конфигурацияПодключенияToolStripMenuItem.Name = "конфигурацияПодключенияToolStripMenuItem";
            this.конфигурацияПодключенияToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.конфигурацияПодключенияToolStripMenuItem.Text = "Настройки";
            // 
            // конфигурацияПодключенияToolStripMenuItem1
            // 
            this.конфигурацияПодключенияToolStripMenuItem1.Name = "конфигурацияПодключенияToolStripMenuItem1";
            this.конфигурацияПодключенияToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.конфигурацияПодключенияToolStripMenuItem1.Text = "Конфигурация подключения...";
            this.конфигурацияПодключенияToolStripMenuItem1.Click += new System.EventHandler(this.конфигурацияПодключенияToolStripMenuItem_Click);
            // 
            // системаToolStripMenuItem1
            // 
            this.системаToolStripMenuItem1.Name = "системаToolStripMenuItem1";
            this.системаToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.системаToolStripMenuItem1.Text = "Система...";
            this.системаToolStripMenuItem1.Click += new System.EventHandler(this.системаToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(328, 6);
            // 
            // завершитьРаботуИнформационнойСистемыToolStripMenuItem
            // 
            this.завершитьРаботуИнформационнойСистемыToolStripMenuItem.Name = "завершитьРаботуИнформационнойСистемыToolStripMenuItem";
            this.завершитьРаботуИнформационнойСистемыToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.завершитьРаботуИнформационнойСистемыToolStripMenuItem.Text = "Завершить работу информационной системы";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартыСпециальностиToolStripMenuItem,
            this.учебныеГруппыToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.дисциплиныToolStripMenuItem,
            this.типУчебныхЗанятийToolStripMenuItem,
            this.кадровоеОбеспечениеToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // стандартыСпециальностиToolStripMenuItem
            // 
            this.стандартыСпециальностиToolStripMenuItem.Name = "стандартыСпециальностиToolStripMenuItem";
            this.стандартыСпециальностиToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.стандартыСпециальностиToolStripMenuItem.Text = "Стандарты - Специальности...";
            this.стандартыСпециальностиToolStripMenuItem.Click += new System.EventHandler(this.стандартыСпециальностиToolStripMenuItem_Click);
            // 
            // учебныеГруппыToolStripMenuItem
            // 
            this.учебныеГруппыToolStripMenuItem.Name = "учебныеГруппыToolStripMenuItem";
            this.учебныеГруппыToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.учебныеГруппыToolStripMenuItem.Text = "Учебные группы...";
            this.учебныеГруппыToolStripMenuItem.Click += new System.EventHandler(this.учебныеГруппыToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.студентыToolStripMenuItem.Text = "Студенты...";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины...";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // типУчебныхЗанятийToolStripMenuItem
            // 
            this.типУчебныхЗанятийToolStripMenuItem.Name = "типУчебныхЗанятийToolStripMenuItem";
            this.типУчебныхЗанятийToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.типУчебныхЗанятийToolStripMenuItem.Text = "Тип учебных занятий...";
            this.типУчебныхЗанятийToolStripMenuItem.Click += new System.EventHandler(this.типУчебныхЗанятийToolStripMenuItem_Click);
            // 
            // кадровоеОбеспечениеToolStripMenuItem
            // 
            this.кадровоеОбеспечениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.должностиToolStripMenuItem,
            this.данныеСотрудниковToolStripMenuItem,
            this.совместительствоToolStripMenuItem,
            this.распределениеНагрузокToolStripMenuItem});
            this.кадровоеОбеспечениеToolStripMenuItem.Name = "кадровоеОбеспечениеToolStripMenuItem";
            this.кадровоеОбеспечениеToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.кадровоеОбеспечениеToolStripMenuItem.Text = "Кадровое обеспечение";
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.должностиToolStripMenuItem.Text = "Должности...";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // данныеСотрудниковToolStripMenuItem
            // 
            this.данныеСотрудниковToolStripMenuItem.Name = "данныеСотрудниковToolStripMenuItem";
            this.данныеСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.данныеСотрудниковToolStripMenuItem.Text = "Данные сотрудников...";
            this.данныеСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.данныеСотрудниковToolStripMenuItem_Click);
            // 
            // распределениеНагрузокToolStripMenuItem
            // 
            this.распределениеНагрузокToolStripMenuItem.Name = "распределениеНагрузокToolStripMenuItem";
            this.распределениеНагрузокToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.распределениеНагрузокToolStripMenuItem.Text = "Распределение нагрузок...";
            this.распределениеНагрузокToolStripMenuItem.Click += new System.EventHandler(this.распределениеНагрузокToolStripMenuItem_Click);
            // 
            // совместительствоToolStripMenuItem
            // 
            this.совместительствоToolStripMenuItem.Name = "совместительствоToolStripMenuItem";
            this.совместительствоToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.совместительствоToolStripMenuItem.Text = "Совместительство...";
            this.совместительствоToolStripMenuItem.Click += new System.EventHandler(this.совместительствоToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 414);
            this.Controls.Add(this.strpInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Учебный журнал";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.strpInfo.ResumeLayout(false);
            this.strpInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip strpInfo;
        private System.Windows.Forms.ToolStripStatusLabel tssldateTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslCon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрофиляToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настрокаПрофиляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конфигурацияПодключенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem завершитьРаботуИнформационнойСистемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартыСпециальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебныеГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конфигурацияПодключенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типУчебныхЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кадровоеОбеспечениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распределениеНагрузокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem совместительствоToolStripMenuItem;
    }
}

