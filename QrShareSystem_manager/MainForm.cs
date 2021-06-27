using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

using Word = Microsoft.Office.Interop.Word;


namespace QrShareSystem_manager
{
    public partial class MainForm : Form
    {
        private Word.Application _application;

        public MainForm()
        {
            InitializeComponent();
            _application = new Word.Application();
        }

        private void BFromClipboard_Click(object sender, EventArgs e)
        {
            QrScan.Image = Clipboard.GetImage();
            if(QrScan.Image != null) 
                LoadQr();

        }

        private void LoadQr()
        {
            IBarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)QrScan.Image);
            if (result == null)
            {
                MessageBox.Show("Не удалось распознать QR код!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string s2parse = Encoding.UTF8.GetString(Convert.FromBase64String(result.Text));
            string[] parts = s2parse.Split(',');
            Dictionary<string, string> data = parts.ToDictionary(x => x.Split(':')[0], x => x.Split(':')[1]);
            TId.Text = data["ID"];
            TApplicantName.Text = data["ApplicantName"];
            TManagerName.Text = data["ManagerName"];
            TAddress.Text = data["Address"];
            TTopic.Text = data["Topic"];
            TConent.Text = data["Content"];
            CStatus.SelectedIndex = 0;

        }

        private void BFromFile_Click(object sender, EventArgs e)
        {
            OpenFile.FileName = "";
            if(OpenFile.ShowDialog() != DialogResult.OK)
                return;

            QrScan.Image = Image.FromFile(OpenFile.FileName);
            if(QrScan.Image != null)
                LoadQr();
        }

        private void BCopy_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TResolution.Text) || CStatus.SelectedIndex == 0 || string.IsNullOrWhiteSpace(TId.Text))
                return;

            if (ExportFolderDialog.ShowDialog() != DialogResult.OK)
                return;

            string savePath = ExportFolderDialog.SelectedPath;

            string export_str =
                $"ID:{TId.Text}," +
                $"Resolution:{TResolution.Text}," +
                $"Status:{CStatus.SelectedIndex}";

            if (!string.IsNullOrWhiteSpace(TComment.Text))
                export_str += $",Comment:{TComment.Text}";

            Word.Document doc = _application.Documents.Add();

            Word.Paragraph paragraph = doc.Paragraphs.Add();
            Word.Range tableRange = paragraph.Range;
            Word.Table table = doc.Tables.Add(tableRange, 10, 2);

            Word.Range cellRange;
            cellRange = table.Cell(1, 1).Range;
            cellRange.Text = "ID";
            cellRange.Bold = 1;

            cellRange = table.Cell(2, 1).Range;
            cellRange.Text = "ФИО заявителя";
            cellRange.Bold = 1;

            cellRange = table.Cell(4, 1).Range;
            cellRange.Text = "ФИО руководителя";
            cellRange.Bold = 1;

            cellRange = table.Cell(4, 1).Range;
            cellRange.Text = "ФИО руководителя";
            cellRange.Bold = 1;

            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle;

            doc.SaveAs($"{savePath}\\USER_{TId.Text}_completed.docx");
            doc.Close();

        }
    }
}
