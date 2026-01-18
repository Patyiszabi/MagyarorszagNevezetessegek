using System.Drawing;
using System.Windows.Forms;

namespace MagyarorszagNevezetessegek
{
    partial class MagyarorszagNevezetessegekForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;

        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label nevValueLabel;

        private System.Windows.Forms.Label helyszinLabel;
        private System.Windows.Forms.Label helyszinValueLabel;

        private System.Windows.Forms.Label turizmusTipusLabel;
        private System.Windows.Forms.Label turizmus_tipusValueLabel;

        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button exitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nevLabel = new System.Windows.Forms.Label();
            this.nevValueLabel = new System.Windows.Forms.Label();
            this.helyszinLabel = new System.Windows.Forms.Label();
            this.helyszinValueLabel = new System.Windows.Forms.Label();
            this.turizmusTipusLabel = new System.Windows.Forms.Label();
            this.turizmus_tipusValueLabel = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.leirasPreviewTextBox = new System.Windows.Forms.TextBox();
            this.leirasPreviewLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(857, 61);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(17, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(329, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Magyarország Nevezetességei";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(497, 75);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 17);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Keresés:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(562, 72);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(283, 25);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(497, 102);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(67, 17);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Rendezés:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(562, 99);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(283, 25);
            this.filterComboBox.TabIndex = 4;
            this.filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(17, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(463, 410);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(501, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nevLabel.Location = new System.Drawing.Point(497, 331);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(40, 19);
            this.nevLabel.TabIndex = 7;
            this.nevLabel.Text = "Név:";
            // 
            // nevValueLabel
            // 
            this.nevValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nevValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nevValueLabel.Location = new System.Drawing.Point(562, 331);
            this.nevValueLabel.Name = "nevValueLabel";
            this.nevValueLabel.Size = new System.Drawing.Size(283, 35);
            this.nevValueLabel.TabIndex = 8;
            this.nevValueLabel.Text = "-";
            // 
            // helyszinLabel
            // 
            this.helyszinLabel.AutoSize = true;
            this.helyszinLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helyszinLabel.Location = new System.Drawing.Point(497, 369);
            this.helyszinLabel.Name = "helyszinLabel";
            this.helyszinLabel.Size = new System.Drawing.Size(69, 19);
            this.helyszinLabel.TabIndex = 9;
            this.helyszinLabel.Text = "Helyszín:";
            // 
            // helyszinValueLabel
            // 
            this.helyszinValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.helyszinValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.helyszinValueLabel.Location = new System.Drawing.Point(562, 369);
            this.helyszinValueLabel.Name = "helyszinValueLabel";
            this.helyszinValueLabel.Size = new System.Drawing.Size(283, 35);
            this.helyszinValueLabel.TabIndex = 10;
            this.helyszinValueLabel.Text = "-";
            // 
            // turizmusTipusLabel
            // 
            this.turizmusTipusLabel.AutoSize = true;
            this.turizmusTipusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.turizmusTipusLabel.Location = new System.Drawing.Point(497, 407);
            this.turizmusTipusLabel.Name = "turizmusTipusLabel";
            this.turizmusTipusLabel.Size = new System.Drawing.Size(116, 19);
            this.turizmusTipusLabel.TabIndex = 11;
            this.turizmusTipusLabel.Text = "Turizmus típusa:";
            // 
            // turizmus_tipusValueLabel
            // 
            this.turizmus_tipusValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.turizmus_tipusValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.turizmus_tipusValueLabel.Location = new System.Drawing.Point(611, 407);
            this.turizmus_tipusValueLabel.Name = "turizmus_tipusValueLabel";
            this.turizmus_tipusValueLabel.Size = new System.Drawing.Size(234, 22);
            this.turizmus_tipusValueLabel.TabIndex = 12;
            this.turizmus_tipusValueLabel.Text = "-";
            // 
            // detailsButton
            // 
            this.detailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.detailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailsButton.FlatAppearance.BorderSize = 0;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.detailsButton.ForeColor = System.Drawing.Color.White;
            this.detailsButton.Location = new System.Drawing.Point(501, 490);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(163, 30);
            this.detailsButton.TabIndex = 15;
            this.detailsButton.Text = "További részletek";
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Click += detailsButton_Click;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(672, 490);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 30);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Kilépés";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += exitButton_Click;
            // 
            // leirasPreviewTextBox
            // 
            this.leirasPreviewTextBox.BackColor = System.Drawing.Color.White;
            this.leirasPreviewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leirasPreviewTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leirasPreviewTextBox.Location = new System.Drawing.Point(501, 457);
            this.leirasPreviewTextBox.Multiline = true;
            this.leirasPreviewTextBox.Name = "leirasPreviewTextBox";
            this.leirasPreviewTextBox.ReadOnly = true;
            this.leirasPreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.leirasPreviewTextBox.Size = new System.Drawing.Size(335, 20);
            this.leirasPreviewTextBox.TabIndex = 14;
            // 
            // leirasPreviewLabel
            // 
            this.leirasPreviewLabel.AutoSize = true;
            this.leirasPreviewLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.leirasPreviewLabel.Location = new System.Drawing.Point(497, 438);
            this.leirasPreviewLabel.Name = "leirasPreviewLabel";
            this.leirasPreviewLabel.Size = new System.Drawing.Size(92, 19);
            this.leirasPreviewLabel.TabIndex = 13;
            this.leirasPreviewLabel.Text = "Rövid leírás:";
            // 
            // MagyarorszagNevezetessegekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.leirasPreviewTextBox);
            this.Controls.Add(this.leirasPreviewLabel);
            this.Controls.Add(this.turizmus_tipusValueLabel);
            this.Controls.Add(this.turizmusTipusLabel);
            this.Controls.Add(this.helyszinValueLabel);
            this.Controls.Add(this.helyszinLabel);
            this.Controls.Add(this.nevValueLabel);
            this.Controls.Add(this.nevLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MagyarorszagNevezetessegekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magyarország Nevezetességei";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox leirasPreviewTextBox;
        private Label leirasPreviewLabel;
    }
}
