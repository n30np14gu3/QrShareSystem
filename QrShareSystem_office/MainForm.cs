using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using QRCoder;
using QrShareSystem.Core;

using Word = Microsoft.Office.Interop.Word; 

namespace QrShareSystem_office
{
    public partial class MainForm : Form
    {
        private MySqlConnection _connection;
        private DataTable _table = new DataTable("requests");
        private Word.Application _application;
        private QRCodeGenerator _generator;
        public MainForm()
        {
            InitializeComponent();
            _connection = new MySqlConnection();
            _generator = new QRCodeGenerator();
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
                _table.Columns.Clear();
                _table.Rows.Clear();
                _table.Clear();

                _table.Columns.Add(new DataColumn("ID"));
                _table.Columns.Add(new DataColumn("ФИО Заявителя"));
                _table.Columns.Add(new DataColumn("ФИО руководителя"));
                _table.Columns.Add(new DataColumn("Адрес"));
                _table.Columns.Add(new DataColumn("Тематика"));
                _table.Columns.Add(new DataColumn("Содержание"));
                _table.Columns.Add(new DataColumn("Резолюция"));
                _table.Columns.Add(new DataColumn("Статус обращения"));
                _table.Columns.Add(new DataColumn("Примечание"));



                using (MySqlCommand cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM requests WHERE Status=0"; //Ток те, которые не рассмотрены
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = _table.NewRow();
                            for (int i = 0; i < 9; i++)
                                row[i] = reader[i].ToString();

                            row[7] = ((ResolutionStatus) int.Parse(reader[7].ToString())).ToString();
                            _table.Rows.Add(row);
                        }
                    }
                }

                RequestsData.DataSource = _table;
                RequestsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                RequestsData.AutoSize = true;
                Width = 0;
                for (int i = 0; i < RequestsData.Columns.Count; i++)
                    Width += RequestsData.Columns[i].Width;
            }
            catch (Exception ex)
            {
                BExportButton.Enabled = false;
                MessageBox.Show($"Can't connect to DB!\nError: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            _application = new Word.Application();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        private void BExportButton_Click(object sender, EventArgs e)
        {
            if (RequestsData.SelectedRows.Count == 0)
                return;

            if (ExportFolderDialog.ShowDialog() != DialogResult.OK)
                return;

            string savePath = ExportFolderDialog.SelectedPath;
            foreach (DataGridViewRow row in RequestsData.SelectedRows)
            {

                string export_str = 
                    $"ID:{row.Cells[0].Value}," +
                    $"ApplicantName:{row.Cells[1].Value}," +
                    $"ManagerName:{row.Cells[2].Value}," +
                    $"Address:{row.Cells[3].Value}," +
                    $"Topic:{row.Cells[4].Value}," +
                    $"Content:{row.Cells[5].Value}";
                Word.Document doc = _application.Documents.Add();

                Word.Paragraph paragraph = doc.Paragraphs.Add();
                Word.Range tableRange = paragraph.Range;
                Word.Table table = doc.Tables.Add(tableRange, _table.Columns.Count + 1, 2);

                for (int i = 0; i < _table.Columns.Count; i++)
                {
                    Word.Range cellRange;
                    cellRange = table.Cell(i + 1, 1).Range;
                    cellRange.Text = _table.Columns[i].ColumnName;
                    cellRange.Bold = 1;
                }

                Word.Range qrRange;
                qrRange = table.Cell(_table.Columns.Count + 1, 1).Range;
                qrRange.Bold = 1;
                qrRange.Text = "QR";

                qrRange = table.Cell(_table.Columns.Count + 1, 2).Range;

                string tmpQr = $"{Path.GetTempFileName()}.png";


                QRCodeData qrData = _generator.CreateQrCode(Convert.ToBase64String(Encoding.UTF8.GetBytes(export_str)),
                    QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(qrData);
                Bitmap qrImage = code.GetGraphic(40);
                qrImage.Save(tmpQr, ImageFormat.Png);
                qrRange.InlineShapes.AddPicture(new FileInfo(tmpQr).FullName);

                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle;
                for (int i = 1; i <= _table.Columns.Count; i++)
                {
                    Word.Range cellRange;
                    cellRange = table.Cell(i, 2).Range;
                    cellRange.Text = row.Cells[i - 1].Value.ToString();
                }
                doc.SaveAs($"{savePath}\\USER_{row.Cells[0].Value}.docx");
                doc.Close();
                File.Delete(tmpQr);
            }

            MessageBox.Show("Файлы экспортированы!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BPrintRequests_Click(object sender, EventArgs e)
        {

        }
    }
}
