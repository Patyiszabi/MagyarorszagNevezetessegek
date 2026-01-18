using System.Drawing;
using System.Windows.Forms;

namespace MagyarorszagNevezetessegek
{
    partial class NevezetessegReszletekForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label nevValueLabel;

        private System.Windows.Forms.Label helyszinLabel;
        private System.Windows.Forms.Label helyszinValueLabel;

        private System.Windows.Forms.Label turizmusLabel;
        private System.Windows.Forms.Label turizmusValueLabel;

        private System.Windows.Forms.Label leirasLabel;

        private System.Windows.Forms.Button backButton;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private RichTextBox leirasRichTextBox;

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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nevLabel = new System.Windows.Forms.Label();
            this.nevValueLabel = new System.Windows.Forms.Label();
            this.helyszinLabel = new System.Windows.Forms.Label();
            this.helyszinValueLabel = new System.Windows.Forms.Label();
            this.turizmusLabel = new System.Windows.Forms.Label();
            this.turizmusValueLabel = new System.Windows.Forms.Label();
            this.leirasLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.leirasRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.titleLabel.Size = new System.Drawing.Size(194, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "További részletek";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nevLabel.Location = new System.Drawing.Point(429, 73);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(40, 19);
            this.nevLabel.TabIndex = 2;
            this.nevLabel.Text = "Név:";
            // 
            // nevValueLabel
            // 
            this.nevValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nevValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nevValueLabel.Location = new System.Drawing.Point(480, 73);
            this.nevValueLabel.Name = "nevValueLabel";
            this.nevValueLabel.Size = new System.Drawing.Size(360, 35);
            this.nevValueLabel.TabIndex = 3;
            this.nevValueLabel.Text = "-";
            // 
            // helyszinLabel
            // 
            this.helyszinLabel.AutoSize = true;
            this.helyszinLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helyszinLabel.Location = new System.Drawing.Point(429, 113);
            this.helyszinLabel.Name = "helyszinLabel";
            this.helyszinLabel.Size = new System.Drawing.Size(69, 19);
            this.helyszinLabel.TabIndex = 4;
            this.helyszinLabel.Text = "Helyszín:";
            // 
            // helyszinValueLabel
            // 
            this.helyszinValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.helyszinValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.helyszinValueLabel.Location = new System.Drawing.Point(497, 113);
            this.helyszinValueLabel.Name = "helyszinValueLabel";
            this.helyszinValueLabel.Size = new System.Drawing.Size(343, 35);
            this.helyszinValueLabel.TabIndex = 5;
            this.helyszinValueLabel.Text = "-";
            // 
            // turizmusLabel
            // 
            this.turizmusLabel.AutoSize = true;
            this.turizmusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.turizmusLabel.Location = new System.Drawing.Point(429, 153);
            this.turizmusLabel.Name = "turizmusLabel";
            this.turizmusLabel.Size = new System.Drawing.Size(116, 19);
            this.turizmusLabel.TabIndex = 6;
            this.turizmusLabel.Text = "Turizmus típusa:";
            // 
            // turizmusValueLabel
            // 
            this.turizmusValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.turizmusValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.turizmusValueLabel.Location = new System.Drawing.Point(548, 153);
            this.turizmusValueLabel.Name = "turizmusValueLabel";
            this.turizmusValueLabel.Size = new System.Drawing.Size(309, 22);
            this.turizmusValueLabel.TabIndex = 7;
            this.turizmusValueLabel.Text = "-";
            // 
            // leirasLabel
            // 
            this.leirasLabel.AutoSize = true;
            this.leirasLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.leirasLabel.Location = new System.Drawing.Point(17, 312);
            this.leirasLabel.Name = "leirasLabel";
            this.leirasLabel.Size = new System.Drawing.Size(52, 19);
            this.leirasLabel.TabIndex = 8;
            this.leirasLabel.Text = "Leírás:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(17, 490);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(171, 30);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Vissza";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += backButton_Click;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // leirasRichTextBox
            // 
            this.leirasRichTextBox.Location = new System.Drawing.Point(22, 334);
            this.leirasRichTextBox.Name = "leirasRichTextBox";
            this.leirasRichTextBox.Size = new System.Drawing.Size(818, 140);
            this.leirasRichTextBox.TabIndex = 11;
            this.leirasRichTextBox.Text = "";
            this.leirasRichTextBox.SelectionStart = 0;
            this.leirasRichTextBox.SelectionLength = 0;
            this.leirasRichTextBox.Font = new Font("Segoe UI", 10);

            // 
            // NevezetessegReszletekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.leirasRichTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.leirasLabel);
            this.Controls.Add(this.turizmusValueLabel);
            this.Controls.Add(this.turizmusLabel);
            this.Controls.Add(this.helyszinValueLabel);
            this.Controls.Add(this.helyszinLabel);
            this.Controls.Add(this.nevValueLabel);
            this.Controls.Add(this.nevLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NevezetessegReszletekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "További részletek";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
