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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPrijsGeenBTW = new System.Windows.Forms.Label();
            this.labelBTW = new System.Windows.Forms.Label();
            this.labelPrijsMetBTW = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonWissen = new System.Windows.Forms.Button();
            this.ButtenBedragen = new System.Windows.Forms.Button();
            this.textBeginKM = new System.Windows.Forms.TextBox();
            this.textEindKM = new System.Windows.Forms.TextBox();
            this.textPrijsKM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin KM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eind KM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijs per KM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prijs excl. BTW";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BTW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prijs incl. BTW";
            // 
            // labelPrijsGeenBTW
            // 
            this.labelPrijsGeenBTW.AutoSize = true;
            this.labelPrijsGeenBTW.Location = new System.Drawing.Point(15, 195);
            this.labelPrijsGeenBTW.Name = "labelPrijsGeenBTW";
            this.labelPrijsGeenBTW.Size = new System.Drawing.Size(0, 13);
            this.labelPrijsGeenBTW.TabIndex = 6;
            // 
            // labelBTW
            // 
            this.labelBTW.AutoSize = true;
            this.labelBTW.Location = new System.Drawing.Point(141, 195);
            this.labelBTW.Name = "labelBTW";
            this.labelBTW.Size = new System.Drawing.Size(0, 13);
            this.labelBTW.TabIndex = 7;
            this.labelBTW.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelPrijsMetBTW
            // 
            this.labelPrijsMetBTW.AutoSize = true;
            this.labelPrijsMetBTW.Location = new System.Drawing.Point(303, 195);
            this.labelPrijsMetBTW.Name = "labelPrijsMetBTW";
            this.labelPrijsMetBTW.Size = new System.Drawing.Size(0, 13);
            this.labelPrijsMetBTW.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(15, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 1);
            this.label10.TabIndex = 9;
            // 
            // buttonWissen
            // 
            this.buttonWissen.Location = new System.Drawing.Point(290, 29);
            this.buttonWissen.Name = "buttonWissen";
            this.buttonWissen.Size = new System.Drawing.Size(75, 23);
            this.buttonWissen.TabIndex = 10;
            this.buttonWissen.Text = "Wissen";
            this.buttonWissen.UseVisualStyleBackColor = true;
            this.buttonWissen.Click += new System.EventHandler(this.buttonWissen_Click);
            // 
            // ButtenBedragen
            // 
            this.ButtenBedragen.Location = new System.Drawing.Point(290, 94);
            this.ButtenBedragen.Name = "ButtenBedragen";
            this.ButtenBedragen.Size = new System.Drawing.Size(75, 23);
            this.ButtenBedragen.TabIndex = 11;
            this.ButtenBedragen.Text = "Bedragen";
            this.ButtenBedragen.UseVisualStyleBackColor = true;
            this.ButtenBedragen.Click += new System.EventHandler(this.ButtenBedragen_Click);
            // 
            // textBeginKM
            // 
            this.textBeginKM.Location = new System.Drawing.Point(144, 32);
            this.textBeginKM.Name = "textBeginKM";
            this.textBeginKM.Size = new System.Drawing.Size(100, 20);
            this.textBeginKM.TabIndex = 12;
            // 
            // textEindKM
            // 
            this.textEindKM.Location = new System.Drawing.Point(144, 65);
            this.textEindKM.Name = "textEindKM";
            this.textEindKM.Size = new System.Drawing.Size(100, 20);
            this.textEindKM.TabIndex = 13;
            // 
            // textPrijsKM
            // 
            this.textPrijsKM.Location = new System.Drawing.Point(144, 94);
            this.textPrijsKM.Name = "textPrijsKM";
            this.textPrijsKM.Size = new System.Drawing.Size(100, 20);
            this.textPrijsKM.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 239);
            this.Controls.Add(this.textPrijsKM);
            this.Controls.Add(this.textEindKM);
            this.Controls.Add(this.textBeginKM);
            this.Controls.Add(this.ButtenBedragen);
            this.Controls.Add(this.buttonWissen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelPrijsMetBTW);
            this.Controls.Add(this.labelBTW);
            this.Controls.Add(this.labelPrijsGeenBTW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPrijsGeenBTW;
        private System.Windows.Forms.Label labelBTW;
        private System.Windows.Forms.Label labelPrijsMetBTW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonWissen;
        private System.Windows.Forms.Button ButtenBedragen;
        private System.Windows.Forms.TextBox textBeginKM;
        private System.Windows.Forms.TextBox textEindKM;
        private System.Windows.Forms.TextBox textPrijsKM;
    }
}

