namespace Opdracht5
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
            this.rdbtn5Km = new System.Windows.Forms.RadioButton();
            this.rdbtn21Km = new System.Windows.Forms.RadioButton();
            this.rdbtn10Km = new System.Windows.Forms.RadioButton();
            this.txtUren = new System.Windows.Forms.TextBox();
            this.txtMinuten = new System.Windows.Forms.TextBox();
            this.txtSeconden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKmPerUur = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtn5Km
            // 
            this.rdbtn5Km.AutoSize = true;
            this.rdbtn5Km.Location = new System.Drawing.Point(12, 64);
            this.rdbtn5Km.Name = "rdbtn5Km";
            this.rdbtn5Km.Size = new System.Drawing.Size(48, 17);
            this.rdbtn5Km.TabIndex = 0;
            this.rdbtn5Km.TabStop = true;
            this.rdbtn5Km.Text = "5 km";
            this.rdbtn5Km.UseVisualStyleBackColor = true;
            // 
            // rdbtn21Km
            // 
            this.rdbtn21Km.AutoSize = true;
            this.rdbtn21Km.Location = new System.Drawing.Point(181, 64);
            this.rdbtn21Km.Name = "rdbtn21Km";
            this.rdbtn21Km.Size = new System.Drawing.Size(54, 17);
            this.rdbtn21Km.TabIndex = 1;
            this.rdbtn21Km.TabStop = true;
            this.rdbtn21Km.Text = "21 km";
            this.rdbtn21Km.UseVisualStyleBackColor = true;
            // 
            // rdbtn10Km
            // 
            this.rdbtn10Km.AutoSize = true;
            this.rdbtn10Km.Location = new System.Drawing.Point(95, 64);
            this.rdbtn10Km.Name = "rdbtn10Km";
            this.rdbtn10Km.Size = new System.Drawing.Size(54, 17);
            this.rdbtn10Km.TabIndex = 2;
            this.rdbtn10Km.TabStop = true;
            this.rdbtn10Km.Text = "10 km";
            this.rdbtn10Km.UseVisualStyleBackColor = true;
            // 
            // txtUren
            // 
            this.txtUren.Location = new System.Drawing.Point(78, 117);
            this.txtUren.Name = "txtUren";
            this.txtUren.Size = new System.Drawing.Size(46, 20);
            this.txtUren.TabIndex = 3;
            this.txtUren.Text = "0";
            // 
            // txtMinuten
            // 
            this.txtMinuten.Location = new System.Drawing.Point(130, 117);
            this.txtMinuten.Name = "txtMinuten";
            this.txtMinuten.Size = new System.Drawing.Size(46, 20);
            this.txtMinuten.TabIndex = 4;
            this.txtMinuten.Text = "0";
            // 
            // txtSeconden
            // 
            this.txtSeconden.Location = new System.Drawing.Point(181, 117);
            this.txtSeconden.Name = "txtSeconden";
            this.txtSeconden.Size = new System.Drawing.Size(46, 20);
            this.txtSeconden.TabIndex = 5;
            this.txtSeconden.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "hh:mm:ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Snelheid (km/uur)";
            // 
            // lblKmPerUur
            // 
            this.lblKmPerUur.AutoSize = true;
            this.lblKmPerUur.Location = new System.Drawing.Point(164, 214);
            this.lblKmPerUur.Name = "lblKmPerUur";
            this.lblKmPerUur.Size = new System.Drawing.Size(14, 13);
            this.lblKmPerUur.TabIndex = 8;
            this.lblKmPerUur.Text = "X";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(15, 163);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(212, 27);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "B̲ereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 263);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblKmPerUur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeconden);
            this.Controls.Add(this.txtMinuten);
            this.Controls.Add(this.txtUren);
            this.Controls.Add(this.rdbtn10Km);
            this.Controls.Add(this.rdbtn21Km);
            this.Controls.Add(this.rdbtn5Km);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtn5Km;
        private System.Windows.Forms.RadioButton rdbtn21Km;
        private System.Windows.Forms.RadioButton rdbtn10Km;
        private System.Windows.Forms.TextBox txtUren;
        private System.Windows.Forms.TextBox txtMinuten;
        private System.Windows.Forms.TextBox txtSeconden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKmPerUur;
        private System.Windows.Forms.Button btnBereken;
    }
}

