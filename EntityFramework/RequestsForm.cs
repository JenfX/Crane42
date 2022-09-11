using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using System.Threading;
using Telegram.Bot.Types.ReplyMarkups;

namespace EntityFramework
{
    public partial class RequestsForm : Form
    {
        private const string table = "Requests"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private bool newRow = false;
        private bool generated = false;

        public RequestsForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                generated = false;

                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [DELETE] FROM Requests", sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                sqlDataAdapter.Fill(database1DataSetReq, table);

                dataGridView.DataSource = database1DataSetReq.Tables[table];
                dataGridView.Sort(dataGridView.Columns["Date"], ListSortDirection.Ascending);

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, i] = linkCell;
                }

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    dataGridView[dataGridView.Columns.Count - 1, i].Value = "Delete";
                }
                generated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                generated = false;
                database1DataSetReq.Tables[table].Clear();
                sqlDataAdapter.Fill(database1DataSetReq, table);

                dataGridView.DataSource = database1DataSetReq.Tables[table];
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, i] = linkCell;
                }
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    dataGridView[dataGridView.Columns.Count - 1, i].Value = "Delete";
                }
                generated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            this.driversTableAdapter.Fill(this.database1DataSetReq.Drivers);
            this.cranesTableAdapter.Fill(this.database1DataSetReq.Cranes);
            this.requestsTableAdapter.Fill(this.database1DataSetReq.Requests);

            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();
            LoadData();

            dataGridView.Columns[0].Width = 75;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 450;
            dataGridView.Columns[4].Width = 60;
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView.Columns.Count - 1)
                {
                    string task = dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView.Rows.RemoveAt(rowIndex);
                            database1DataSetReq.Requests.Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(database1DataSetReq, table);
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView.Rows.Count - 2;
                        DataRow row = database1DataSetReq.Requests.NewRow();

                        row["Date"] = dataGridView.Rows[rowIndex].Cells["Date"].Value;
                        row["Crane_ID"] = dataGridView.Rows[rowIndex].Cells["Crane_ID"].Value;
                        row["Driver_ID"] = dataGridView.Rows[rowIndex].Cells["Driver_ID"].Value;
                        row["RequestText"] = dataGridView.Rows[rowIndex].Cells["RequestText"].Value;

                        database1DataSetReq.Requests.Rows.Add(row);
                        database1DataSetReq.Requests.Rows.RemoveAt(database1DataSetReq.Tables[table].Rows.Count - 1);
                        dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2);
                        dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value = "Delete";

                        sqlDataAdapter.Update(database1DataSetReq, table);
                        newRow = false;
                    }
                    /*else if (task == "Update")
                    {
                        if (MessageBox.Show("Применить изменения?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int index = e.RowIndex;
                            database1DataSetReq.Requests.Rows[index]["Date"] = dataGridView.Rows[index].Cells["Date"].Value;
                            database1DataSetReq.Requests.Rows[index]["Crane_ID"] = dataGridView.Rows[index].Cells["Crane_ID"].Value;
                            database1DataSetReq.Requests.Rows[index]["Driver_ID"] = dataGridView.Rows[index].Cells["Driver_ID"].Value;
                            database1DataSetReq.Requests.Rows[index]["RequestText"] = dataGridView.Rows[index].Cells["RequestText"].Value;

                            sqlDataAdapter.Update(database1DataSetReq, table);
                            dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value = "Delete";
                        }
                    }*/
                    ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRow == false)
                {
                    newRow = true;
                    int lastRow = dataGridView.Rows.Count - 2;
                    DataGridViewRow row = dataGridView.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, lastRow] = linkCell;
                    row.Cells["Delete"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!newRow && generated && e.ColumnIndex != 4)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dataGridView.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, rowIndex] = linkCell;
                    row.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
