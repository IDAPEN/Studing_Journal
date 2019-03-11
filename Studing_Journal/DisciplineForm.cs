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
    public partial class DisciplineForm : Form
    {
        DataBaseTables dataTable = new DataBaseTables();
        DataBaseProcedure procedure = new DataBaseProcedure();
        public DisciplineForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fillDiccipline);
            thread.Start();
        }

        private void fillDiccipline()
        {
            Action action = () =>
             {
                 dataTable.dtDisciplineFill();
                 dataTable.dependency.OnChange += onchange_Diacipline;
                 ltbDiscipline.DataSource = dataTable.dtDiscipline;
                 ltbDiscipline.ValueMember = "ID_Discipline";
                 ltbDiscipline.DisplayMember = "Discipline_Info";
             };
            Invoke(action);
            
        }

        private void onchange_Diacipline(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                fillDiccipline();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ltbDiscipline.SelectedIndex = ltbDiscipline.FindString(tbSearch.Text);
            ltbDiscipline_Click(sender, e);
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Введите название или код дисциплины...")
                tbSearch.Clear();
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Введите название или код дисциплины...";
        }

        private void ltbDiscipline_Click(object sender, EventArgs e)
        {
            try
            {
                int j = 0;
                tbPrefix.Clear();
                tbName.Clear();
                string str = ltbDiscipline.Text;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != ' ')
                    {
                        tbPrefix.Text += str[i];
                    }
                    else
                    {
                        if (j < 1)
                        {
                            tbPrefix.Text += " ";
                            j++;
                        }
                        else
                        {
                            tbName.Text = str.Substring(i);
                            break;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Registry_Class.error_message);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            procedure.spDiscipline_Insert(tbPrefix.Text, tbName.Text);
            tbPrefix.Clear();
            tbName.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            procedure.spDiscipline_Update(Convert.ToInt32(ltbDiscipline.SelectedValue.ToString()),
                tbPrefix.Text, tbName.Text);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление дисциплины","Удалить дисциплину "+ltbDiscipline.Text+"?",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spDiscipline_Delete(Convert.ToInt32(ltbDiscipline.SelectedValue.ToString()));
                    break;
            }
        }
    }
}
