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
    public partial class CranesForm : Form
    {
        private const string table = "Cranes"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private bool newRow = false;
        public CranesForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [DELETE] FROM Cranes", sqlConnection);
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

        private void CranesForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();
            LoadData();
            dataGridView.Columns[0].Width = 25;
            dataGridView.Columns[1].Width = 75;
            dataGridView.Columns[1].HeaderText = "Гос.Номер";
            dataGridView.Columns[2].Width = 200;
            dataGridView.Columns[2].HeaderText = "Название";
            dataGridView.Columns[3].Width = 150;
            dataGridView.Columns[3].HeaderText = "Тип";
            dataGridView.Columns[4].Width = 150;
            dataGridView.Columns[4].HeaderText = "Комментарий";
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

                        row["Number"] = dataGridView.Rows[rowIndex].Cells["Number"].Value;
                        row["Naming"] = dataGridView.Rows[rowIndex].Cells["Naming"].Value;
                        row["Type"] = dataGridView.Rows[rowIndex].Cells["Type"].Value;
                        row["Comment"] = dataGridView.Rows[rowIndex].Cells["Comment"].Value;

                        dataSet.Tables[table].Rows.Add(row);
                        dataSet.Tables[table].Rows.RemoveAt(dataSet.Tables[table].Rows.Count - 1);
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
                            dataSet.Tables[table].Rows[index]["Number"] = dataGridView.Rows[index].Cells["Number"].Value;
                            dataSet.Tables[table].Rows[index]["Naming"] = dataGridView.Rows[index].Cells["Naming"].Value;
                            dataSet.Tables[table].Rows[index]["Type"] = dataGridView.Rows[index].Cells["Type"].Value;
                            dataSet.Tables[table].Rows[index]["Comment"] = dataGridView.Rows[index].Cells["Comment"].Value;

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
    }
}
