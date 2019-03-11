using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Studing_Journal
{
    public partial class ApplicationConfigurationForm : Form
    {
        decimal TM, RM, BM, LM;
        Registry_Class registry = new Registry_Class();
        public ApplicationConfigurationForm()
        {
            InitializeComponent();
        }

        private void ApplicationConfigurationForm_Load(object sender, 
            EventArgs e)
        {
            registry.ConfigurationGet();
            rtbOrganizationName.Text = Registry_Class.OrganizationName;
            tbPath.Text = Registry_Class.DirPath;
            nudTopMerg.Value = (decimal)Registry_Class.DocTM;
            nudRightMerg.Value = (decimal)Registry_Class.DocRM;
            nudBottomMerg.Value = (decimal)Registry_Class.DocBM;
            nudLeftMerg.Value = (decimal)Registry_Class.DocLM;
            TM = nudTopMerg.Value;
            RM = nudRightMerg.Value;
            BM = nudBottomMerg.Value;
            LM = nudLeftMerg.Value;
            pnText.Top += (int)TM*10;
            pnText.Height -= (int)TM * 10;
            pnText.Width -= (int)RM * 10;
            pnText.Height -=(int) BM * 10;
            pnText.Left += (int)LM * 10;
            pnText.Width -= (int)LM * 10;

        }

        private void Button_Change (object sender, EventArgs e)
        {
            switch (tcConfig.SelectedIndex)
            {
                case (0):
                    OrganizationSave();
                    break;
                case (1):
                    DocumentSave();
                    break;
            }
        }

        private void OrganizationSave()
        {
            registry.MajorConfigurationSet(rtbOrganizationName.Text);
        }

        private void DocumentSave()
        {
            string document_default_path = "";
            switch (tbPath.Text == "")
            {
                case (true):
                    document_default_path = 
                        "C:\\Users\\" + SystemInformation.UserName 
                        + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
                case (false):
                    document_default_path = tbPath.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }
            registry.DocumentConfigurationSet(tbPath.Text, nudLeftMerg.Value, 
                nudTopMerg.Value,
                nudRightMerg.Value, nudBottomMerg.Value);
        }

        private void nudLeftMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudLeftMerg.Value > LM)
            {
                pnText.Width -= (int)nudLeftMerg.Value;
                pnText.Left += (int)nudLeftMerg.Value;
            }
            else
            {
                pnText.Width += (int)nudLeftMerg.Value;
                pnText.Left -= (int)nudLeftMerg.Value;
            }
            LM = nudLeftMerg.Value;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            OrganizationSave();
            DocumentSave();
            Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPath.Text =  folderBrowserDialog1.SelectedPath + "\\Отчёты\\";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudRightMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudRightMerg.Value > RM)
                pnText.Width -= (int)nudRightMerg.Value;
            else
                pnText.Width += (int)nudRightMerg.Value;
            RM = nudRightMerg.Value;
        }

        private void nudTopMerg_ValueChanged(object sender, EventArgs e)
        {
            if(nudTopMerg.Value >TM)
            {
                pnText.Height -= (int)nudTopMerg.Value;
                pnText.Top += (int)nudTopMerg.Value;
            }
            else
            {
                pnText.Height += (int)nudTopMerg.Value;
                pnText.Top -= (int)nudTopMerg.Value;
            }
            TM = nudTopMerg.Value;
        }

        private void nudBottomMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudBottomMerg.Value > BM)
            pnText.Height -= (int)nudBottomMerg.Value;
            else
            pnText.Height += (int)nudBottomMerg.Value;
            BM = nudBottomMerg.Value;
        }
    }
}
