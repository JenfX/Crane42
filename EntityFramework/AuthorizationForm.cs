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
using System.Security.Cryptography;

namespace EntityFramework
{
    public partial class AuthorizationForm : Form
    {
        private const string table = "AuthData"; //НЕ ЗАБЫВАТЬ ПРОВЕРЯТЬ НАЗВАНИЯ!!!
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        static Timer timer = new Timer();

        public AuthorizationForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(MyData.connectionString);
            sqlConnection.Open();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            password = Convert.ToBase64String(hash);
            int level = -1;

            try
            {
                string query = "SELECT * FROM AuthData WHERE Login = '" + login + "' AND Password = '" + password + "'";
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, table);

                if (dataSet.Tables[table].Rows.Count == 1)
                {
                    level = int.Parse(dataSet.Tables[table].Rows[0]["Level"].ToString());
                    MainForm.level = level;
                    this.Close();
                }
                else
                {
                    labelError.Visible = true;
                    timer.Interval = (3 * 1000);
                    timer.Tick += new EventHandler(MyTimer);
                    timer.Start();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void MyTimer(Object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
    }
}
