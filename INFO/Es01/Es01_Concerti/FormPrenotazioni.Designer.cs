namespace Es01_Concerti
{
    partial class FormPrenotazioni
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MessaggioRitira = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxCodicePrenotazione = new System.Windows.Forms.TextBox();
            this.ButtonRitira = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MessaggioPrenotazione = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCodiceFiscale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxPostiPrenotare = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonPrenota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDescCitta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPostiPrenotare)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MessaggioRitira);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextBoxCodicePrenotazione);
            this.groupBox2.Controls.Add(this.ButtonRitira);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 150);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ritira Biglietti";
            // 
            // MessaggioRitira
            // 
            this.MessaggioRitira.AutoSize = true;
            this.MessaggioRitira.Location = new System.Drawing.Point(31, 89);
            this.MessaggioRitira.Name = "MessaggioRitira";
            this.MessaggioRitira.Size = new System.Drawing.Size(13, 13);
            this.MessaggioRitira.TabIndex = 22;
            this.MessaggioRitira.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codice prenotazione:";
            // 
            // TextBoxCodicePrenotazione
            // 
            this.TextBoxCodicePrenotazione.Location = new System.Drawing.Point(186, 39);
            this.TextBoxCodicePrenotazione.Name = "TextBoxCodicePrenotazione";
            this.TextBoxCodicePrenotazione.Size = new System.Drawing.Size(191, 20);
            this.TextBoxCodicePrenotazione.TabIndex = 20;
            this.TextBoxCodicePrenotazione.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonRitira
            // 
            this.ButtonRitira.BackColor = System.Drawing.Color.White;
            this.ButtonRitira.Location = new System.Drawing.Point(448, 34);
            this.ButtonRitira.Name = "ButtonRitira";
            this.ButtonRitira.Size = new System.Drawing.Size(191, 40);
            this.ButtonRitira.TabIndex = 19;
            this.ButtonRitira.Text = "Ritira";
            this.ButtonRitira.UseVisualStyleBackColor = false;
            this.ButtonRitira.Click += new System.EventHandler(this.ButtonRitira_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MessaggioPrenotazione);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxCodiceFiscale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxCognome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxNome);
            this.groupBox1.Controls.Add(this.TextBoxPostiPrenotare);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ButtonPrenota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxDescCitta);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 215);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenotazioni";
            // 
            // MessaggioPrenotazione
            // 
            this.MessaggioPrenotazione.AutoSize = true;
            this.MessaggioPrenotazione.Location = new System.Drawing.Point(445, 109);
            this.MessaggioPrenotazione.Name = "MessaggioPrenotazione";
            this.MessaggioPrenotazione.Size = new System.Drawing.Size(13, 13);
            this.MessaggioPrenotazione.TabIndex = 21;
            this.MessaggioPrenotazione.Tag = "";
            this.MessaggioPrenotazione.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codice fiscale:";
            // 
            // TextBoxCodiceFiscale
            // 
            this.TextBoxCodiceFiscale.Location = new System.Drawing.Point(186, 150);
            this.TextBoxCodiceFiscale.Name = "TextBoxCodiceFiscale";
            this.TextBoxCodiceFiscale.Size = new System.Drawing.Size(191, 20);
            this.TextBoxCodiceFiscale.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cognome:";
            // 
            // TextBoxCognome
            // 
            this.TextBoxCognome.Location = new System.Drawing.Point(186, 120);
            this.TextBoxCognome.Name = "TextBoxCognome";
            this.TextBoxCognome.Size = new System.Drawing.Size(191, 20);
            this.TextBoxCognome.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome:";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(186, 89);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(191, 20);
            this.TextBoxNome.TabIndex = 13;
            // 
            // TextBoxPostiPrenotare
            // 
            this.TextBoxPostiPrenotare.Location = new System.Drawing.Point(186, 61);
            this.TextBoxPostiPrenotare.Name = "TextBoxPostiPrenotare";
            this.TextBoxPostiPrenotare.Size = new System.Drawing.Size(191, 20);
            this.TextBoxPostiPrenotare.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Posti da prenotare:";
            // 
            // ButtonPrenota
            // 
            this.ButtonPrenota.BackColor = System.Drawing.Color.White;
            this.ButtonPrenota.Location = new System.Drawing.Point(448, 31);
            this.ButtonPrenota.Name = "ButtonPrenota";
            this.ButtonPrenota.Size = new System.Drawing.Size(191, 43);
            this.ButtonPrenota.TabIndex = 10;
            this.ButtonPrenota.Text = "Prenota";
            this.ButtonPrenota.UseVisualStyleBackColor = false;
            this.ButtonPrenota.Click += new System.EventHandler(this.ButtonPrenota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descrizione città:";
            // 
            // TextBoxDescCitta
            // 
            this.TextBoxDescCitta.Location = new System.Drawing.Point(186, 31);
            this.TextBoxDescCitta.Name = "TextBoxDescCitta";
            this.TextBoxDescCitta.Size = new System.Drawing.Size(191, 20);
            this.TextBoxDescCitta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gestione prenotazioni";
            // 
            // FormPrenotazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrenotazioni";
            this.Text = "FormPrenotazioni";
            this.Load += new System.EventHandler(this.FormPrenotazioni_load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPostiPrenotare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxCodicePrenotazione;
        private System.Windows.Forms.Button ButtonRitira;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCodiceFiscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.NumericUpDown TextBoxPostiPrenotare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonPrenota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDescCitta;
        private System.Windows.Forms.Label MessaggioRitira;
        private System.Windows.Forms.Label MessaggioPrenotazione;
        private System.Windows.Forms.Label label4;
    }
}