namespace Esercizio_2
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
            this.btnInsRivista = new System.Windows.Forms.Button();
            this.numPrezo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Periodo = new System.Windows.Forms.ComboBox();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbCitta = new System.Windows.Forms.ComboBox();
            this.dtpNascita = new System.Windows.Forms.DateTimePicker();
            this.btnInsPersona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInsPeriodo = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInsCitta = new System.Windows.Forms.Button();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAbbonato = new System.Windows.Forms.ComboBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRivista = new System.Windows.Forms.ComboBox();
            this.dtpValidita = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsRivista);
            this.groupBox1.Controls.Add(this.numPrezo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Periodo);
            this.groupBox1.Controls.Add(this.txtTitolo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rivista";
            // 
            // btnInsRivista
            // 
            this.btnInsRivista.Location = new System.Drawing.Point(10, 99);
            this.btnInsRivista.Name = "btnInsRivista";
            this.btnInsRivista.Size = new System.Drawing.Size(210, 23);
            this.btnInsRivista.TabIndex = 6;
            this.btnInsRivista.Text = "Inserisci";
            this.btnInsRivista.UseVisualStyleBackColor = true;
            this.btnInsRivista.Click += new System.EventHandler(this.button1_Click);
            // 
            // numPrezo
            // 
            this.numPrezo.DecimalPlaces = 2;
            this.numPrezo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrezo.Location = new System.Drawing.Point(56, 71);
            this.numPrezo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrezo.Name = "numPrezo";
            this.numPrezo.Size = new System.Drawing.Size(164, 20);
            this.numPrezo.TabIndex = 5;
            this.numPrezo.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo";
            // 
            // cb_Periodo
            // 
            this.cb_Periodo.FormattingEnabled = true;
            this.cb_Periodo.Location = new System.Drawing.Point(56, 44);
            this.cb_Periodo.Name = "cb_Periodo";
            this.cb_Periodo.Size = new System.Drawing.Size(164, 21);
            this.cb_Periodo.TabIndex = 2;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(56, 17);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(164, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.cbCitta);
            this.groupBox2.Controls.Add(this.dtpNascita);
            this.groupBox2.Controls.Add(this.btnInsPersona);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCognome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persona";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Città";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 9;
            // 
            // cbCitta
            // 
            this.cbCitta.FormattingEnabled = true;
            this.cbCitta.Location = new System.Drawing.Point(93, 93);
            this.cbCitta.Name = "cbCitta";
            this.cbCitta.Size = new System.Drawing.Size(164, 21);
            this.cbCitta.TabIndex = 8;
            // 
            // dtpNascita
            // 
            this.dtpNascita.Location = new System.Drawing.Point(93, 67);
            this.dtpNascita.Name = "dtpNascita";
            this.dtpNascita.Size = new System.Drawing.Size(164, 20);
            this.dtpNascita.TabIndex = 7;
            // 
            // btnInsPersona
            // 
            this.btnInsPersona.Location = new System.Drawing.Point(6, 120);
            this.btnInsPersona.Name = "btnInsPersona";
            this.btnInsPersona.Size = new System.Drawing.Size(251, 23);
            this.btnInsPersona.TabIndex = 6;
            this.btnInsPersona.Text = "Inserisci";
            this.btnInsPersona.UseVisualStyleBackColor = true;
            this.btnInsPersona.Click += new System.EventHandler(this.btnInsPersona_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nascita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(93, 17);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(164, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cognome";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInsPeriodo);
            this.groupBox3.Controls.Add(this.txtPeriodo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(281, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 75);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo";
            // 
            // btnInsPeriodo
            // 
            this.btnInsPeriodo.Location = new System.Drawing.Point(6, 43);
            this.btnInsPeriodo.Name = "btnInsPeriodo";
            this.btnInsPeriodo.Size = new System.Drawing.Size(214, 23);
            this.btnInsPeriodo.TabIndex = 6;
            this.btnInsPeriodo.Text = "Inserisci";
            this.btnInsPeriodo.UseVisualStyleBackColor = true;
            this.btnInsPeriodo.Click += new System.EventHandler(this.btnInsPeriodo_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(56, 17);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(164, 20);
            this.txtPeriodo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Stringa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsCitta);
            this.groupBox4.Controls.Add(this.txtCitta);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(281, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 75);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Città";
            // 
            // btnInsCitta
            // 
            this.btnInsCitta.Location = new System.Drawing.Point(6, 43);
            this.btnInsCitta.Name = "btnInsCitta";
            this.btnInsCitta.Size = new System.Drawing.Size(214, 23);
            this.btnInsCitta.TabIndex = 6;
            this.btnInsCitta.Text = "Inserisci";
            this.btnInsCitta.UseVisualStyleBackColor = true;
            this.btnInsCitta.Click += new System.EventHandler(this.btnInsCitta_Click);
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(56, 17);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(164, 20);
            this.txtCitta.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stringa";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAbbonato);
            this.groupBox5.Controls.Add(this.cbPeriodo);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cbRivista);
            this.groupBox5.Controls.Add(this.dtpValidita);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(12, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 172);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Abbonamento";
            // 
            // cbAbbonato
            // 
            this.cbAbbonato.FormattingEnabled = true;
            this.cbAbbonato.Location = new System.Drawing.Point(93, 17);
            this.cbAbbonato.Name = "cbAbbonato";
            this.cbAbbonato.Size = new System.Drawing.Size(164, 21);
            this.cbAbbonato.TabIndex = 12;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(93, 44);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(164, 21);
            this.cbPeriodo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rivista";
            // 
            // cbRivista
            // 
            this.cbRivista.FormattingEnabled = true;
            this.cbRivista.Location = new System.Drawing.Point(93, 93);
            this.cbRivista.Name = "cbRivista";
            this.cbRivista.Size = new System.Drawing.Size(164, 21);
            this.cbRivista.TabIndex = 8;
            // 
            // dtpValidita
            // 
            this.dtpValidita.Location = new System.Drawing.Point(93, 67);
            this.dtpValidita.Name = "dtpValidita";
            this.dtpValidita.Size = new System.Drawing.Size(164, 20);
            this.dtpValidita.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inserisci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Data validità";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Periodo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Abbonato";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 78);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update ComboBox";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery1
            // 
            this.btnQuery1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuery1.Location = new System.Drawing.Point(281, 263);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(225, 28);
            this.btnQuery1.TabIndex = 13;
            this.btnQuery1.Text = "Abbonamenti annuali";
            this.btnQuery1.UseVisualStyleBackColor = false;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(281, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Numero abbonamenti (Personali)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(281, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Numero abbonamenti (Giornale)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(281, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "Numero abbonati( min 5000)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(282, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 28);
            this.button5.TabIndex = 17;
            this.button5.Text = "Senza abbonati (Giornali)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(281, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(225, 28);
            this.button6.TabIndex = 18;
            this.button6.Text = "Numero abbonati (Città)";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 509);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPrezo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Periodo;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsRivista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbCitta;
        private System.Windows.Forms.DateTimePicker dtpNascita;
        private System.Windows.Forms.Button btnInsPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsPeriodo;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInsCitta;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbAbbonato;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRivista;
        private System.Windows.Forms.DateTimePicker dtpValidita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

