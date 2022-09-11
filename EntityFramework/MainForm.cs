using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using System.Threading;
using Telegram.Bot.Types.ReplyMarkups;

namespace EntityFramework
{
    public partial class MainForm : Form
    {
        static ITelegramBotClient bot = new TelegramBotClient("5554564466:AAEwlBKICMBkOBCfiV3rYrqV7d9vba7v83U"); //-1001734941282
        private const string table = "Requests"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        static private SqlDataAdapter sqlDataAdapter = null;
        static private SqlDataAdapter sqlDataAdapterCranes = null;
        static private SqlDataAdapter sqlDataAdapterDrivers = null;
        static private DataSet dataSet = null;
        static private DataSet dataSetCranes = null;
        static private DataSet dataSetDrivers = null;
        static public int level = -1;

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                {
                    var message = update.Message.Text;
                    if (message.Contains("//")) // формат ответа: // Дата Кран Водитель
                    {
                        string requestText = update.Message.ReplyToMessage.Text.Replace("\n", " ");
                        string[] data = message.Split(' ');
                        string craneID = "";
                        string driverID = "";

                        foreach (DataRow crane in dataSetCranes.Tables["Cranes"].Rows)
                        {
                            if (crane["Number"].ToString().Contains(data[2]))
                            {
                                craneID = crane["Id"].ToString();
                            }
                        }

                        foreach (DataRow driver in dataSetDrivers.Tables["Drivers"].Rows)
                        {
                            if (driver["FullName"].ToString().Contains(data[3]))
                            {
                                driverID = driver["Id"].ToString();
                            }
                        }

                        DataRow row = dataSet.Tables[table].NewRow();
                        row["Date"] = data[1];
                        row["RequestText"] = requestText;
                        row["Crane_ID"] = craneID;
                        row["Driver_ID"] = driverID;

                        dataSet.Tables[table].Rows.Add(row);
                        sqlDataAdapter.Update(dataSet, table);

                        await botClient.SendTextMessageAsync(chatId: -1001734941282, text: "Заявка добавлена в БД");
                    }
                }
            }
            catch (Exception e)
            {
                string error = "Произошла ошибка!\nПроверьте формат:\n// ДД.ММ.ГГГГ Номер_крана Фамилия_Водителя";
                //await botClient.SendTextMessageAsync(chatId: -1001734941282, text: e.ToString());
                await botClient.SendTextMessageAsync(chatId: -1001734941282, text: error);
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        public MainForm()
        {
            AuthorizationForm auth = new AuthorizationForm();
            auth.ShowDialog();
            if (level == -1) Environment.Exit(0);
            InitializeComponent();

            if (level == 1)
            {
                buttonWaybills.Enabled = true;
                buttonStorehouse.Enabled = true;
                buttonDrivers.Enabled = true;
                buttonCranes.Enabled = true;
                buttonCustomers.Enabled = true;
                buttonWorkObjects.Enabled = true;
                buttonUsers.Visible = true;
            }
            else if (level == 2)
            {
                buttonWaybills.Enabled = true;
                buttonStorehouse.Enabled = true;
                buttonDrivers.Enabled = true;
                buttonCranes.Enabled = true;
                buttonCustomers.Enabled = true;
                buttonWorkObjects.Enabled = true;
            }

            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Requests", sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlCommandBuilder.GetInsertCommand();
            sqlCommandBuilder.GetUpdateCommand();
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, table);

            sqlDataAdapterCranes = new SqlDataAdapter("SELECT * FROM Cranes", sqlConnection);
            dataSetCranes = new DataSet();
            sqlDataAdapterCranes.Fill(dataSetCranes, "Cranes");

            sqlDataAdapterDrivers = new SqlDataAdapter("SELECT * FROM Drivers", sqlConnection);
            dataSetDrivers = new DataSet();
            sqlDataAdapterDrivers.Fill(dataSetDrivers, "Drivers");

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
        }


        private void buttonWaybills_Click(object sender, EventArgs e)
        {
            WaybillsForm waybillsForm = new WaybillsForm();
            waybillsForm.ShowDialog();
        }

        private void buttonDrivers_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.ShowDialog();
        }

        private void buttonCranes_Click(object sender, EventArgs e)
        {
            CranesForm cranesForm = new CranesForm();
            cranesForm.ShowDialog();
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            RequestsForm requestsForm = new RequestsForm();
            requestsForm.ShowDialog();
        }

        private void buttonStorehouse_Click(object sender, EventArgs e)
        {
            StorehouseForm storehouseForm = new StorehouseForm();
            storehouseForm.ShowDialog();
        }

        private void buttonReportDriverWorkTime_Click(object sender, EventArgs e)
        {
            ReportServiceForm reportServiceForm = new ReportServiceForm();
            reportServiceForm.ShowDialog();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void buttonWorkObjects_Click(object sender, EventArgs e)
        {
            WorkObjectsForm workObjectsForm = new WorkObjectsForm();
            workObjectsForm.ShowDialog();
        }

        void LoadRequests()
        {
            string date = (DateTime.Today.AddDays(1).ToString()).Replace(" 0:00:00", "");
            dgvRequests.Rows.Clear();
            foreach (DataRow req in dataSet.Tables[table].Rows)
            {
                if (req["Date"].ToString().Contains(date))
                {
                    dgvRequests.Rows.Add(req["RequestText"]);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }
    }
}
