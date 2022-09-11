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
    public partial class DriversForm : Form
    {
        private const string table = "Drivers"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private bool newRow = false;

        public DriversForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [DELETE] FROM Drivers", sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, table);

                dataGridView.DataSource = dataSet.Tables[table];
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, i] = linkCell;
                }
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
                dataSet.Tables[table].Clear();
                sqlDataAdapter.Fill(dataSet, table);

                dataGridView.DataSource = dataSet.Tables[table];
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView[dataGridView.Columns.Count - 1, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();
            LoadData();

            dataGridView.Columns[0].Width = 25;
            dataGridView.Columns[1].Width = 250;
            dataGridView.Columns[1].HeaderText = "ФИО";
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].HeaderText = "Лицензия";
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[3].HeaderText = "Дата ОТ";
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[4].HeaderText = "Дата ДО";
            dataGridView.Columns[5].Width = 65;
            dataGridView.Columns[5].HeaderText = "Категория";
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
                            dataSet.Tables[table].Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(dataSet, table);
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView.Rows.Count - 2;
                        DataRow row = dataSet.Tables[table].NewRow();

                        row["FullName"] = dataGridView.Rows[rowIndex].Cells["FullName"].Value;
                        row["LicenseNumber"] = dataGridView.Rows[rowIndex].Cells["LicenseNumber"].Value;
                        row["DateGet"] = dataGridView.Rows[rowIndex].Cells["DateGet"].Value;
                        row["DateEnd"] = dataGridView.Rows[rowIndex].Cells["DateEnd"].Value;
                        row["Category"] = dataGridView.Rows[rowIndex].Cells["Category"].Value;

                        dataSet.Tables[table].Rows.Add(row);
                        //dataSet.Tables[table].Rows.RemoveAt(dataSet.Tables[table].Rows.Count - 1);
                        dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2);
                        dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, table);
                        newRow = false;
                    }
                    else if (task == "Update")
                    {
                        if (MessageBox.Show("Применить изменения?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int index = e.RowIndex;
                            dataSet.Tables[table].Rows[index]["FullName"] = dataGridView.Rows[index].Cells["FullName"].Value;
                            dataSet.Tables[table].Rows[index]["LicenseNumber"] = dataGridView.Rows[index].Cells["LicenseNumber"].Value;
                            dataSet.Tables[table].Rows[index]["DateGet"] = dataGridView.Rows[index].Cells["DateGet"].Value;
                            dataSet.Tables[table].Rows[index]["DateEnd"] = dataGridView.Rows[index].Cells["DateEnd"].Value;
                            dataSet.Tables[table].Rows[index]["Category"] = dataGridView.Rows[index].Cells["Category"].Value;

                            sqlDataAdapter.Update(dataSet, table);
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
                if (newRow == false)
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
            if (dataGridView.CurrentCell.ColumnIndex == 2)
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
