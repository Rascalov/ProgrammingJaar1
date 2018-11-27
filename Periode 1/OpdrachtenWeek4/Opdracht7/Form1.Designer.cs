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
            this.txtZijdes = new System.Windows.Forms.TextBox();
            this.btnMaakVierkant = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zijde";
            // 
            // txtZijdes
            // 
            this.txtZijdes.Location = new System.Drawing.Point(229, 52);
            this.txtZijdes.Name = "txtZijdes";
            this.txtZijdes.Size = new System.Drawing.Size(100, 20);
            this.txtZijdes.TabIndex = 1;
            // 
            // btnMaakVierkant
            // 
            this.btnMaakVierkant.Location = new System.Drawing.Point(111, 109);
            this.btnMaakVierkant.Name = "btnMaakVierkant";
            this.btnMaakVierkant.Size = new System.Drawing.Size(245, 23);
            this.btnMaakVierkant.TabIndex = 2;
            this.btnMaakVierkant.Text = "M̲aak vierkant";
            this.btnMaakVierkant.UseVisualStyleBackColor = true;
            this.btnMaakVierkant.Click += new System.EventHandler(this.btnMaakVierkant_Click);
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(25, 135);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(419, 334);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 478);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnMaakVierkant);
            this.Controls.Add(this.txtZijdes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZijdes;
        private System.Windows.Forms.Button btnMaakVierkant;
        private System.Windows.Forms.Label lblX;
    }
}

