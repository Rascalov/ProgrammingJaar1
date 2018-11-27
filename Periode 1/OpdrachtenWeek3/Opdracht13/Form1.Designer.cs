namespace Opdracht13
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblRentKosten = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDagenGehuurd = new System.Windows.Forms.TextBox();
            this.txtAantalLiters = new System.Windows.Forms.TextBox();
            this.txtAantalKm = new System.Windows.Forms.TextBox();
            this.checkBoxOpKostenHuurder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of rental days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of kms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of litres tanked";
            // 
            // lblRentKosten
            // 
            this.lblRentKosten.AutoSize = true;
            this.lblRentKosten.Location = new System.Drawing.Point(189, 200);
            this.lblRentKosten.Name = "lblRentKosten";
            this.lblRentKosten.Size = new System.Drawing.Size(0, 13);
            this.lblRentKosten.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rental price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Rental Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDagenGehuurd
            // 
            this.txtDagenGehuurd.Location = new System.Drawing.Point(192, 30);
            this.txtDagenGehuurd.Name = "txtDagenGehuurd";
            this.txtDagenGehuurd.Size = new System.Drawing.Size(100, 20);
            this.txtDagenGehuurd.TabIndex = 7;
            // 
            // txtAantalLiters
            // 
            this.txtAantalLiters.Location = new System.Drawing.Point(192, 124);
            this.txtAantalLiters.Name = "txtAantalLiters";
            this.txtAantalLiters.Size = new System.Drawing.Size(100, 20);
            this.txtAantalLiters.TabIndex = 8;
            // 
            // txtAantalKm
            // 
            this.txtAantalKm.Location = new System.Drawing.Point(192, 57);
            this.txtAantalKm.Name = "txtAantalKm";
            this.txtAantalKm.Size = new System.Drawing.Size(100, 20);
            this.txtAantalKm.TabIndex = 9;
            // 
            // checkBoxOpKostenHuurder
            // 
            this.checkBoxOpKostenHuurder.AutoSize = true;
            this.checkBoxOpKostenHuurder.Location = new System.Drawing.Point(37, 101);
            this.checkBoxOpKostenHuurder.Name = "checkBoxOpKostenHuurder";
            this.checkBoxOpKostenHuurder.Size = new System.Drawing.Size(156, 17);
            this.checkBoxOpKostenHuurder.TabIndex = 10;
            this.checkBoxOpKostenHuurder.Text = "Refuel on account of renter";
            this.checkBoxOpKostenHuurder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 222);
            this.Controls.Add(this.checkBoxOpKostenHuurder);
            this.Controls.Add(this.txtAantalKm);
            this.Controls.Add(this.txtAantalLiters);
            this.Controls.Add(this.txtDagenGehuurd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRentKosten);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRentKosten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDagenGehuurd;
        private System.Windows.Forms.TextBox txtAantalLiters;
        private System.Windows.Forms.TextBox txtAantalKm;
        private System.Windows.Forms.CheckBox checkBoxOpKostenHuurder;
    }
}

