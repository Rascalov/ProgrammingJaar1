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
            this.lblWaardes = new System.Windows.Forms.Label();
            this.btnGooien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWaardes
            // 
            this.lblWaardes.AutoSize = true;
            this.lblWaardes.Location = new System.Drawing.Point(43, 43);
            this.lblWaardes.Name = "lblWaardes";
            this.lblWaardes.Size = new System.Drawing.Size(75, 13);
            this.lblWaardes.TabIndex = 0;
            this.lblWaardes.Text = "Klik dan pussy";
            // 
            // btnGooien
            // 
            this.btnGooien.Location = new System.Drawing.Point(46, 169);
            this.btnGooien.Name = "btnGooien";
            this.btnGooien.Size = new System.Drawing.Size(223, 23);
            this.btnGooien.TabIndex = 1;
            this.btnGooien.Text = "G̲ooien";
            this.btnGooien.UseVisualStyleBackColor = true;
            this.btnGooien.Click += new System.EventHandler(this.btnGooien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 237);
            this.Controls.Add(this.btnGooien);
            this.Controls.Add(this.lblWaardes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaardes;
        private System.Windows.Forms.Button btnGooien;
    }
}

