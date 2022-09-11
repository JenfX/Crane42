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

namespace EntityFramework
{
    public partial class WaybillsForm : Form
    {
        private const string table = "Waybills"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private bool newRow = false;
        private bool generated = false;

        public WaybillsForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                generated = false;

                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [DELETE] FROM Waybills", sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                sqlDataAdapter.Fill(database1DataSetWB, table);

                dataGridView.DataSource = database1DataSetWB.Waybills;
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
                database1DataSetWB.Tables[table].Clear();
                sqlDataAdapter.Fill(database1DataSetWB, table);

                dataGridView.DataSource = database1DataSetWB.Tables[table];

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

        private void WaybillsForm_Load(object sender, EventArgs e)
        {
            this.workObjectsTableAdapter.Fill(this.database1DataSetWB.WorkObjects);
            this.customersTableAdapter.Fill(this.database1DataSetWB.Customers);
            this.driversTableAdapter.Fill(this.database1DataSetWB.Drivers);
            this.cranesTableAdapter.Fill(this.database1DataSetWB.Cranes);
            this.waybillsTableAdapter.Fill(this.database1DataSetWB.Waybills);

            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();
            LoadData();

            dataGridView.Columns[1].Width = 75;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 195;
            dataGridView.Columns[4].Width = 40;
            dataGridView.Columns[5].Width = 150;
            dataGridView.Columns[6].Width = 150;
            dataGridView.Columns[7].Width = 125;
            dataGridView.Columns[8].Width = 60;
            dataGridView.Columns[9].Width = 65;
            dataGridView.Columns[10].Width = 50;
            dataGridView.Columns[11].Width = 75;
            dataGridView.Columns[12].Width = 60;
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
                            database1DataSetWB.Waybills.Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(database1DataSetWB, table);
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView.Rows.Count - 2;
                        DataRow row = database1DataSetWB.Waybills.NewRow();

                        int time = int.Parse(dataGridView.Rows[rowIndex].Cells["WorkTime"].Value.ToString());
                        int tariff = int.Parse(dataGridView.Rows[rowIndex].Cells["Tariff"].Value.ToString());

                        row["Date"] = dataGridView.Rows[rowIndex].Cells["Date"].Value;
                        row["Crane_ID"] = dataGridView.Rows[rowIndex].Cells["Crane_ID"].Value;
                        row["Driver_ID"] = dataGridView.Rows[rowIndex].Cells["Driver_ID"].Value;
                        row["WorkTime"] = dataGridView.Rows[rowIndex].Cells["WorkTime"].Value;
                        row["Customer_ID"] = dataGridView.Rows[rowIndex].Cells["Customer_ID"].Value;
                        row["WorkObject_ID"] = dataGridView.Rows[rowIndex].Cells["WorkObject_ID"].Value;
                        row["Address"] = dataGridView.Rows[rowIndex].Cells["Address"].Value;
                        row["Tariff"] = dataGridView.Rows[rowIndex].Cells["Tariff"].Value;
                        row["Payment"] = time * tariff;
                        row["Refill"] = dataGridView.Rows[rowIndex].Cells["Refill"].Value;
                        row["RefillPrice"] = dataGridView.Rows[rowIndex].Cells["RefillPrice"].Value;


                        database1DataSetWB.Waybills.Rows.Add(row);
                        database1DataSetWB.Waybills.Rows.RemoveAt(database1DataSetWB.Tables[table].Rows.Count - 1);
                        dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2);
                        dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value = "Delete";

                        sqlDataAdapter.Update(database1DataSetWB, table);
                        newRow = false;
                    }
                    else if (task == "Update")
                    {
                        if (MessageBox.Show("Применить изменения?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int index = e.RowIndex;
                            int dbIndex = -1;
                            for (int i = 0; i < database1DataSetWB.Waybills.Count; i++)
                            {
                                if (int.Parse(dataGridView.Rows[index].Cells["Id"].Value.ToString()) == database1DataSetWB.Waybills[i].Id)
                                {
                                    dbIndex = i;
                                    break;
                                }
                            }


                            int time = int.Parse(dataGridView.Rows[index].Cells["WorkTime"].Value.ToString());
                            int tariff = int.Parse(dataGridView.Rows[index].Cells["Tariff"].Value.ToString());

                            database1DataSetWB.Waybills.Rows[dbIndex]["Date"] = dataGridView.Rows[index].Cells["Date"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Crane_ID"] = dataGridView.Rows[index].Cells["Crane_ID"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Driver_ID"] = dataGridView.Rows[index].Cells["Driver_ID"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["WorkTime"] = dataGridView.Rows[index].Cells["WorkTime"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Customer_ID"] = dataGridView.Rows[index].Cells["Customer_ID"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["WorkObject_ID"] = dataGridView.Rows[index].Cells["WorkObject_ID"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Address"] = dataGridView.Rows[index].Cells["Address"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Tariff"] = dataGridView.Rows[index].Cells["Tariff"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Payment"] = time * tariff;
                            database1DataSetWB.Waybills.Rows[dbIndex]["Refill"] = dataGridView.Rows[index].Cells["Refill"].Value;
                            database1DataSetWB.Waybills.Rows[dbIndex]["RefillPrice"] = dataGridView.Rows[index].Cells["RefillPrice"].Value;

                            sqlDataAdapter.Update(database1DataSetWB, table);
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
                if (!newRow && generated && e.ColumnIndex != 12)
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
            if (dataGridView.CurrentCell.ColumnIndex == 4 || dataGridView.CurrentCell.ColumnIndex == 8 || dataGridView.CurrentCell.ColumnIndex == 10 || dataGridView.CurrentCell.ColumnIndex == 11)
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
