using CourseWorkApp.Model;
using CourseWorkApp.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkApp
{
    public partial class MainForm : Form
    {

        SqlConnection conn = new SqlConnection();

        void ConnectDb()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Config"].ConnectionString;
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ConnectDb();
            FillInventDgv();
            FillIssueDgv();
        }
        void FillIssueDgv()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT *" +
                "FROM issuesView";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            issuesDgv.DataSource = dataTable;
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
        void FillInventDgv()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT *" +
                "FROM inventView";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            inventDgv.DataSource = dataTable;
            dataTable.Clear();
            adapter.Fill(dataTable);

        }
        
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventAdd inventAddDlg = new inventAdd();
            switch (inventAddDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventUpdate inventUpdateDlg = new inventUpdate();
            switch (inventUpdateDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {

                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inventRemove inventRemoveDlg = new inventRemove();
            switch (inventRemoveDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {

                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VahtAddDlg vahtAddDlg = new VahtAddDlg();
            switch (vahtAddDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VahtUpdDlg vahtUpdDlg = new VahtUpdDlg();
            switch (vahtUpdDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VahtRemoveDlg vahtRemoveDlg = new VahtRemoveDlg();
            switch (vahtRemoveDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IssueAddDlg issueAddDlg = new IssueAddDlg();
            switch (issueAddDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void обновитьСтатусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueUpdateDlg issueUpdateDlg = new IssueUpdateDlg();
            switch (issueUpdateDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
