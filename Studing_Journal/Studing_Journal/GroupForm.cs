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
    public partial class GroupForm : Form
    {
        DataBaseProcedure procedure = new DataBaseProcedure();
        public GroupForm()
        {
            InitializeComponent();
        }

        private void GroupLoad()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables = new DataBaseTables();
                    tables.qrGroup += " and [Department_ID] = " + cbDepartment.SelectedValue.ToString();
                    tables.dtGroupFill();
                    tables.dependency.OnChange += Grouponchange;
                    lstbGroup.DataSource = tables.dtGroup;
                    lstbGroup.ValueMember = "ID_Group";
                    lstbGroup.DisplayMember = "Group_name";
                }
                catch
                {

                }
                
            };
            Invoke(action);
        }

        private void Grouponchange (object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GroupLoad();
        }

        private void DepartmentLoad()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables = new DataBaseTables();
                    tables.dtDepartmentFill();
                    tables.dependency.OnChange += Departmentonchange;
                    cbDepartment.DataSource = tables.dtDepartment;
                    cbDepartment.ValueMember = "ID_Department";
                    cbDepartment.DisplayMember = "Departments_List";
                }
                catch
                {

                }
            };
            Invoke(action);
            Thread threadGroup = new Thread(GroupLoad);
            threadGroup.Start();
        }

        private void Departmentonchange (object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                DepartmentLoad();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            Thread threadDepartment = new Thread(DepartmentLoad);
            threadDepartment.Start();   
        }

        private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            GroupLoad();
        }

        private void tbGroupSearch_TextChanged(object sender, EventArgs e)
        {
            lstbGroup.SelectedIndex = lstbGroup.FindString(tbGroupSearch.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstbGroup_Click(object sender, EventArgs e)
        {
            tbGroupName.Text = lstbGroup.Text;
        }

        private void btGroupInsert_Click(object sender, EventArgs e)
        {
            procedure.spGroup_Insert(tbGroupName.Text,Convert.ToInt32(cbDepartment.SelectedValue.ToString()));
            tbGroupName.Clear();
        }

        private void btGroupUpdate_Click(object sender, EventArgs e)
        {
            procedure.spGroup_Update(Convert.ToInt32(lstbGroup.SelectedValue.ToString()), tbGroupName.Text, Convert.ToInt32(cbDepartment.SelectedValue.ToString()));
        }

        private void btGroupDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление группы","Удалить группу "+lstbGroup.Text+"?",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spGroup_Delete(Convert.ToInt32(lstbGroup.SelectedValue.ToString()));
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void tbGroupSearch_Enter(object sender, EventArgs e)
        {
            if (tbGroupSearch.Text == "Введите название группы...")
                tbGroupSearch.Clear();
        }

        private void tbGroupSearch_Leave(object sender, EventArgs e)
        {
            if (tbGroupSearch.Text == "")
                tbGroupSearch.Text = "Введите название группы...";
        }

        private void btError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Registry_Class.error_message);
        }
    }
}
