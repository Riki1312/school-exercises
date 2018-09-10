namespace Es01_Concerti
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumeroPosti = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonInserisci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDescrizione = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonCercaCitta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCercaCitta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonCercaPosti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCercaPosti = new System.Windows.Forms.TextBox();
            this.MessaggioInserimento = new System.Windows.Forms.Label();
            this.MessaggioCercaPosti = new System.Windows.Forms.Label();
            this.MessaggioCercaCitta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPosti)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "GestionePrenotazioni";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonPrenotazioni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MessaggioInserimento);
            this.groupBox1.Controls.Add(this.NumeroPosti);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonInserisci);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxDescrizione);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Città";
            // 
            // NumeroPosti
            // 
            this.NumeroPosti.Location = new System.Drawing.Point(139, 71);
            this.NumeroPosti.Name = "NumeroPosti";
            this.NumeroPosti.Size = new System.Drawing.Size(230, 20);
            this.NumeroPosti.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero di posti:";
            // 
            // ButtonInserisci
            // 
            this.ButtonInserisci.BackColor = System.Drawing.Color.White;
            this.ButtonInserisci.Location = new System.Drawing.Point(607, 43);
            this.ButtonInserisci.Name = "ButtonInserisci";
            this.ButtonInserisci.Size = new System.Drawing.Size(125, 46);
            this.ButtonInserisci.TabIndex = 3;
            this.ButtonInserisci.Text = "Inserisci";
            this.ButtonInserisci.UseVisualStyleBackColor = false;
            this.ButtonInserisci.Click += new System.EventHandler(this.ButtonInserisci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrizione città:";
            // 
            // TextBoxDescrizione
            // 
            this.TextBoxDescrizione.Location = new System.Drawing.Point(139, 46);
            this.TextBoxDescrizione.Name = "TextBoxDescrizione";
            this.TextBoxDescrizione.Size = new System.Drawing.Size(230, 20);
            this.TextBoxDescrizione.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MessaggioCercaCitta);
            this.groupBox2.Controls.Add(this.ButtonCercaCitta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextBoxCercaCitta);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 215);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cerca Città";
            // 
            // ButtonCercaCitta
            // 
            this.ButtonCercaCitta.BackColor = System.Drawing.Color.White;
            this.ButtonCercaCitta.Location = new System.Drawing.Point(25, 156);
            this.ButtonCercaCitta.Name = "ButtonCercaCitta";
            this.ButtonCercaCitta.Size = new System.Drawing.Size(309, 35);
            this.ButtonCercaCitta.TabIndex = 3;
            this.ButtonCercaCitta.Text = "Inizia ricerca";
            this.ButtonCercaCitta.UseVisualStyleBackColor = false;
            this.ButtonCercaCitta.Click += new System.EventHandler(this.ButtonCercaCitta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrizione città:";
            // 
            // TextBoxCercaCitta
            // 
            this.TextBoxCercaCitta.Location = new System.Drawing.Point(139, 58);
            this.TextBoxCercaCitta.Name = "TextBoxCercaCitta";
            this.TextBoxCercaCitta.Size = new System.Drawing.Size(195, 20);
            this.TextBoxCercaCitta.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MessaggioCercaPosti);
            this.groupBox3.Controls.Add(this.ButtonCercaPosti);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TextBoxCercaPosti);
            this.groupBox3.Location = new System.Drawing.Point(410, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 215);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cerca Posti";
            // 
            // ButtonCercaPosti
            // 
            this.ButtonCercaPosti.BackColor = System.Drawing.Color.White;
            this.ButtonCercaPosti.Location = new System.Drawing.Point(25, 156);
            this.ButtonCercaPosti.Name = "ButtonCercaPosti";
            this.ButtonCercaPosti.Size = new System.Drawing.Size(309, 35);
            this.ButtonCercaPosti.TabIndex = 3;
            this.ButtonCercaPosti.Text = "Inizia ricerca";
            this.ButtonCercaPosti.UseVisualStyleBackColor = false;
            this.ButtonCercaPosti.Click += new System.EventHandler(this.ButtonCerca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codice città:";
            // 
            // TextBoxCercaPosti
            // 
            this.TextBoxCercaPosti.Location = new System.Drawing.Point(117, 58);
            this.TextBoxCercaPosti.Name = "TextBoxCercaPosti";
            this.TextBoxCercaPosti.Size = new System.Drawing.Size(217, 20);
            this.TextBoxCercaPosti.TabIndex = 0;
            // 
            // MessaggioInserimento
            // 
            this.MessaggioInserimento.AutoSize = true;
            this.MessaggioInserimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessaggioInserimento.ForeColor = System.Drawing.Color.Gray;
            this.MessaggioInserimento.Location = new System.Drawing.Point(398, 60);
            this.MessaggioInserimento.Name = "MessaggioInserimento";
            this.MessaggioInserimento.Size = new System.Drawing.Size(9, 13);
            this.MessaggioInserimento.TabIndex = 4;
            this.MessaggioInserimento.Text = "|";
            // 
            // MessaggioCercaPosti
            // 
            this.MessaggioCercaPosti.AutoSize = true;
            this.MessaggioCercaPosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessaggioCercaPosti.ForeColor = System.Drawing.Color.Gray;
            this.MessaggioCercaPosti.Location = new System.Drawing.Point(22, 114);
            this.MessaggioCercaPosti.Name = "MessaggioCercaPosti";
            this.MessaggioCercaPosti.Size = new System.Drawing.Size(13, 13);
            this.MessaggioCercaPosti.TabIndex = 8;
            this.MessaggioCercaPosti.Text = "_";
            // 
            // MessaggioCercaCitta
            // 
            this.MessaggioCercaCitta.AutoSize = true;
            this.MessaggioCercaCitta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessaggioCercaCitta.ForeColor = System.Drawing.Color.Gray;
            this.MessaggioCercaCitta.Location = new System.Drawing.Point(22, 114);
            this.MessaggioCercaCitta.Name = "MessaggioCercaCitta";
            this.MessaggioCercaCitta.Size = new System.Drawing.Size(13, 13);
            this.MessaggioCercaCitta.TabIndex = 9;
            this.MessaggioCercaCitta.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Informatica - Es01";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPosti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NumeroPosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonInserisci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDescrizione;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonCercaCitta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxCercaCitta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonCercaPosti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCercaPosti;
        private System.Windows.Forms.Label MessaggioInserimento;
        private System.Windows.Forms.Label MessaggioCercaPosti;
        private System.Windows.Forms.Label MessaggioCercaCitta;
        private System.Windows.Forms.Label label3;
    }
}