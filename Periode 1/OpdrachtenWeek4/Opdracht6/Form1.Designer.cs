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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEindKapitaal = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.btnBerekenKapitaal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startbedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eindkapitaal";
            // 
            // lblEindKapitaal
            // 
            this.lblEindKapitaal.AutoSize = true;
            this.lblEindKapitaal.Location = new System.Drawing.Point(291, 192);
            this.lblEindKapitaal.Name = "lblEindKapitaal";
            this.lblEindKapitaal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEindKapitaal.Size = new System.Drawing.Size(0, 13);
            this.lblEindKapitaal.TabIndex = 2;
            this.lblEindKapitaal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(225, 72);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(100, 20);
            this.txtInvoer.TabIndex = 3;
            // 
            // btnBerekenKapitaal
            // 
            this.btnBerekenKapitaal.Location = new System.Drawing.Point(33, 126);
            this.btnBerekenKapitaal.Name = "btnBerekenKapitaal";
            this.btnBerekenKapitaal.Size = new System.Drawing.Size(292, 27);
            this.btnBerekenKapitaal.TabIndex = 4;
            this.btnBerekenKapitaal.Text = "Bereken bedrag na 5 jaar met 5% rente";
            this.btnBerekenKapitaal.UseVisualStyleBackColor = true;
            this.btnBerekenKapitaal.Click += new System.EventHandler(this.btnBerekenKapitaal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 231);
            this.Controls.Add(this.btnBerekenKapitaal);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblEindKapitaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEindKapitaal;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Button btnBerekenKapitaal;
    }
}

