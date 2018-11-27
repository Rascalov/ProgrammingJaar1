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
            this.lblInhoudVooraf = new System.Windows.Forms.Label();
            this.lblInhoudAchteraf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVergelijk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInhoudVooraf
            // 
            this.lblInhoudVooraf.AutoSize = true;
            this.lblInhoudVooraf.Location = new System.Drawing.Point(45, 69);
            this.lblInhoudVooraf.Name = "lblInhoudVooraf";
            this.lblInhoudVooraf.Size = new System.Drawing.Size(51, 13);
            this.lblInhoudVooraf.TabIndex = 0;
            this.lblInhoudVooraf.Text = "labelVoor";
            // 
            // lblInhoudAchteraf
            // 
            this.lblInhoudAchteraf.AutoSize = true;
            this.lblInhoudAchteraf.Location = new System.Drawing.Point(248, 69);
            this.lblInhoudAchteraf.Name = "lblInhoudAchteraf";
            this.lblInhoudAchteraf.Size = new System.Drawing.Size(43, 13);
            this.lblInhoudAchteraf.TabIndex = 1;
            this.lblInhoudAchteraf.Text = "labelNa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inhoud tabel (achteraf)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inhoud tabl (vooraf)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(166, 378);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(100, 20);
            this.txtInvoer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vergelijkingsgetal";
            // 
            // btnVergelijk
            // 
            this.btnVergelijk.Location = new System.Drawing.Point(296, 378);
            this.btnVergelijk.Name = "btnVergelijk";
            this.btnVergelijk.Size = new System.Drawing.Size(75, 23);
            this.btnVergelijk.TabIndex = 6;
            this.btnVergelijk.Text = "V̲ergelijk";
            this.btnVergelijk.UseVisualStyleBackColor = true;
            this.btnVergelijk.Click += new System.EventHandler(this.btnVergelijk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.btnVergelijk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInhoudAchteraf);
            this.Controls.Add(this.lblInhoudVooraf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInhoudVooraf;
        private System.Windows.Forms.Label lblInhoudAchteraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVergelijk;
    }
}

