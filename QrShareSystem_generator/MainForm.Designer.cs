
namespace QrShareSystem_generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.TRequestFIO = new System.Windows.Forms.TextBox();
            this.TLeadFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TAddress = new System.Windows.Forms.TextBox();
            this.TTopic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TContent = new System.Windows.Forms.RichTextBox();
            this.BCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО заявителя:";
            // 
            // TRequestFIO
            // 
            this.TRequestFIO.Location = new System.Drawing.Point(15, 25);
            this.TRequestFIO.Name = "TRequestFIO";
            this.TRequestFIO.Size = new System.Drawing.Size(412, 20);
            this.TRequestFIO.TabIndex = 1;
            // 
            // TLeadFIO
            // 
            this.TLeadFIO.Location = new System.Drawing.Point(15, 75);
            this.TLeadFIO.Name = "TLeadFIO";
            this.TLeadFIO.Size = new System.Drawing.Size(412, 20);
            this.TLeadFIO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО руководителя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес:";
            // 
            // TAddress
            // 
            this.TAddress.Location = new System.Drawing.Point(15, 127);
            this.TAddress.Name = "TAddress";
            this.TAddress.Size = new System.Drawing.Size(412, 20);
            this.TAddress.TabIndex = 5;
            // 
            // TTopic
            // 
            this.TTopic.Location = new System.Drawing.Point(15, 184);
            this.TTopic.Name = "TTopic";
            this.TTopic.Size = new System.Drawing.Size(412, 20);
            this.TTopic.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тематика:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Содержание:";
            // 
            // TContent
            // 
            this.TContent.Location = new System.Drawing.Point(12, 246);
            this.TContent.Name = "TContent";
            this.TContent.Size = new System.Drawing.Size(415, 96);
            this.TContent.TabIndex = 11;
            this.TContent.Text = "";
            // 
            // BCreateButton
            // 
            this.BCreateButton.Location = new System.Drawing.Point(12, 348);
            this.BCreateButton.Name = "BCreateButton";
            this.BCreateButton.Size = new System.Drawing.Size(417, 37);
            this.BCreateButton.TabIndex = 12;
            this.BCreateButton.Text = "Создать обращение";
            this.BCreateButton.UseVisualStyleBackColor = true;
            this.BCreateButton.Click += new System.EventHandler(this.BCreateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 398);
            this.Controls.Add(this.BCreateButton);
            this.Controls.Add(this.TContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TTopic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TLeadFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TRequestFIO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QR Share System :: GENERATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TRequestFIO;
        private System.Windows.Forms.TextBox TLeadFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TAddress;
        private System.Windows.Forms.TextBox TTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TContent;
        private System.Windows.Forms.Button BCreateButton;
    }
}

