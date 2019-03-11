using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;


namespace Studing_Journal
{
    public partial class MainForm : Form
    {
        Registry_Class registry = new Registry_Class();
        DataBase_Configuration data = new DataBase_Configuration();

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            tsslCon.Visible = true;
            tsslCon.Text = "Опрделение серверера...";
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();
        }

        private void constate(bool value)
        {
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        tsslCon.Text = Registry_Class.DSIP+"\\"+Registry_Class.DSSN+" - "+Registry_Class.IC;
                        break;
                    case (false):
                        ConectionForm conection = new ConectionForm();
                        tsslCon.Text = "Подключение отсутвует!";
                        conection.Show(this);
                        break;
                }
            };
            Invoke(action);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssldateTime.Text = DateTime.Now.ToLongTimeString() + "/" + DateTime.Now.ToShortDateString();
        }

        private void конфигурацияПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConectionForm conectionForm = new ConectionForm();
            conectionForm.Show(this);
        }

        private void стандартыСпециальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandartDepartmentForm form = new StandartDepartmentForm();
            form.Show(this);
        }

        private void учебныеГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.Show(this);
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show(this);
        }

        private void системаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ApplicationConfigurationForm applicationConfigurationForm = new ApplicationConfigurationForm();
            applicationConfigurationForm.Show(this);
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisciplineForm disciplineForm = new DisciplineForm();
            disciplineForm.Show(this);
        }

        private void типУчебныхЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfExcersizeForm typeOfExcersizeForm = new TypeOfExcersizeForm();
            typeOfExcersizeForm.Show(this);
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostForm postForm = new PostForm();
            postForm.Show(this);
        }

        private void данныеСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BurdenCombinationEmployeeForm burdenCombinationEmployeeForm = new BurdenCombinationEmployeeForm();
            burdenCombinationEmployeeForm.tcEmployeeManupulation.SelectedIndex = 0;
            burdenCombinationEmployeeForm.Show(this);
        }

        private void совместительствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BurdenCombinationEmployeeForm burdenCombinationEmployeeForm = new BurdenCombinationEmployeeForm();
            burdenCombinationEmployeeForm.tcEmployeeManupulation.SelectedIndex = 1;
            burdenCombinationEmployeeForm.Show(this);
        }

        private void распределениеНагрузокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BurdenCombinationEmployeeForm burdenCombinationEmployeeForm = new BurdenCombinationEmployeeForm();
            burdenCombinationEmployeeForm.tcEmployeeManupulation.SelectedIndex = 2;
            burdenCombinationEmployeeForm.Show(this);
        }
    }
}
