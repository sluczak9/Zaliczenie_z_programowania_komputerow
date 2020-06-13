namespace Sebastian_Luczak
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownKwota = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIlosc = new System.Windows.Forms.NumericUpDown();
            this.radioButtonTak = new System.Windows.Forms.RadioButton();
            this.radioButtonNie = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonNaliczonyRabat = new System.Windows.Forms.Button();
            this.buttonNajdrozszaPozycjaZRabatem = new System.Windows.Forms.Button();
            this.buttonCalkowitaBezRab = new System.Windows.Forms.Button();
            this.buttonCalkowitaZRabatem = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKwota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kreator zamówień";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa produktu";
            // 
            // numericUpDownKwota
            // 
            this.numericUpDownKwota.DecimalPlaces = 2;
            this.numericUpDownKwota.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKwota.Location = new System.Drawing.Point(272, 102);
            this.numericUpDownKwota.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKwota.Name = "numericUpDownKwota";
            this.numericUpDownKwota.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownKwota.TabIndex = 3;
            // 
            // numericUpDownIlosc
            // 
            this.numericUpDownIlosc.Location = new System.Drawing.Point(460, 102);
            this.numericUpDownIlosc.Name = "numericUpDownIlosc";
            this.numericUpDownIlosc.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownIlosc.TabIndex = 4;
            // 
            // radioButtonTak
            // 
            this.radioButtonTak.AutoSize = true;
            this.radioButtonTak.Location = new System.Drawing.Point(668, 75);
            this.radioButtonTak.Name = "radioButtonTak";
            this.radioButtonTak.Size = new System.Drawing.Size(56, 24);
            this.radioButtonTak.TabIndex = 5;
            this.radioButtonTak.TabStop = true;
            this.radioButtonTak.Text = "tak";
            this.radioButtonTak.UseVisualStyleBackColor = true;
            // 
            // radioButtonNie
            // 
            this.radioButtonNie.AutoSize = true;
            this.radioButtonNie.Location = new System.Drawing.Point(668, 117);
            this.radioButtonNie.Name = "radioButtonNie";
            this.radioButtonNie.Size = new System.Drawing.Size(57, 24);
            this.radioButtonNie.TabIndex = 6;
            this.radioButtonNie.TabStop = true;
            this.radioButtonNie.Text = "Nie";
            this.radioButtonNie.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rabat 10%";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(27, 148);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(784, 35);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "Dodaj produkt do zamówienia";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(27, 189);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(784, 35);
            this.buttonUsun.TabIndex = 9;
            this.buttonUsun.Text = "Usuń zaznaczone zamówienie";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(33, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 284);
            this.listBox1.TabIndex = 10;
            // 
            // buttonNaliczonyRabat
            // 
            this.buttonNaliczonyRabat.Location = new System.Drawing.Point(406, 248);
            this.buttonNaliczonyRabat.Name = "buttonNaliczonyRabat";
            this.buttonNaliczonyRabat.Size = new System.Drawing.Size(404, 52);
            this.buttonNaliczonyRabat.TabIndex = 11;
            this.buttonNaliczonyRabat.Text = "Naliczony Rabat";
            this.buttonNaliczonyRabat.UseVisualStyleBackColor = true;
            this.buttonNaliczonyRabat.Click += new System.EventHandler(this.buttonNaliczRabat_Click);
            // 
            // buttonNajdrozszaPozycjaZRabatem
            // 
            this.buttonNajdrozszaPozycjaZRabatem.Location = new System.Drawing.Point(407, 306);
            this.buttonNajdrozszaPozycjaZRabatem.Name = "buttonNajdrozszaPozycjaZRabatem";
            this.buttonNajdrozszaPozycjaZRabatem.Size = new System.Drawing.Size(404, 52);
            this.buttonNajdrozszaPozycjaZRabatem.TabIndex = 12;
            this.buttonNajdrozszaPozycjaZRabatem.Text = "Najdroższa pozycja zamówienia(po naliczeniu rabatu)";
            this.buttonNajdrozszaPozycjaZRabatem.UseVisualStyleBackColor = true;
            this.buttonNajdrozszaPozycjaZRabatem.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCalkowitaBezRab
            // 
            this.buttonCalkowitaBezRab.Location = new System.Drawing.Point(406, 364);
            this.buttonCalkowitaBezRab.Name = "buttonCalkowitaBezRab";
            this.buttonCalkowitaBezRab.Size = new System.Drawing.Size(404, 52);
            this.buttonCalkowitaBezRab.TabIndex = 13;
            this.buttonCalkowitaBezRab.Text = "Całkowita kwota zamówienia bez naliczonego rabatu";
            this.buttonCalkowitaBezRab.UseVisualStyleBackColor = true;
            this.buttonCalkowitaBezRab.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCalkowitaZRabatem
            // 
            this.buttonCalkowitaZRabatem.Location = new System.Drawing.Point(407, 422);
            this.buttonCalkowitaZRabatem.Name = "buttonCalkowitaZRabatem";
            this.buttonCalkowitaZRabatem.Size = new System.Drawing.Size(404, 52);
            this.buttonCalkowitaZRabatem.TabIndex = 14;
            this.buttonCalkowitaZRabatem.Text = "Całkowita kwota zamowienia po odjęciu rabatu ";
            this.buttonCalkowitaZRabatem.UseVisualStyleBackColor = true;
            this.buttonCalkowitaZRabatem.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(407, 482);
            this.buttonZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(404, 52);
            this.buttonZapisz.TabIndex = 16;
            this.buttonZapisz.Text = "Zapisz do pliku";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 609);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonCalkowitaZRabatem);
            this.Controls.Add(this.buttonCalkowitaBezRab);
            this.Controls.Add(this.buttonNajdrozszaPozycjaZRabatem);
            this.Controls.Add(this.buttonNaliczonyRabat);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonNie);
            this.Controls.Add(this.radioButtonTak);
            this.Controls.Add(this.numericUpDownIlosc);
            this.Controls.Add(this.numericUpDownKwota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sebastian Łuczak";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKwota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownKwota;
        private System.Windows.Forms.NumericUpDown numericUpDownIlosc;
        private System.Windows.Forms.RadioButton radioButtonTak;
        private System.Windows.Forms.RadioButton radioButtonNie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNaliczonyRabat;
        private System.Windows.Forms.Button buttonNajdrozszaPozycjaZRabatem;
        private System.Windows.Forms.Button buttonCalkowitaBezRab;
        private System.Windows.Forms.Button buttonCalkowitaZRabatem;
        private System.Windows.Forms.Button buttonZapisz;
    }
}

