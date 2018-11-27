namespace Opdracht7
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
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdCelNaarKel = new System.Windows.Forms.RadioButton();
            this.rdCelNaarFah = new System.Windows.Forms.RadioButton();
            this.rdFahNaarCel = new System.Windows.Forms.RadioButton();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Omrekenen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uitkomst";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(289, 354);
            this.lblUitkomst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(17, 17);
            this.lblUitkomst.TabIndex = 3;
            this.lblUitkomst.Text = "X";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(64, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 161);
            this.label5.TabIndex = 4;
            // 
            // rdCelNaarKel
            // 
            this.rdCelNaarKel.AutoSize = true;
            this.rdCelNaarKel.Checked = true;
            this.rdCelNaarKel.Location = new System.Drawing.Point(103, 160);
            this.rdCelNaarKel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdCelNaarKel.Name = "rdCelNaarKel";
            this.rdCelNaarKel.Size = new System.Drawing.Size(176, 21);
            this.rdCelNaarKel.TabIndex = 5;
            this.rdCelNaarKel.TabStop = true;
            this.rdCelNaarKel.Text = "van Celsius naar Kelvin";
            this.rdCelNaarKel.UseVisualStyleBackColor = true;
            // 
            // rdCelNaarFah
            // 
            this.rdCelNaarFah.AutoSize = true;
            this.rdCelNaarFah.Location = new System.Drawing.Point(103, 188);
            this.rdCelNaarFah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdCelNaarFah.Name = "rdCelNaarFah";
            this.rdCelNaarFah.Size = new System.Drawing.Size(210, 21);
            this.rdCelNaarFah.TabIndex = 6;
            this.rdCelNaarFah.Text = "van Celcius naar Fahrenheid";
            this.rdCelNaarFah.UseVisualStyleBackColor = true;
            // 
            // rdFahNaarCel
            // 
            this.rdFahNaarCel.AutoSize = true;
            this.rdFahNaarCel.Location = new System.Drawing.Point(103, 217);
            this.rdFahNaarCel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFahNaarCel.Name = "rdFahNaarCel";
            this.rdFahNaarCel.Size = new System.Drawing.Size(210, 21);
            this.rdFahNaarCel.TabIndex = 7;
            this.rdFahNaarCel.Text = "van Fahrenheid naar Celcius";
            this.rdFahNaarCel.UseVisualStyleBackColor = true;
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(207, 33);
            this.txtInvoer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(155, 22);
            this.txtInvoer.TabIndex = 8;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(64, 305);
            this.btnBereken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(299, 32);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "Bereken nieuwe graden";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 399);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.rdFahNaarCel);
            this.Controls.Add(this.rdCelNaarFah);
            this.Controls.Add(this.rdCelNaarKel);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUitkomst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdCelNaarKel;
        private System.Windows.Forms.RadioButton rdCelNaarFah;
        private System.Windows.Forms.RadioButton rdFahNaarCel;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Button btnBereken;
    }
}

