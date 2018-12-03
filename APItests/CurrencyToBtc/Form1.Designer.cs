namespace CurrencyToBtc
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
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtUitvoer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblWaarde = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBigBlackRock = new System.Windows.Forms.Button();
            this.lblBitcoinAmount = new System.Windows.Forms.Label();
            this.lblBitcoinValue = new System.Windows.Forms.Label();
            this.cmbValutaGame = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoundError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(16, 33);
            this.txtInvoer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(288, 22);
            this.txtInvoer.TabIndex = 0;
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Items.AddRange(new object[] {
            "USD (United States Dollar)",
            "CAD (Canadian Dollar)",
            "EUR (European Euro)",
            "RUB (Russian Ruble)"});
            this.cmbValuta.Location = new System.Drawing.Point(16, 91);
            this.cmbValuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(288, 24);
            this.cmbValuta.TabIndex = 1;
            this.cmbValuta.Text = "Kies uw valuta";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(16, 156);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(289, 28);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtUitvoer
            // 
            this.txtUitvoer.Location = new System.Drawing.Point(16, 222);
            this.txtUitvoer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUitvoer.Name = "txtUitvoer";
            this.txtUitvoer.Size = new System.Drawing.Size(288, 22);
            this.txtUitvoer.TabIndex = 3;
            this.txtUitvoer.TextChanged += new System.EventHandler(this.txtUitvoer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoeveelheid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valuta:";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(12, 124);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(293, 28);
            this.lblError.TabIndex = 6;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaarde
            // 
            this.lblWaarde.BackColor = System.Drawing.SystemColors.Control;
            this.lblWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaarde.ForeColor = System.Drawing.Color.Red;
            this.lblWaarde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWaarde.Location = new System.Drawing.Point(16, 188);
            this.lblWaarde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaarde.Name = "lblWaarde";
            this.lblWaarde.Size = new System.Drawing.Size(293, 28);
            this.lblWaarde.TabIndex = 7;
            this.lblWaarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(4, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 248);
            this.panel1.TabIndex = 8;
            // 
            // btnBigBlackRock
            // 
            this.btnBigBlackRock.BackColor = System.Drawing.SystemColors.Control;
            this.btnBigBlackRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBigBlackRock.BackgroundImage")));
            this.btnBigBlackRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBigBlackRock.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnBigBlackRock.FlatAppearance.BorderSize = 0;
            this.btnBigBlackRock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnBigBlackRock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnBigBlackRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBigBlackRock.Location = new System.Drawing.Point(328, 33);
            this.btnBigBlackRock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBigBlackRock.Name = "btnBigBlackRock";
            this.btnBigBlackRock.Size = new System.Drawing.Size(992, 699);
            this.btnBigBlackRock.TabIndex = 9;
            this.btnBigBlackRock.UseVisualStyleBackColor = false;
            this.btnBigBlackRock.Click += new System.EventHandler(this.btnBigBlackRock_Click);
            // 
            // lblBitcoinAmount
            // 
            this.lblBitcoinAmount.AutoSize = true;
            this.lblBitcoinAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoinAmount.Location = new System.Drawing.Point(357, 783);
            this.lblBitcoinAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitcoinAmount.Name = "lblBitcoinAmount";
            this.lblBitcoinAmount.Size = new System.Drawing.Size(142, 28);
            this.lblBitcoinAmount.TabIndex = 10;
            this.lblBitcoinAmount.Text = "0 Bitcoin(s)";
            // 
            // lblBitcoinValue
            // 
            this.lblBitcoinValue.AutoSize = true;
            this.lblBitcoinValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoinValue.Location = new System.Drawing.Point(929, 783);
            this.lblBitcoinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitcoinValue.Name = "lblBitcoinValue";
            this.lblBitcoinValue.Size = new System.Drawing.Size(26, 28);
            this.lblBitcoinValue.TabIndex = 11;
            this.lblBitcoinValue.Text = "0";
            // 
            // cmbValutaGame
            // 
            this.cmbValutaGame.FormattingEnabled = true;
            this.cmbValutaGame.Items.AddRange(new object[] {
            "USD (United States Dollar)",
            "CAD (Canadian Dollar)",
            "EUR (European Euro)",
            "RUB (Russian Ruble)"});
            this.cmbValutaGame.Location = new System.Drawing.Point(668, 783);
            this.cmbValutaGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbValutaGame.Name = "cmbValutaGame";
            this.cmbValutaGame.Size = new System.Drawing.Size(160, 24);
            this.cmbValutaGame.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 752);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Currency:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSoundError
            // 
            this.lblSoundError.AutoSize = true;
            this.lblSoundError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundError.ForeColor = System.Drawing.Color.Red;
            this.lblSoundError.Location = new System.Drawing.Point(14, 807);
            this.lblSoundError.Name = "lblSoundError";
            this.lblSoundError.Size = new System.Drawing.Size(0, 36);
            this.lblSoundError.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1336, 852);
            this.Controls.Add(this.lblSoundError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbValutaGame);
            this.Controls.Add(this.lblBitcoinValue);
            this.Controls.Add(this.lblBitcoinAmount);
            this.Controls.Add(this.btnBigBlackRock);
            this.Controls.Add(this.lblWaarde);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUitvoer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtUitvoer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblWaarde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBigBlackRock;
        private System.Windows.Forms.Label lblBitcoinAmount;
        private System.Windows.Forms.Label lblBitcoinValue;
        private System.Windows.Forms.ComboBox cmbValutaGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoundError;
    }
}

