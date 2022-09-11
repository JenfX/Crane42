using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using System.Threading;
using Telegram.Bot.Types.ReplyMarkups;
using System.Data.SqlClient;

namespace EntityFramework
{
    public partial class StorehouseForm : Form
    {
        private const string table = "Items"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private bool newRow = false;
        private bool generated = false;

        public StorehouseForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                generated = false;

                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [DELETE] FROM Items", sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                sqlDataAdapter.Fill(database1DataSet, table);

                dataGridView.DataSource = database1DataSet.Tables[table];

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, i] = linkCell;
                }

                for (int i = 0; i < dataGridView.Rows.Count-1; i++)
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
                database1DataSet.Tables[table].Clear();
                sqlDataAdapter.Fill(database1DataSet, table);

                dataGridView.DataSource = database1DataSet.Tables[table];
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

        private void StorehouseForm_Load(object sender, EventArgs e)
        {
            this.unitsTableAdapter.Fill(this.database1DataSet1.Units);
            this.itemsTableAdapter.Fill(this.database1DataSet.Items);

            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();
            LoadData();

            dataGridView.Columns[0].Width = 25;
            dataGridView.Columns[1].Width = 125;
            dataGridView.Columns[2].Width = 400;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 60;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 80;
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
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
                            database1DataSet.Items.Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(database1DataSet, table);
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView.Rows.Count - 2;
                        DataRow row = database1DataSet.Items.NewRow();

                        row["CatNumber"] = dataGridView.Rows[rowIndex].Cells["CatNumber"].Value;
                        row["Naming"] = dataGridView.Rows[rowIndex].Cells["Naming"].Value;
                        row["Unit_ID"] = dataGridView.Rows[rowIndex].Cells["Unit_ID"].Value;
                        row["Quantity"] = dataGridView.Rows[rowIndex].Cells["Quantity"].Value;
                        row["Price"] = dataGridView.Rows[rowIndex].Cells["Price"].Value;


                        database1DataSet.Items.Rows.Add(row);
                        database1DataSet.Items.Rows.RemoveAt(database1DataSet.Tables[table].Rows.Count - 1);
                        dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2);
                        dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value = "Delete";

                        sqlDataAdapter.Update(database1DataSet, table);
                        newRow = false;
                    }
                    else if (task == "Update")
                    {
                        if (MessageBox.Show("Применить изменения?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int index = e.RowIndex;
                            database1DataSet.Items.Rows[index]["CatNumber"] = dataGridView.Rows[index].Cells["CatNumber"].Value;
                            database1DataSet.Items.Rows[index]["Naming"] = dataGridView.Rows[index].Cells["Naming"].Value;
                            database1DataSet.Items.Rows[index]["Unit_ID"] = dataGridView.Rows[index].Cells["Unit_ID"].Value;
                            database1DataSet.Items.Rows[index]["Quantity"] = dataGridView.Rows[index].Cells["Quantity"].Value;
                            database1DataSet.Items.Rows[index]["Price"] = dataGridView.Rows[index].Cells["Price"].Value;

                            sqlDataAdapter.Update(database1DataSet, table);
                            dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value = "Delete";
                        }
                    }
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

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!newRow && generated && e.ColumnIndex != 6)
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
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            //проверять индексы
            if (dataGridView.CurrentCell.ColumnIndex == 4 || dataGridView.CurrentCell.ColumnIndex == 5)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
