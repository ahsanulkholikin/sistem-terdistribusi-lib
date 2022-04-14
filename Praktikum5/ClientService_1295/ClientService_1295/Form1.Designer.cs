namespace ClientService_1295
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.txtFa = new System.Windows.Forms.TextBox();
            this.txtKe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "S. Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "S. Reamur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "S. Fahrenheit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "S. Kelvin";
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(89, 72);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(163, 23);
            this.btnKonversi.TabIndex = 4;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(89, 28);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(163, 20);
            this.txtCel.TabIndex = 5;
            // 
            // txtRe
            // 
            this.txtRe.Location = new System.Drawing.Point(89, 117);
            this.txtRe.Name = "txtRe";
            this.txtRe.Size = new System.Drawing.Size(163, 20);
            this.txtRe.TabIndex = 6;
            // 
            // txtFa
            // 
            this.txtFa.Location = new System.Drawing.Point(89, 153);
            this.txtFa.Name = "txtFa";
            this.txtFa.Size = new System.Drawing.Size(163, 20);
            this.txtFa.TabIndex = 7;
            // 
            // txtKe
            // 
            this.txtKe.Location = new System.Drawing.Point(89, 192);
            this.txtKe.Name = "txtKe";
            this.txtKe.Size = new System.Drawing.Size(163, 20);
            this.txtKe.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 241);
            this.Controls.Add(this.txtKe);
            this.Controls.Add(this.txtFa);
            this.Controls.Add(this.txtRe);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.TextBox txtFa;
        private System.Windows.Forms.TextBox txtKe;
    }
}

