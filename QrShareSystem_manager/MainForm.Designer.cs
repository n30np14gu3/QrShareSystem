
namespace QrShareSystem_manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TResolution = new System.Windows.Forms.RichTextBox();
            this.TTopic = new System.Windows.Forms.TextBox();
            this.TAddress = new System.Windows.Forms.TextBox();
            this.TManagerName = new System.Windows.Forms.TextBox();
            this.TApplicantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.TConent = new System.Windows.Forms.RichTextBox();
            this.TComment = new System.Windows.Forms.RichTextBox();
            this.CStatus = new System.Windows.Forms.ComboBox();
            this.QrScan = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.BFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.BCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.BSave = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ExportFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrScan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.8962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.1038F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.QrScan, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1081, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.2127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.7873F));
            this.tableLayoutPanel2.Controls.Add(this.TResolution, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.TTopic, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TAddress, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TManagerName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TApplicantName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TConent, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TComment, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.CStatus, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(401, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(677, 546);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TResolution
            // 
            this.TResolution.Location = new System.Drawing.Point(195, 238);
            this.TResolution.Name = "TResolution";
            this.TResolution.Size = new System.Drawing.Size(473, 91);
            this.TResolution.TabIndex = 15;
            this.TResolution.Text = "";
            // 
            // TTopic
            // 
            this.TTopic.Location = new System.Drawing.Point(195, 121);
            this.TTopic.Name = "TTopic";
            this.TTopic.ReadOnly = true;
            this.TTopic.Size = new System.Drawing.Size(473, 26);
            this.TTopic.TabIndex = 13;
            // 
            // TAddress
            // 
            this.TAddress.Location = new System.Drawing.Point(195, 89);
            this.TAddress.Name = "TAddress";
            this.TAddress.ReadOnly = true;
            this.TAddress.Size = new System.Drawing.Size(473, 26);
            this.TAddress.TabIndex = 12;
            // 
            // TManagerName
            // 
            this.TManagerName.Location = new System.Drawing.Point(195, 60);
            this.TManagerName.Name = "TManagerName";
            this.TManagerName.ReadOnly = true;
            this.TManagerName.Size = new System.Drawing.Size(473, 26);
            this.TManagerName.TabIndex = 11;
            // 
            // TApplicantName
            // 
            this.TApplicantName.Location = new System.Drawing.Point(195, 31);
            this.TApplicantName.Name = "TApplicantName";
            this.TApplicantName.ReadOnly = true;
            this.TApplicantName.Size = new System.Drawing.Size(473, 26);
            this.TApplicantName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО руководителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тематика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Содержание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Резолюция";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Статус обращения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Примечание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО Заявителя";
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(195, 4);
            this.TId.Name = "TId";
            this.TId.ReadOnly = true;
            this.TId.Size = new System.Drawing.Size(473, 26);
            this.TId.TabIndex = 9;
            // 
            // TConent
            // 
            this.TConent.Location = new System.Drawing.Point(195, 150);
            this.TConent.Name = "TConent";
            this.TConent.ReadOnly = true;
            this.TConent.Size = new System.Drawing.Size(473, 81);
            this.TConent.TabIndex = 14;
            this.TConent.Text = "";
            // 
            // TComment
            // 
            this.TComment.Location = new System.Drawing.Point(195, 373);
            this.TComment.Name = "TComment";
            this.TComment.Size = new System.Drawing.Size(473, 164);
            this.TComment.TabIndex = 16;
            this.TComment.Text = "";
            // 
            // CStatus
            // 
            this.CStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CStatus.FormattingEnabled = true;
            this.CStatus.Items.AddRange(new object[] {
            "Создано",
            "Рассмотрено",
            "Отклонено"});
            this.CStatus.Location = new System.Drawing.Point(195, 336);
            this.CStatus.Name = "CStatus";
            this.CStatus.Size = new System.Drawing.Size(473, 28);
            this.CStatus.TabIndex = 17;
            // 
            // QrScan
            // 
            this.QrScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QrScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QrScan.Location = new System.Drawing.Point(3, 3);
            this.QrScan.Name = "QrScan";
            this.QrScan.Size = new System.Drawing.Size(392, 546);
            this.QrScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrScan.TabIndex = 1;
            this.QrScan.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзображениеToolStripMenuItem,
            this.BCopy,
            this.BSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьИзображениеToolStripMenuItem
            // 
            this.загрузитьИзображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BFromClipboard,
            this.BFromFile});
            this.загрузитьИзображениеToolStripMenuItem.Name = "загрузитьИзображениеToolStripMenuItem";
            this.загрузитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.загрузитьИзображениеToolStripMenuItem.Text = "Загрузить изображение";
            // 
            // BFromClipboard
            // 
            this.BFromClipboard.Name = "BFromClipboard";
            this.BFromClipboard.Size = new System.Drawing.Size(177, 22);
            this.BFromClipboard.Text = "Из буфера обмена";
            this.BFromClipboard.Click += new System.EventHandler(this.BFromClipboard_Click);
            // 
            // BFromFile
            // 
            this.BFromFile.Name = "BFromFile";
            this.BFromFile.Size = new System.Drawing.Size(177, 22);
            this.BFromFile.Text = "Из файла";
            this.BFromFile.Click += new System.EventHandler(this.BFromFile_Click);
            // 
            // BCopy
            // 
            this.BCopy.Name = "BCopy";
            this.BCopy.Size = new System.Drawing.Size(204, 20);
            this.BCopy.Text = "Распечатать новую информацию";
            this.BCopy.Click += new System.EventHandler(this.BCopy_Click);
            // 
            // BSave
            // 
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(206, 20);
            this.BSave.Text = "Сохранить готовую информацию";
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Png Files|*.png|JPEG Files|*.jpg|Bmp Files|*.bmp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QR Share System :: MANAGER";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrScan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox TResolution;
        private System.Windows.Forms.TextBox TTopic;
        private System.Windows.Forms.TextBox TAddress;
        private System.Windows.Forms.TextBox TManagerName;
        private System.Windows.Forms.TextBox TApplicantName;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.RichTextBox TConent;
        private System.Windows.Forms.RichTextBox TComment;
        private System.Windows.Forms.PictureBox QrScan;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BCopy;
        private System.Windows.Forms.ComboBox CStatus;
        private System.Windows.Forms.ToolStripMenuItem BSave;
        private System.Windows.Forms.ToolStripMenuItem BFromClipboard;
        private System.Windows.Forms.ToolStripMenuItem BFromFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.FolderBrowserDialog ExportFolderDialog;
    }
}

