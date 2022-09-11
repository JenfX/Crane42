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
using Microsoft.Office.Interop.Excel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace EntityFramework
{
    public partial class ReportServiceForm : Form
    {
        private const string table = "Waybills"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private Microsoft.Office.Interop.Excel.Application ExcelApp = null;

        public ReportServiceForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT Date as Дата, Cranes.Number as Кран, Drivers.FullName as Водитель, " +
                "Customers.Naming as Заказчик, WorkObjects.Naming as Объект, Payment as Оплата FROM Waybills\n" +
                            "JOIN Cranes ON Waybills.Crane_ID = Cranes.Id\n" +
                            "JOIN Drivers ON Waybills.Driver_ID = Drivers.Id\n" +
                            "JOIN Customers ON Waybills.Customer_ID = Customers.Id\n" +
                            "JOIN WorkObjects ON Waybills.WorkObject_ID = WorkObjects.Id\n";
            try
            {
                string start = dateTimePickerStart.Value.Year.ToString() + "-" + dateTimePickerStart.Value.Month.ToString() + "-" + dateTimePickerStart.Value.Day.ToString();
                string end = dateTimePickerEnd.Value.Year.ToString() + "-" + dateTimePickerEnd.Value.Month.ToString() + "-" + dateTimePickerEnd.Value.Day.ToString();
                query += "WHERE Date BETWEEN '" + start + "' AND '" + end + "' AND ";

                if (checkBoxDriver.Checked || checkBoxCrane.Checked || checkBoxCustomer.Checked || checkBoxObject.Checked)
                {
                    if (checkBoxDriver.Checked) query += "Driver_ID = " + comboBoxDriver.SelectedValue + " AND ";
                    if (checkBoxCrane.Checked) query += "Crane_ID = " + comboBoxCrane.SelectedValue + " AND ";
                    if (checkBoxCustomer.Checked) query += "Customer_ID = " + comboBoxCustomer.SelectedValue + " AND ";
                    if (checkBoxObject.Checked) query += "WorkObject_ID = " + comboBoxObject.SelectedValue + " AND ";
                }
                query = query.Remove(query.Length - 5);
                query += "ORDER BY Date";


                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, table);
                dgvReport.DataSource = dataSet.Tables[0];
                dgvReport.Columns[0].Width = 80;
                dgvReport.Columns[1].Width = 80;
                dgvReport.Columns[2].Width = 205;
                dgvReport.Columns[3].Width = 130;
                dgvReport.Columns[4].Width = 150;
                dgvReport.Columns[5].Width = 75;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);             

                ExcelApp.Cells[1, 1] = "Дата";
                ExcelApp.Cells[1, 2] = "Кран";
                ExcelApp.Cells[1, 3] = "Водитель";
                ExcelApp.Cells[1, 4] = "Заказчик";
                ExcelApp.Cells[1, 5] = "Объект";
                ExcelApp.Cells[1, 6] = "Оплата";

                for (int i = 0; i < dgvReport.RowCount; i++)
                {
                    if (dgvReport[0, i].Value != null)
                    {
                        string date = dgvReport[0, i].Value.ToString();
                        ExcelApp.Cells[i + 2, 1] = date.Remove(date.Length - 8);
                    }
                    for (int j = 1; j < dgvReport.ColumnCount; j++)
                    {
                        if (dgvReport[j, i].Value != null) ExcelApp.Cells[i + 2, j + 1] = dgvReport[j, i].Value.ToString();
                    }
                }

                Workbook xlWorkBook = ExcelApp.ActiveWorkbook;
                Worksheet ExcelWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);


                var Excelcells = ExcelWorkSheet.get_Range("A2", "F" + dgvReport.RowCount);
                Excelcells.Columns[1].ColumnWidth = 10;
                Excelcells.Columns[2].ColumnWidth = 9;
                Excelcells.Columns[3].ColumnWidth = 32;
                Excelcells.Columns[4].ColumnWidth = 25;
                Excelcells.Columns[5].ColumnWidth = 25;
                Excelcells.Columns[6].ColumnWidth = 10;

                Excelcells = ExcelWorkSheet.get_Range("A1", "F" + dgvReport.RowCount);
                Excelcells.HorizontalAlignment = Constants.xlCenter;

                XlBordersIndex BorderIndex;

                BorderIndex = XlBordersIndex.xlEdgeLeft;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;


                BorderIndex = XlBordersIndex.xlEdgeTop;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;


                BorderIndex = XlBordersIndex.xlEdgeBottom;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;

                BorderIndex = XlBordersIndex.xlEdgeRight;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;

                BorderIndex = XlBordersIndex.xlInsideVertical;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThin;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;

                BorderIndex = XlBordersIndex.xlInsideHorizontal;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThin;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;


                //Заголовки
                Excelcells = ExcelWorkSheet.get_Range("A1", "F1");
                BorderIndex = XlBordersIndex.xlEdgeLeft;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;


                BorderIndex = XlBordersIndex.xlEdgeTop;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;


                BorderIndex = XlBordersIndex.xlEdgeBottom;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;

                BorderIndex = XlBordersIndex.xlEdgeRight;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThick;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;

                BorderIndex = XlBordersIndex.xlInsideVertical;
                Excelcells.Borders[BorderIndex].Weight = XlBorderWeight.xlThin;
                Excelcells.Borders[BorderIndex].LineStyle = XlLineStyle.xlContinuous;
                Excelcells.Borders[BorderIndex].ColorIndex = 0;

                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxDriver.Checked = true;
        }

        private void comboBoxCrane_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxCrane.Checked = true;
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxCustomer.Checked = true;
        }

        private void comboBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxObject.Checked = true;
        }

        private void ReportServiceForm_Load(object sender, EventArgs e)
        {
            this.workObjectsTableAdapter.Fill(this.database1DataSetWB.WorkObjects);
            this.customersTableAdapter.Fill(this.database1DataSetWB.Customers);
            this.cranesTableAdapter.Fill(this.database1DataSetWB.Cranes);
            this.driversTableAdapter.Fill(this.database1DataSetWB.Drivers);

        }
    }
}
