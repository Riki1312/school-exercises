namespace Esercizio_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnPosti = new System.Windows.Forms.Button();
            this.numPosti = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCitta = new System.Windows.Forms.TextBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescPre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numPrenotazioni = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCFS = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numPrenotazione = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosti)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrenotazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrenotazione)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerca);
            this.groupBox1.Controls.Add(this.btnPosti);
            this.groupBox1.Controls.Add(this.numPosti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodCitta);
            this.groupBox1.Controls.Add(this.btnIns);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestione città";
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(104, 104);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 9;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnPosti
            // 
            this.btnPosti.Location = new System.Drawing.Point(198, 104);
            this.btnPosti.Name = "btnPosti";
            this.btnPosti.Size = new System.Drawing.Size(75, 23);
            this.btnPosti.TabIndex = 8;
            this.btnPosti.Text = "Num posti";
            this.btnPosti.UseVisualStyleBackColor = true;
            this.btnPosti.Click += new System.EventHandler(this.btnPosti_Click);
            // 
            // numPosti
            // 
            this.numPosti.Location = new System.Drawing.Point(76, 78);
            this.numPosti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPosti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPosti.Name = "numPosti";
            this.numPosti.Size = new System.Drawing.Size(198, 20);
            this.numPosti.TabIndex = 7;
            this.numPosti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPosti.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrizione";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(76, 47);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(198, 20);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num Posti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codice città";
            // 
            // txtCodCitta
            // 
            this.txtCodCitta.Location = new System.Drawing.Point(76, 21);
            this.txtCodCitta.Name = "txtCodCitta";
            this.txtCodCitta.Size = new System.Drawing.Size(198, 20);
            this.txtCodCitta.TabIndex = 1;
            this.txtCodCitta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(6, 104);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 0;
            this.btnIns.Text = "Inserisci";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btIns_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numPrenotazione);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDescPre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numPrenotazioni);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCFS);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCognome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 228);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestione città";
            // 
            // txtDescPre
            // 
            this.txtDescPre.Location = new System.Drawing.Point(75, 156);
            this.txtDescPre.Name = "txtDescPre";
            this.txtDescPre.Size = new System.Drawing.Size(198, 20);
            this.txtDescPre.TabIndex = 13;
            this.txtDescPre.Text = "Citta rock e pop";
            this.txtDescPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Desc città";
            // 
            // numPrenotazioni
            // 
            this.numPrenotazioni.Location = new System.Drawing.Point(75, 130);
            this.numPrenotazioni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrenotazioni.Name = "numPrenotazioni";
            this.numPrenotazioni.Size = new System.Drawing.Size(198, 20);
            this.numPrenotazioni.TabIndex = 11;
            this.numPrenotazioni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPrenotazioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Numero posti";
            // 
            // txtCFS
            // 
            this.txtCFS.Location = new System.Drawing.Point(76, 102);
            this.txtCFS.Name = "txtCFS";
            this.txtCFS.Size = new System.Drawing.Size(198, 20);
            this.txtCFS.TabIndex = 9;
            this.txtCFS.Text = "PPPPLT80R10M082K";
            this.txtCFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ritira";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(76, 74);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(198, 20);
            this.txtCognome.TabIndex = 5;
            this.txtCognome.Text = "Costamagna";
            this.txtCognome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CFS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Matteo";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Prenota";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Prenotaz";
            // 
            // numPrenotazione
            // 
            this.numPrenotazione.Location = new System.Drawing.Point(75, 23);
            this.numPrenotazione.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrenotazione.Name = "numPrenotazione";
            this.numPrenotazione.Size = new System.Drawing.Size(198, 20);
            this.numPrenotazione.TabIndex = 16;
            this.numPrenotazione.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPrenotazione.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrenotazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrenotazione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numPosti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCitta;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnPosti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numPrenotazioni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCFS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtDescPre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPrenotazione;
    }
}

