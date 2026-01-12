namespace MagyarorszagNevezetessegek
{
    partial class MagyarorszagNevezetessegekForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nevLabel = new System.Windows.Forms.Label();
            this.leirasLabel = new System.Windows.Forms.Label();
            this.helyszinLabel = new System.Windows.Forms.Label();
            this.turizmus_tipusLabel = new System.Windows.Forms.Label();
            this.nevValueLabel = new System.Windows.Forms.Label();
            this.leirasValueLabel = new System.Windows.Forms.Label();
            this.helyszinValueLabel = new System.Windows.Forms.Label();
            this.turizmus_tipusValueLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(372, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Magyarországi Nevezetességek";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(663, 91);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(978, 90);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(210, 21);
            this.filterComboBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 407);
            this.listBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(888, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nevLabel.Location = new System.Drawing.Point(356, 367);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(120, 15);
            this.nevLabel.TabIndex = 5;
            this.nevLabel.Text = "Nevezetesség neve:";
            // 
            // leirasLabel
            // 
            this.leirasLabel.AutoSize = true;
            this.leirasLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leirasLabel.Location = new System.Drawing.Point(356, 420);
            this.leirasLabel.Name = "leirasLabel";
            this.leirasLabel.Size = new System.Drawing.Size(42, 15);
            this.leirasLabel.TabIndex = 5;
            this.leirasLabel.Text = "Leírás:";
            // 
            // helyszinLabel
            // 
            this.helyszinLabel.AutoSize = true;
            this.helyszinLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helyszinLabel.Location = new System.Drawing.Point(356, 471);
            this.helyszinLabel.Name = "helyszinLabel";
            this.helyszinLabel.Size = new System.Drawing.Size(56, 15);
            this.helyszinLabel.TabIndex = 5;
            this.helyszinLabel.Text = "Helyszín:";
            // 
            // turizmus_tipusLabel
            // 
            this.turizmus_tipusLabel.AutoSize = true;
            this.turizmus_tipusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turizmus_tipusLabel.Location = new System.Drawing.Point(356, 522);
            this.turizmus_tipusLabel.Name = "turizmus_tipusLabel";
            this.turizmus_tipusLabel.Size = new System.Drawing.Size(90, 15);
            this.turizmus_tipusLabel.TabIndex = 5;
            this.turizmus_tipusLabel.Text = "Turizmus típus:";
            // 
            // nevValueLabel
            // 
            this.nevValueLabel.AutoSize = true;
            this.nevValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevValueLabel.Location = new System.Drawing.Point(534, 367);
            this.nevValueLabel.Name = "nevValueLabel";
            this.nevValueLabel.Size = new System.Drawing.Size(12, 15);
            this.nevValueLabel.TabIndex = 6;
            this.nevValueLabel.Text = "-";
            // 
            // leirasValueLabel
            // 
            this.leirasValueLabel.AutoSize = true;
            this.leirasValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leirasValueLabel.Location = new System.Drawing.Point(534, 420);
            this.leirasValueLabel.Name = "leirasValueLabel";
            this.leirasValueLabel.Size = new System.Drawing.Size(12, 15);
            this.leirasValueLabel.TabIndex = 6;
            this.leirasValueLabel.Text = "-";
            // 
            // helyszinValueLabel
            // 
            this.helyszinValueLabel.AutoSize = true;
            this.helyszinValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helyszinValueLabel.Location = new System.Drawing.Point(534, 471);
            this.helyszinValueLabel.Name = "helyszinValueLabel";
            this.helyszinValueLabel.Size = new System.Drawing.Size(12, 15);
            this.helyszinValueLabel.TabIndex = 6;
            this.helyszinValueLabel.Text = "-";
            // 
            // turizmus_tipusValueLabel
            // 
            this.turizmus_tipusValueLabel.AutoSize = true;
            this.turizmus_tipusValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.turizmus_tipusValueLabel.Location = new System.Drawing.Point(534, 522);
            this.turizmus_tipusValueLabel.Name = "turizmus_tipusValueLabel";
            this.turizmus_tipusValueLabel.Size = new System.Drawing.Size(12, 15);
            this.turizmus_tipusValueLabel.TabIndex = 6;
            this.turizmus_tipusValueLabel.Text = "-";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(988, 548);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 40);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Kilépés";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // MagyarorszagNevezetessegekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.turizmus_tipusValueLabel);
            this.Controls.Add(this.helyszinValueLabel);
            this.Controls.Add(this.leirasValueLabel);
            this.Controls.Add(this.nevValueLabel);
            this.Controls.Add(this.turizmus_tipusLabel);
            this.Controls.Add(this.helyszinLabel);
            this.Controls.Add(this.leirasLabel);
            this.Controls.Add(this.nevLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.headerPanel);
            this.Name = "MagyarorszagNevezetessegekForm";
            this.Text = "Magyarország Nevezetességek";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label leirasLabel;
        private System.Windows.Forms.Label helyszinLabel;
        private System.Windows.Forms.Label turizmus_tipusLabel;
        private System.Windows.Forms.Label nevValueLabel;
        private System.Windows.Forms.Label leirasValueLabel;
        private System.Windows.Forms.Label helyszinValueLabel;
        private System.Windows.Forms.Label turizmus_tipusValueLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

