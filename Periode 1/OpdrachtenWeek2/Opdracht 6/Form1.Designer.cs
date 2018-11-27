namespace Opdracht_6
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
            this.tijdDisplay = new System.Windows.Forms.Label();
            this.textInvoerSeconden = new System.Windows.Forms.TextBox();
            this.tijdBerekenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconden:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "uren : minuten : seconden";
            // 
            // tijdDisplay
            // 
            this.tijdDisplay.AutoSize = true;
            this.tijdDisplay.Location = new System.Drawing.Point(46, 193);
            this.tijdDisplay.Name = "tijdDisplay";
            this.tijdDisplay.Size = new System.Drawing.Size(0, 13);
            this.tijdDisplay.TabIndex = 2;
            // 
            // textInvoerSeconden
            // 
            this.textInvoerSeconden.Location = new System.Drawing.Point(181, 60);
            this.textInvoerSeconden.Name = "textInvoerSeconden";
            this.textInvoerSeconden.Size = new System.Drawing.Size(100, 20);
            this.textInvoerSeconden.TabIndex = 3;
            // 
            // tijdBerekenen
            // 
            this.tijdBerekenen.Location = new System.Drawing.Point(49, 106);
            this.tijdBerekenen.Name = "tijdBerekenen";
            this.tijdBerekenen.Size = new System.Drawing.Size(232, 23);
            this.tijdBerekenen.TabIndex = 4;
            this.tijdBerekenen.Text = "Bereken Tijd";
            this.tijdBerekenen.UseVisualStyleBackColor = true;
            this.tijdBerekenen.Click += new System.EventHandler(this.tijdBerekenen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 226);
            this.Controls.Add(this.tijdBerekenen);
            this.Controls.Add(this.textInvoerSeconden);
            this.Controls.Add(this.tijdDisplay);
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
        private System.Windows.Forms.Label tijdDisplay;
        private System.Windows.Forms.TextBox textInvoerSeconden;
        private System.Windows.Forms.Button tijdBerekenen;
    }
}

