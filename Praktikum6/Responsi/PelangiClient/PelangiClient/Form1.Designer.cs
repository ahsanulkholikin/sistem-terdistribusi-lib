namespace PelangiClient
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.tNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tWarna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Urut";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(101, 81);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(147, 23);
            this.btnProses.TabIndex = 1;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // tNo
            // 
            this.tNo.Location = new System.Drawing.Point(101, 41);
            this.tNo.Name = "tNo";
            this.tNo.Size = new System.Drawing.Size(147, 20);
            this.tNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Warna";
            // 
            // tWarna
            // 
            this.tWarna.Location = new System.Drawing.Point(101, 126);
            this.tWarna.Name = "tWarna";
            this.tWarna.Size = new System.Drawing.Size(147, 20);
            this.tWarna.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 195);
            this.Controls.Add(this.tWarna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNo);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.TextBox tNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tWarna;
    }
}

