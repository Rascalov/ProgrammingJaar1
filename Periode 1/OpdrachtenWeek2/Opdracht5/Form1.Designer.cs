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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textGetal1 = new System.Windows.Forms.TextBox();
            this.textGetal2 = new System.Windows.Forms.TextBox();
            this.textGetal3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gemiddelde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef getal 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geef getal 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geef getal 3:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textGetal1
            // 
            this.textGetal1.Location = new System.Drawing.Point(163, 26);
            this.textGetal1.Name = "textGetal1";
            this.textGetal1.Size = new System.Drawing.Size(100, 20);
            this.textGetal1.TabIndex = 3;
            this.textGetal1.TextChanged += new System.EventHandler(this.textGetal1_TextChanged);
            // 
            // textGetal2
            // 
            this.textGetal2.Location = new System.Drawing.Point(163, 65);
            this.textGetal2.Name = "textGetal2";
            this.textGetal2.Size = new System.Drawing.Size(100, 20);
            this.textGetal2.TabIndex = 4;
            // 
            // textGetal3
            // 
            this.textGetal3.Location = new System.Drawing.Point(163, 101);
            this.textGetal3.Name = "textGetal3";
            this.textGetal3.Size = new System.Drawing.Size(100, 20);
            this.textGetal3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bereken gemiddelde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gemiddelde";
            // 
            // gemiddelde
            // 
            this.gemiddelde.AutoSize = true;
            this.gemiddelde.Location = new System.Drawing.Point(163, 185);
            this.gemiddelde.Name = "gemiddelde";
            this.gemiddelde.Size = new System.Drawing.Size(0, 13);
            this.gemiddelde.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 236);
            this.Controls.Add(this.gemiddelde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textGetal3);
            this.Controls.Add(this.textGetal2);
            this.Controls.Add(this.textGetal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGetal1;
        private System.Windows.Forms.TextBox textGetal2;
        private System.Windows.Forms.TextBox textGetal3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gemiddelde;
    }
}

