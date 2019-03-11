using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Studing_Journal
{
    public partial class ConectionForm : Form
    {
        private DataBase_Configuration configuration = new DataBase_Configuration();
        private Int32 status = 1;
        public ConectionForm()
        {
            InitializeComponent();
        }

        private void ConectionForm_Load(object sender, EventArgs e)
        {
            switch(DataBase_Configuration.logCon)
            {
                case (true):
                    cbIPServer.Text = Registry_Class.DSIP;
                    cbDataSource.Text = Registry_Class.DSSN;
                    cbInitialCatalog.Text = Registry_Class.IC;
                    cbIPServer.Enabled = true;
                    cbDataSource.Enabled = true;
                    cbInitialCatalog.Enabled = true;
                    tbUserID.Enabled = true;
                    tbPassword.Enabled = true;
                    btCheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    tsslStatus.Visible = true;
                    tsslStatus.Text = "Поиск серверов";
                    configuration.dtServers += dtservers;
                    Thread thread = new Thread(configuration.Servers_get);
                    Thread threadMessage = new Thread(tsslMessage);
                    threadMessage.Start();
                    thread.Start();
                    break;
            }
            
        }

        private void dtservers(DataTable table)
        {
            status = 0;
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbIPServer.Items.Add(r[0]);
                    cbDataSource.Items.Add(r[1]);
                }
                cbIPServer.Enabled = true;
                cbDataSource.Enabled = true;
                tbUserID.Enabled = true;
                tbPassword.Enabled = true;
                btCheck.Enabled = true;
            };
            Invoke(action);
        }

        private void tsslMessage()
        {
            for (int i = 0; i<status;)
            {
                Thread.Sleep(500);
                Action action = () =>
                 {
                     switch (status)
                     {
                         case (1):
                             if (tsslStatus.Text != "Поиск серверов...")
                                 tsslStatus.Text += ".";
                             else
                                 tsslStatus.Text = "Поиск серверов";
                             break;
                         case (2):
                             if (tsslStatus.Text != "Поиск баз данных...")
                                 tsslStatus.Text += ".";
                             else
                                 tsslStatus.Text = "Поиск баз данных";
                             break;
                         case (0):
                             tsslStatus.Text = "-";
                             tsslStatus.Visible = false;
                             break;
                     }
                 };
                Invoke(action);
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            configuration.cds = cbIPServer.Text+@"\"+cbDataSource.Text;
            configuration.cui = tbUserID.Text;
            configuration.cpw = tbPassword.Text;
            status = 2;
            tsslStatus.Text = "Поиск баз данных";
            tsslStatus.Visible = true;
            configuration.dtDatabases += databases;
            Thread threadMessage = new Thread(tsslMessage);
            Thread thread = new Thread(configuration.Databases_get);
            threadMessage.Start();
            thread.Start();
        }

        private void databases(DataTable table)
        {
            Action action = () =>
            {
                cbInitialCatalog.Items.Clear();
                foreach(DataRow r in table.Rows)
                {
                    cbInitialCatalog.Items.Add(r[0]);
                }
                status = 0;
                cbInitialCatalog.Enabled = true;
                btConect.Enabled = true;
            };
            Invoke(action);
        }

        private void btConect_Click(object sender, EventArgs e)
        {
            Registry_Class registry = new Registry_Class();
            registry.Registry_Set(cbIPServer.Text, cbDataSource.Text,cbInitialCatalog.Text,tbUserID.Text, tbPassword.Text);
            ((MainForm)Owner).MainForm_Load(sender, e);
            DataBase_Configuration.logCon = true;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (DataBase_Configuration.logCon)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    Application.Exit();
                    break;
            }
        }
    }
}
