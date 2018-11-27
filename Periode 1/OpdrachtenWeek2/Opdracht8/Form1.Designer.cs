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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelPrijs = new System.Windows.Forms.Label();
            this.labelBTW = new System.Windows.Forms.Label();
            this.labelTotaalPrijs = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxShirt = new System.Windows.Forms.TextBox();
            this.textBoxBroek = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal T-Shirts (á € 30,00)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal Broeken (á € 100.00)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rekening";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prijs:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(207, 271);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDatum.Size = new System.Drawing.Size(0, 13);
            this.labelDatum.TabIndex = 5;
            // 
            // labelPrijs
            // 
            this.labelPrijs.AutoSize = true;
            this.labelPrijs.Location = new System.Drawing.Point(252, 307);
            this.labelPrijs.Name = "labelPrijs";
            this.labelPrijs.Size = new System.Drawing.Size(0, 13);
            this.labelPrijs.TabIndex = 6;
            this.labelPrijs.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelBTW
            // 
            this.labelBTW.AutoSize = true;
            this.labelBTW.Location = new System.Drawing.Point(252, 332);
            this.labelBTW.Name = "labelBTW";
            this.labelBTW.Size = new System.Drawing.Size(0, 13);
            this.labelBTW.TabIndex = 7;
            // 
            // labelTotaalPrijs
            // 
            this.labelTotaalPrijs.AutoSize = true;
            this.labelTotaalPrijs.Location = new System.Drawing.Point(252, 370);
            this.labelTotaalPrijs.Name = "labelTotaalPrijs";
            this.labelTotaalPrijs.Size = new System.Drawing.Size(0, 13);
            this.labelTotaalPrijs.TabIndex = 8;
            this.labelTotaalPrijs.Click += new System.EventHandler(this.labelTotaalPrijs_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Totaal Prijs:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "BTW:";
            // 
            // textBoxShirt
            // 
            this.textBoxShirt.Location = new System.Drawing.Point(207, 47);
            this.textBoxShirt.Name = "textBoxShirt";
            this.textBoxShirt.Size = new System.Drawing.Size(100, 20);
            this.textBoxShirt.TabIndex = 11;
            // 
            // textBoxBroek
            // 
            this.textBoxBroek.Location = new System.Drawing.Point(207, 79);
            this.textBoxBroek.Name = "textBoxBroek";
            this.textBoxBroek.Size = new System.Drawing.Size(100, 20);
            this.textBoxBroek.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(35, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(47, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(21, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 159);
            this.label6.TabIndex = 15;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBroek);
            this.Controls.Add(this.textBoxShirt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTotaalPrijs);
            this.Controls.Add(this.labelBTW);
            this.Controls.Add(this.labelPrijs);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelPrijs;
        private System.Windows.Forms.Label labelBTW;
        private System.Windows.Forms.Label labelTotaalPrijs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxShirt;
        private System.Windows.Forms.TextBox textBoxBroek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
    }
}

