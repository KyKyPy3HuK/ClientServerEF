using CourseWorkApp.Model;
using CourseWorkApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
