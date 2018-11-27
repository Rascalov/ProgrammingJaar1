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
            this.txtInvoer1 = new System.Windows.Forms.TextBox();
            this.txtInvoer2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.btnDelen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal2";
            // 
            // txtInvoer1
            // 
            this.txtInvoer1.Location = new System.Drawing.Point(115, 35);
            this.txtInvoer1.Name = "txtInvoer1";
            this.txtInvoer1.Size = new System.Drawing.Size(100, 20);
            this.txtInvoer1.TabIndex = 2;
            // 
            // txtInvoer2
            // 
            this.txtInvoer2.Location = new System.Drawing.Point(115, 72);
            this.txtInvoer2.Name = "txtInvoer2";
            this.txtInvoer2.Size = new System.Drawing.Size(100, 20);
            this.txtInvoer2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(47, 116);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(68, 60);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(121, 116);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(68, 60);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKeer
            // 
            this.btnKeer.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeer.Location = new System.Drawing.Point(195, 116);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(68, 60);
            this.btnKeer.TabIndex = 6;
            this.btnKeer.Text = "X";
            this.btnKeer.UseVisualStyleBackColor = true;
            this.btnKeer.Click += new System.EventHandler(this.btnKeer_Click);
            // 
            // btnDelen
            // 
            this.btnDelen.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelen.Location = new System.Drawing.Point(269, 116);
            this.btnDelen.Name = "btnDelen";
            this.btnDelen.Size = new System.Drawing.Size(68, 60);
            this.btnDelen.TabIndex = 7;
            this.btnDelen.Text = ":";
            this.btnDelen.UseVisualStyleBackColor = true;
            this.btnDelen.Click += new System.EventHandler(this.btnDelen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uitkomst";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(181, 195);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(14, 13);
            this.lblUitkomst.TabIndex = 9;
            this.lblUitkomst.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 220);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelen);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtInvoer2);
            this.Controls.Add(this.txtInvoer1);
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
        private System.Windows.Forms.TextBox txtInvoer1;
        private System.Windows.Forms.TextBox txtInvoer2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Button btnDelen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUitkomst;
    }
}

