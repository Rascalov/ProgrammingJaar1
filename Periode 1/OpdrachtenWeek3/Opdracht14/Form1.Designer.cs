namespace Opdracht14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMINormaleWaardes = new System.Windows.Forms.Label();
            this.lblGezondGewicht = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnVrouw = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight (kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BMI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Normal BMI values";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Healthy weight";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(171, 22);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 13);
            this.lblBMI.TabIndex = 6;
            // 
            // lblBMINormaleWaardes
            // 
            this.lblBMINormaleWaardes.AutoSize = true;
            this.lblBMINormaleWaardes.Location = new System.Drawing.Point(171, 52);
            this.lblBMINormaleWaardes.Name = "lblBMINormaleWaardes";
            this.lblBMINormaleWaardes.Size = new System.Drawing.Size(0, 13);
            this.lblBMINormaleWaardes.TabIndex = 7;
            this.lblBMINormaleWaardes.Click += new System.EventHandler(this.lblBMINormaleWaardes_Click);
            // 
            // lblGezondGewicht
            // 
            this.lblGezondGewicht.AutoSize = true;
            this.lblGezondGewicht.Location = new System.Drawing.Point(171, 91);
            this.lblGezondGewicht.Name = "lblGezondGewicht";
            this.lblGezondGewicht.Size = new System.Drawing.Size(0, 13);
            this.lblGezondGewicht.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Output";
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(168, 67);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 20);
            this.txtLengte.TabIndex = 10;
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(168, 102);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 20);
            this.txtGewicht.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 94);
            this.panel1.TabIndex = 12;
            // 
            // btnMan
            // 
            this.btnMan.BackColor = System.Drawing.SystemColors.Control;
            this.btnMan.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMan.Image = ((System.Drawing.Image)(resources.GetObject("btnMan.Image")));
            this.btnMan.Location = new System.Drawing.Point(27, 350);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(134, 218);
            this.btnMan.TabIndex = 13;
            this.btnMan.Text = "Calculate Male";
            this.btnMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMan.UseVisualStyleBackColor = false;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // btnVrouw
            // 
            this.btnVrouw.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrouw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVrouw.Image = ((System.Drawing.Image)(resources.GetObject("btnVrouw.Image")));
            this.btnVrouw.Location = new System.Drawing.Point(167, 350);
            this.btnVrouw.Name = "btnVrouw";
            this.btnVrouw.Size = new System.Drawing.Size(134, 218);
            this.btnVrouw.TabIndex = 15;
            this.btnVrouw.Text = "Calculate Female";
            this.btnVrouw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrouw.UseVisualStyleBackColor = true;
            this.btnVrouw.Click += new System.EventHandler(this.btnVrouw_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblBMI);
            this.panel2.Controls.Add(this.lblBMINormaleWaardes);
            this.panel2.Controls.Add(this.lblGezondGewicht);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 117);
            this.panel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 580);
            this.Controls.Add(this.btnVrouw);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBMINormaleWaardes;
        private System.Windows.Forms.Label lblGezondGewicht;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnVrouw;
        private System.Windows.Forms.Panel panel2;
    }
}

