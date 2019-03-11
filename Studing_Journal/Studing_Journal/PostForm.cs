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
    public partial class PostForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DataBaseProcedure procedure = new DataBaseProcedure();
        string Postqr = "";
        public PostForm()
        {
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            Postqr = tables.qrPost;
            Thread thread = new Thread(cbPostFill);
            thread.Start();
        }

        private void cbPostFill()
        {
            Action action = () =>
             {
                 DataBaseTables baseTables = new DataBaseTables();
                 baseTables.dtPostFill();
                 baseTables.dtPost.Rows.Add(null,"Нет вышестоящей должности",null);
                 baseTables.dependency.OnChange += onChangePostParent;
                 cbPostParent.DataSource = baseTables.dtPost;
                 cbPostParent.ValueMember = "ID_Post";
                 cbPostParent.DisplayMember = "Post_title";
                 Thread thread = new Thread(ltbPost_Fill);
                 thread.Start();
             };
            Invoke(action);
        }

        private void onChangePostParent(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                cbPostFill();
        }

        private void ltbPost_Fill()
        {
            Action action = () =>
             {
                 try
                 {
                     tables.dtPost.Clear();
                     tables.dtPostFill();
                     tables.dependency.OnChange += onChangePost;
                     ltbPost.DataSource = tables.dtPost;
                     ltbPost.ValueMember = "ID_Post";
                     ltbPost.DisplayMember = "Post_title";
                 }
                 catch(Exception ex)
                 {
                     Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
                 }
             };
            Invoke(action);
        }

        private void onChangePost(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                ltbPost_Fill();
        }

        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            tables.qrPost = "";        
            switch (cbFilter.CheckState)
            {
                case CheckState.Checked:
                    tables.qrPost = Postqr + " and [Post_ID] = " + cbPostParent.SelectedValue.ToString();
                    break;
                case CheckState.Unchecked:
                    tables.qrPost = Postqr;
                    break;
            }
            ltbPost_Fill();
        }

        private void cbPostParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            tables.dependency.OnChange -= onChangePost;
            cbFilter_CheckedChanged(sender, e);
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
            procedure.spPost_Insert(tbPostName.Text, Convert.ToInt32(cbPostParent.SelectedValue.ToString()));
            tbPostName.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            procedure.spPost_Update(Convert.ToInt32(ltbPost.SelectedValue.ToString()),
                tbPostName.Text, Convert.ToInt32(cbPostParent.SelectedValue.ToString()));
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить должность "+ltbPost.Text+"?", "Удаление должности",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPost_Delete(Convert.ToInt32(ltbPost.SelectedValue.ToString()));
                    break;
            }
        }

        private void ltbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPostName.Text = ltbPost.Text;
        }
    }
}
