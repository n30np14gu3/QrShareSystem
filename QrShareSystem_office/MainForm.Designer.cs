
namespace QrShareSystem_office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RequestsData = new System.Windows.Forms.DataGridView();
            this.BExportButton = new System.Windows.Forms.Button();
            this.ExportFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsData)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestsData
            // 
            this.RequestsData.AllowUserToAddRows = false;
            this.RequestsData.AllowUserToDeleteRows = false;
            this.RequestsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsData.Location = new System.Drawing.Point(2, 2);
            this.RequestsData.Name = "RequestsData";
            this.RequestsData.ReadOnly = true;
            this.RequestsData.Size = new System.Drawing.Size(950, 455);
            this.RequestsData.TabIndex = 0;
            // 
            // BExportButton
            // 
            this.BExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BExportButton.Location = new System.Drawing.Point(2, 463);
            this.BExportButton.Name = "BExportButton";
            this.BExportButton.Size = new System.Drawing.Size(950, 38);
            this.BExportButton.TabIndex = 2;
            this.BExportButton.Text = "Экспортировать в DOCX";
            this.BExportButton.UseVisualStyleBackColor = true;
            this.BExportButton.Click += new System.EventHandler(this.BExportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.BExportButton);
            this.Controls.Add(this.RequestsData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "QR Share System :: OFFICE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RequestsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RequestsData;
        private System.Windows.Forms.Button BExportButton;
        private System.Windows.Forms.FolderBrowserDialog ExportFolderDialog;
    }
}

