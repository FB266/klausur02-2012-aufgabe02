namespace alkoholAbbau
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nudAnzahlGetraenke = new System.Windows.Forms.NumericUpDown();
            this.rBmaennlich = new System.Windows.Forms.RadioButton();
            this.rBweiblich = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGewicht = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPromille = new System.Windows.Forms.TextBox();
            this.tBPromilleNach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlGetraenke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGewicht)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anzahl Getränke";
            // 
            // nudAnzahlGetraenke
            // 
            this.nudAnzahlGetraenke.Location = new System.Drawing.Point(152, 11);
            this.nudAnzahlGetraenke.Name = "nudAnzahlGetraenke";
            this.nudAnzahlGetraenke.Size = new System.Drawing.Size(120, 20);
            this.nudAnzahlGetraenke.TabIndex = 1;
            // 
            // rBmaennlich
            // 
            this.rBmaennlich.AutoSize = true;
            this.rBmaennlich.Location = new System.Drawing.Point(152, 38);
            this.rBmaennlich.Name = "rBmaennlich";
            this.rBmaennlich.Size = new System.Drawing.Size(68, 17);
            this.rBmaennlich.TabIndex = 2;
            this.rBmaennlich.TabStop = true;
            this.rBmaennlich.Text = "Männlich";
            this.rBmaennlich.UseVisualStyleBackColor = true;
            this.rBmaennlich.CheckedChanged += new System.EventHandler(this.rBmaennlich_CheckedChanged);
            // 
            // rBweiblich
            // 
            this.rBweiblich.AutoSize = true;
            this.rBweiblich.Location = new System.Drawing.Point(152, 55);
            this.rBweiblich.Name = "rBweiblich";
            this.rBweiblich.Size = new System.Drawing.Size(66, 17);
            this.rBweiblich.TabIndex = 3;
            this.rBweiblich.TabStop = true;
            this.rBweiblich.Text = "Weiblich";
            this.rBweiblich.UseVisualStyleBackColor = true;
            this.rBweiblich.CheckedChanged += new System.EventHandler(this.rBweiblich_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gewicht";
            // 
            // nudGewicht
            // 
            this.nudGewicht.Location = new System.Drawing.Point(152, 78);
            this.nudGewicht.Name = "nudGewicht";
            this.nudGewicht.Size = new System.Drawing.Size(120, 20);
            this.nudGewicht.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Promille";
            // 
            // tBPromille
            // 
            this.tBPromille.Enabled = false;
            this.tBPromille.Location = new System.Drawing.Point(152, 118);
            this.tBPromille.Name = "tBPromille";
            this.tBPromille.Size = new System.Drawing.Size(120, 20);
            this.tBPromille.TabIndex = 7;
            // 
            // tBPromilleNach
            // 
            this.tBPromilleNach.Enabled = false;
            this.tBPromilleNach.Location = new System.Drawing.Point(152, 144);
            this.tBPromilleNach.Multiline = true;
            this.tBPromilleNach.Name = "tBPromilleNach";
            this.tBPromilleNach.Size = new System.Drawing.Size(120, 106);
            this.tBPromilleNach.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Promille nach";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(196, 256);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(75, 23);
            this.btnBerechnen.TabIndex = 10;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(110, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Zurücksetzen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(29, 256);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(75, 23);
            this.btnBeenden.TabIndex = 12;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBPromilleNach);
            this.Controls.Add(this.tBPromille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudGewicht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rBweiblich);
            this.Controls.Add(this.rBmaennlich);
            this.Controls.Add(this.nudAnzahlGetraenke);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alkohol Abbau";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlGetraenke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGewicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAnzahlGetraenke;
        private System.Windows.Forms.RadioButton rBmaennlich;
        private System.Windows.Forms.RadioButton rBweiblich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGewicht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPromille;
        private System.Windows.Forms.TextBox tBPromilleNach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBeenden;
    }
}

