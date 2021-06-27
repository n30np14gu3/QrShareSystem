using System;
using System.Data;
using System.Data.SqlClient;

using System.IO;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace QrShareSystem_generator
{
    public partial class MainForm : Form
    {
        private MySqlConnection _connection;
        public MainForm()
        {
            InitializeComponent();
            _connection = new MySqlConnection();
        }

        private void BCreateButton_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrWhiteSpace(TRequestFIO.Text) || 
                string.IsNullOrWhiteSpace(TLeadFIO.Text) || 
                string.IsNullOrWhiteSpace(TAddress.Text) || 
                string.IsNullOrWhiteSpace(TTopic.Text) ||
                string.IsNullOrWhiteSpace(TContent.Text))
                return;


            using (MySqlCommand cmd = _connection.CreateCommand())
            {
                cmd.CommandText =
                    "INSERT INTO requests  (ApplicantName, ManagerName, Address, Topic, Content) VALUES (@param1, @param2, @param3, @param4, @param5);";
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = TRequestFIO.Text;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = TLeadFIO.Text;
                cmd.Parameters.Add("@param3", MySqlDbType.Text).Value = TAddress.Text;
                cmd.Parameters.Add("@param4", MySqlDbType.Text).Value = TTopic.Text;
                cmd.Parameters.Add("@param5", MySqlDbType.Text).Value = TContent.Text;
                cmd.CommandType = CommandType.Text;

                try
                {
                    cmd.ExecuteReader();
                    MessageBox.Show("Данные успешно добавлены", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    TRequestFIO.Text = TLeadFIO.Text = TAddress.Text = TTopic.Text = TContent.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка добавления в БД!\nОшибка: {ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _connection.ConnectionString = "server=localhost;" +
                                           "database=qr_db_1;" +
                                           "user=root;" +
                                           "password=;" + 
                                           "CharSet=utf8";
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                BCreateButton.Enabled = false;
                MessageBox.Show($"Can't connect to DB!\nError: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
