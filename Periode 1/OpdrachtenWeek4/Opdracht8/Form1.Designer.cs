namespace Opdracht8
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
            this.lblUitkomstF1 = new System.Windows.Forms.Label();
            this.lblUitkomstF2 = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.btnVergelijkFormules = new System.Windows.Forms.Button();
            this.lblMessageVergelijking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een getal (n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Som = 1 + 2 + ... + n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Som = n * (n +1) /2";
            // 
            // lblUitkomstF1
            // 
            this.lblUitkomstF1.AutoSize = true;
            this.lblUitkomstF1.Location = new System.Drawing.Point(240, 157);
            this.lblUitkomstF1.Name = "lblUitkomstF1";
            this.lblUitkomstF1.Size = new System.Drawing.Size(35, 13);
            this.lblUitkomstF1.TabIndex = 3;
            this.lblUitkomstF1.Text = "label4";
            // 
            // lblUitkomstF2
            // 
            this.lblUitkomstF2.AutoSize = true;
            this.lblUitkomstF2.Location = new System.Drawing.Point(240, 192);
            this.lblUitkomstF2.Name = "lblUitkomstF2";
            this.lblUitkomstF2.Size = new System.Drawing.Size(35, 13);
            this.lblUitkomstF2.TabIndex = 4;
            this.lblUitkomstF2.Text = "label5";
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(175, 41);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(100, 20);
            this.txtInvoer.TabIndex = 5;
            // 
            // btnVergelijkFormules
            // 
            this.btnVergelijkFormules.Location = new System.Drawing.Point(40, 94);
            this.btnVergelijkFormules.Name = "btnVergelijkFormules";
            this.btnVergelijkFormules.Size = new System.Drawing.Size(235, 38);
            this.btnVergelijkFormules.TabIndex = 6;
            this.btnVergelijkFormules.Text = "Vergelijk";
            this.btnVergelijkFormules.UseVisualStyleBackColor = true;
            this.btnVergelijkFormules.Click += new System.EventHandler(this.btnVergelijkFormules_Click);
            // 
            // lblMessageVergelijking
            // 
            this.lblMessageVergelijking.AutoSize = true;
            this.lblMessageVergelijking.Location = new System.Drawing.Point(119, 225);
            this.lblMessageVergelijking.Name = "lblMessageVergelijking";
            this.lblMessageVergelijking.Size = new System.Drawing.Size(35, 13);
            this.lblMessageVergelijking.TabIndex = 7;
            this.lblMessageVergelijking.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 247);
            this.Controls.Add(this.lblMessageVergelijking);
            this.Controls.Add(this.btnVergelijkFormules);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblUitkomstF2);
            this.Controls.Add(this.lblUitkomstF1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUitkomstF1;
        private System.Windows.Forms.Label lblUitkomstF2;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Button btnVergelijkFormules;
        private System.Windows.Forms.Label lblMessageVergelijking;
    }
}

