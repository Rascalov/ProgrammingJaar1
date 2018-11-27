namespace Opdracht12
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
            this.lblPrijsTicket = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price Ticket";
            // 
            // lblPrijsTicket
            // 
            this.lblPrijsTicket.AutoSize = true;
            this.lblPrijsTicket.Location = new System.Drawing.Point(224, 123);
            this.lblPrijsTicket.Name = "lblPrijsTicket";
            this.lblPrijsTicket.Size = new System.Drawing.Size(35, 13);
            this.lblPrijsTicket.TabIndex = 2;
            this.lblPrijsTicket.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(175, 35);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 182);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrijsTicket);
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
        private System.Windows.Forms.Label lblPrijsTicket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLeeftijd;
    }
}

