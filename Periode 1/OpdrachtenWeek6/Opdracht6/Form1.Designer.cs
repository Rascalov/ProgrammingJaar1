namespace Opdracht6
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
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.btnKwadraad1 = new System.Windows.Forms.Button();
            this.btnKwadraad2 = new System.Windows.Forms.Button();
            this.btnKwadraad3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(173, 240);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(14, 13);
            this.lblUitkomst.TabIndex = 1;
            this.lblUitkomst.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uitkomst";
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(167, 62);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(143, 20);
            this.txtInvoer.TabIndex = 3;
            // 
            // btnKwadraad1
            // 
            this.btnKwadraad1.Location = new System.Drawing.Point(46, 119);
            this.btnKwadraad1.Name = "btnKwadraad1";
            this.btnKwadraad1.Size = new System.Drawing.Size(264, 32);
            this.btnKwadraad1.TabIndex = 4;
            this.btnKwadraad1.Text = "Bereken kwadraad By Reference (REF)";
            this.btnKwadraad1.UseVisualStyleBackColor = true;
            this.btnKwadraad1.Click += new System.EventHandler(this.btnKwadraad1_Click);
            // 
            // btnKwadraad2
            // 
            this.btnKwadraad2.Location = new System.Drawing.Point(46, 157);
            this.btnKwadraad2.Name = "btnKwadraad2";
            this.btnKwadraad2.Size = new System.Drawing.Size(264, 32);
            this.btnKwadraad2.TabIndex = 5;
            this.btnKwadraad2.Text = "Bereken kwadraad By Reference (OUT)";
            this.btnKwadraad2.UseVisualStyleBackColor = true;
            this.btnKwadraad2.Click += new System.EventHandler(this.btnKwadraad2_Click);
            // 
            // btnKwadraad3
            // 
            this.btnKwadraad3.Location = new System.Drawing.Point(46, 195);
            this.btnKwadraad3.Name = "btnKwadraad3";
            this.btnKwadraad3.Size = new System.Drawing.Size(264, 32);
            this.btnKwadraad3.TabIndex = 6;
            this.btnKwadraad3.Text = "Bereken kwadraad By Value";
            this.btnKwadraad3.UseVisualStyleBackColor = true;
            this.btnKwadraad3.Click += new System.EventHandler(this.btnKwadraad3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 299);
            this.Controls.Add(this.btnKwadraad3);
            this.Controls.Add(this.btnKwadraad2);
            this.Controls.Add(this.btnKwadraad1);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUitkomst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Button btnKwadraad1;
        private System.Windows.Forms.Button btnKwadraad2;
        private System.Windows.Forms.Button btnKwadraad3;
    }
}

