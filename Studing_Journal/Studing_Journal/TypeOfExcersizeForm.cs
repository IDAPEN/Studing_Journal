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

namespace Studing_Journal
{
    public partial class TypeOfExcersizeForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DataBaseProcedure procedure = new DataBaseProcedure();
        public TypeOfExcersizeForm()
        {
            InitializeComponent();
        }

        private void TypeOfExcersizeForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(typeOfDisciplineFill);
            thread.Start();
        }

        private void typeOfDisciplineFill()
        {
            Action action = () =>
             {
                 tables.dtExercise_TypeFill();
                 tables.dependency.OnChange += onChange_Type;
                 ltbTypeOfExcersize.DataSource = tables.dtExercise_Type;
                 ltbTypeOfExcersize.ValueMember = "ID_Exercise_Type";
                 ltbTypeOfExcersize.DisplayMember = "Name_of_exercise";
             };
            Invoke(action);
        }

        private void onChange_Type(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                typeOfDisciplineFill();
        }

        private void ltbTypeOfExcersize_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTypeName.Text = ltbTypeOfExcersize.Text;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Registry_Class.error_message);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            procedure.spExercise_Type_Insert(tbTypeName.Text);
            tbTypeName.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            procedure.spExercise_Type_Update(Convert.ToInt32(ltbTypeOfExcersize.SelectedValue.ToString()),
                tbTypeName.Text);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(
                "Удалить тип учебного занятия "+ltbTypeOfExcersize.Text+"?", "Удаление типа учебного занятия",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spExercise_Type_Delete(Convert.ToInt32(ltbTypeOfExcersize.SelectedValue.ToString()));
                    break;
            }
        }
    }
}
