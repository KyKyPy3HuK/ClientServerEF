
using CourseWorkApp.View;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
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
        List<string> statusList = new List<string>();
        
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
            statusList.Add("Открыта");
            statusList.Add("Выполняется");
            statusList.Add("Отклонена");
            statusList.Add("Выполнена");
            InitializeComponent();
            ConnectDb();
            FillIssueDgv();
            FillInventDgv();
            FillVahtDgv();
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

        void FillVahtDgv()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT *" +
                "FROM vahtsView";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            vahtsDgv.DataSource = dataTable;
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventAdd inventAddDlg = new inventAdd();
            inventAddDlg.roomComboBox.DataSource = FillRoomsNumbers();

            switch (inventAddDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("insertInvent", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", inventAddDlg.nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@date", inventAddDlg.dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@cost", inventAddDlg.costNumeric.Value);
                        cmd.Parameters.AddWithValue("@room", int.Parse(inventAddDlg.roomComboBox.SelectedItem.ToString()));
                        cmd.ExecuteNonQuery();
                        FillInventDgv();
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

        List<string> FillRoomsNumbers()
        {
            List<string> dataList = new List<string>();

            SqlCommand addRoomsCmd = conn.CreateCommand();
            addRoomsCmd.CommandText = "SELECT Комнаты.Номер FROM Комнаты";
            var reader = addRoomsCmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader["Номер"].ToString());
            }
            reader.Close();
            return dataList;
        }

        List<string> FillStudNumbers()
        {
            List<string> dataList = new List<string>();

            SqlCommand addStudCmd = conn.CreateCommand();
            addStudCmd.CommandText = "SELECT Проживающие.Код FROM Проживающие";
            var reader = addStudCmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader["Код"].ToString());
            }
            reader.Close();
            return dataList;
        }

        List<string> FillvahtWorkerNumbers()
        {
            List<string> dataList = new List<string>();

            SqlCommand addWorkersCmd = conn.CreateCommand();
            addWorkersCmd.CommandText = "SELECT Работники.Код, Работники.ФИО FROM Работники WHERE Должность = 'Вахтер'";
            var reader = addWorkersCmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader["Код"].ToString() + " " + reader["ФИО"]);
            }
            reader.Close();
            return dataList;
        }
        List<string> FillVahtTypes()
        {
            List<string> dataList = new List<string>();

            SqlCommand addVahtTypesCmd = conn.CreateCommand();
            addVahtTypesCmd.CommandText = "SELECT ТипыВахт.Название FROM ТипыВахт";
            var reader = addVahtTypesCmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader["Название"].ToString());
            }
            reader.Close();
            return dataList;
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = inventDgv.SelectedRows[0];

            inventUpdate inventUpdateDlg = new inventUpdate();
            int code = (int)selectedRow.Cells[0].Value;
            string name = (string)selectedRow.Cells[1].Value;
            DateTime date = (DateTime)selectedRow.Cells[2].Value;
            int cost = (int)selectedRow.Cells[3].Value;
            int room = (int)selectedRow.Cells[4].Value;

            inventUpdateDlg.numLabel.Text = code.ToString();
            inventUpdateDlg.nameTextBox.Text = name;
            inventUpdateDlg.dateTimePicker.Value = date;
            inventUpdateDlg.costNumeric.Value = cost;
            inventUpdateDlg.roomComboBox.DataSource = FillRoomsNumbers();
            inventUpdateDlg.roomComboBox.SelectedItem = room.ToString();
            switch (inventUpdateDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("updateInvent", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@name", inventUpdateDlg.nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@date", inventUpdateDlg.dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@cost", inventUpdateDlg.costNumeric.Value);
                        cmd.Parameters.AddWithValue("@room", int.Parse(inventUpdateDlg.roomComboBox.SelectedItem.ToString()));
                        cmd.ExecuteNonQuery();
                        FillInventDgv();
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

            DataGridViewRow selectedRow = inventDgv.SelectedRows[0];

            int code = (int)selectedRow.Cells[0].Value;
            string name = (string)selectedRow.Cells[1].Value;
            DateTime date = (DateTime)selectedRow.Cells[2].Value;
            int cost = (int)selectedRow.Cells[3].Value;
            int room = (int)selectedRow.Cells[4].Value;

            inventRemoveDlg.numLabel.Text = code.ToString();
            inventRemoveDlg.nameLabel.Text = name;
            inventRemoveDlg.dateLabel.Text = date.ToString();
            inventRemoveDlg.costLabel.Text = cost.ToString();
            inventRemoveDlg.roomLabel.Text = room.ToString();

            switch (inventRemoveDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("deleteInvent", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.ExecuteNonQuery();
                        FillInventDgv();
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
            vahtAddDlg.typeComboBox.DataSource = FillVahtTypes();
            vahtAddDlg.workerComboBox.DataSource = FillvahtWorkerNumbers();
            switch (vahtAddDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("insertVaht", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@type", vahtAddDlg.typeComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@date", vahtAddDlg.dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@duration", vahtAddDlg.durationNumeric.Value);
                        cmd.Parameters.AddWithValue("@worker",long.Parse(vahtAddDlg.workerComboBox.SelectedItem.ToString().Split(" ")[0]));
                        cmd.ExecuteNonQuery();
                        FillVahtDgv();
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
            DataGridViewRow selectedRow = vahtsDgv.SelectedRows[0];
            int code = (int)selectedRow.Cells[0].Value;
            string type = (string)selectedRow.Cells[1].Value;
            DateTime date = (DateTime)selectedRow.Cells[2].Value;
            int duration = (int)selectedRow.Cells[3].Value;
            string worker = selectedRow.Cells[4].Value.ToString() + " " + (string)selectedRow.Cells[5].Value;

            vahtUpdDlg.codeLabel.Text = code.ToString();
            vahtUpdDlg.typeComboBox.DataSource = FillVahtTypes();
            vahtUpdDlg.typeComboBox.SelectedItem = type;
            vahtUpdDlg.dateTimePicker.Value = date;
            vahtUpdDlg.timeNumeric.Value = duration;
            vahtUpdDlg.workerComboBox.DataSource = FillvahtWorkerNumbers();
            vahtUpdDlg.workerComboBox.SelectedItem = worker;
            switch (vahtUpdDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("updateVaht", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@num", code);
                        cmd.Parameters.AddWithValue("@type", vahtUpdDlg.typeComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@date", vahtUpdDlg.dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@duration", vahtUpdDlg.timeNumeric.Value);
                        cmd.Parameters.AddWithValue("@worker", long.Parse(vahtUpdDlg.workerComboBox.SelectedItem.ToString().Split(" ")[0]));
                        cmd.ExecuteNonQuery();
                        FillVahtDgv();
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

            DataGridViewRow selectedRow = vahtsDgv.SelectedRows[0];
            int code = (int)selectedRow.Cells[0].Value;
            string type = (string)selectedRow.Cells[1].Value;
            DateTime date = (DateTime)selectedRow.Cells[2].Value;
            int duration = (int)selectedRow.Cells[3].Value;
            string worker = selectedRow.Cells[4].Value.ToString() + " " + (string)selectedRow.Cells[5].Value;

            vahtRemoveDlg.numLabel.Text = code.ToString();
            vahtRemoveDlg.typeLabel.Text = type;
            vahtRemoveDlg.dateLabel.Text = date.ToString();
            vahtRemoveDlg.timeLabel.Text = duration.ToString();
            vahtRemoveDlg.workerLabel.Text = worker;
            switch (vahtRemoveDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("deleteVaht", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@num", code);
                        cmd.ExecuteNonQuery();
                        FillVahtDgv();
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

            issueAddDlg.AutorComboBox.DataSource = FillStudNumbers();

            switch (issueAddDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("insertIssue", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@title", issueAddDlg.titleTextBox.Text);
                        cmd.Parameters.AddWithValue("@text", issueAddDlg.textTextBox1.Text);
                        cmd.Parameters.AddWithValue("@author", long.Parse(issueAddDlg.AutorComboBox.SelectedItem.ToString()));
                        cmd.ExecuteNonQuery();
                        FillIssueDgv();
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
            DataGridViewRow selectedRow = issuesDgv.SelectedRows[0];

            int code = (int)selectedRow.Cells[0].Value;
            string title = (string)selectedRow.Cells[1].Value;
            string status = (string)selectedRow.Cells[2].Value;
            DateTime date = (DateTime)selectedRow.Cells[3].Value;
            string text = (string)selectedRow.Cells[4].Value;
            string authorName = (string)selectedRow.Cells[5].Value;

            issueUpdateDlg.numLabel.Text = code.ToString();
            issueUpdateDlg.titleLabel.Text = title;
            issueUpdateDlg.statusComboBox.DataSource = statusList;
            issueUpdateDlg.statusComboBox.SelectedItem = status;
            issueUpdateDlg.dataLabel.Text = "Дата составления: " + date.ToString();
            issueUpdateDlg.textTextBox.Text = text;
            issueUpdateDlg.autorLabel.Text = "Составитель: " + authorName;

            switch (issueUpdateDlg.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        SqlCommand cmd = new SqlCommand("updateIssue", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@num", code);
                        cmd.Parameters.AddWithValue("@status", issueUpdateDlg.statusComboBox.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        FillIssueDgv();
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

        private void вычислитьОбщуюСтоимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventAllCostDlg allCostDlg = new inventAllCostDlg();
            SqlCommand cmd = new SqlCommand("computeAllCost", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int cost = 0;
            cmd.Parameters.AddWithValue("@cost",cost);
            cmd.Parameters[0].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cost = (int)cmd.Parameters[0].Value;
            allCostDlg.allCostLabel.Text = "Общая стоимость всего инвентаря : " + cost.ToString() + " руб.";
            allCostDlg.Show();
        }
    }
}
