﻿namespace Kreiranje_narudžbe
{
    partial class frmKreiranjeNarudzbeGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKreiranjeNarudzbeGlavna));
            this.msIzbornikHelp = new System.Windows.Forms.MenuStrip();
            this.msPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.msUputeZaKoristenje = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.croatianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdaberiJelo = new System.Windows.Forms.Button();
            this.btnOdaberiPice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaruceneStavke = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNaruceneStavke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiStavke = new System.Windows.Forms.Button();
            this.lblZahtjev = new System.Windows.Forms.Label();
            this.txtZahtjevi_naruzdbe = new System.Windows.Forms.TextBox();
            this.lblStol = new System.Windows.Forms.Label();
            this.lblPosluzuje = new System.Windows.Forms.Label();
            this.lblBrojStola = new System.Windows.Forms.Label();
            this.vrijeme = new System.Windows.Forms.DateTimePicker();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaruceneStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // msIzbornikHelp
            // 
            this.msIzbornikHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.msPomoc});
            this.msIzbornikHelp.Location = new System.Drawing.Point(0, 0);
            this.msIzbornikHelp.Name = "msIzbornikHelp";
            this.msIzbornikHelp.Size = new System.Drawing.Size(784, 24);
            this.msIzbornikHelp.TabIndex = 0;
            this.msIzbornikHelp.Text = "menuStrip1";
            // 
            // msPomoc
            // 
            this.msPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUputeZaKoristenje});
            this.msPomoc.Name = "msPomoc";
            this.msPomoc.Size = new System.Drawing.Size(53, 20);
            this.msPomoc.Text = "Pomoć";
            // 
            // msUputeZaKoristenje
            // 
            this.msUputeZaKoristenje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.croatianToolStripMenuItem});
            this.msUputeZaKoristenje.Name = "msUputeZaKoristenje";
            this.msUputeZaKoristenje.Size = new System.Drawing.Size(174, 22);
            this.msUputeZaKoristenje.Text = "Upute za korištenje";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // croatianToolStripMenuItem
            // 
            this.croatianToolStripMenuItem.Name = "croatianToolStripMenuItem";
            this.croatianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.croatianToolStripMenuItem.Text = "Croatian";
            this.croatianToolStripMenuItem.Click += new System.EventHandler(this.croatianToolStripMenuItem_Click);
            // 
            // btnOdaberiJelo
            // 
            this.btnOdaberiJelo.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiJelo.Location = new System.Drawing.Point(214, 144);
            this.btnOdaberiJelo.Name = "btnOdaberiJelo";
            this.btnOdaberiJelo.Size = new System.Drawing.Size(156, 51);
            this.btnOdaberiJelo.TabIndex = 2;
            this.btnOdaberiJelo.Text = "Odaberi jelo";
            this.btnOdaberiJelo.UseVisualStyleBackColor = true;
            this.btnOdaberiJelo.Click += new System.EventHandler(this.btnOdaberiJelo_Click);
            // 
            // btnOdaberiPice
            // 
            this.btnOdaberiPice.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiPice.Location = new System.Drawing.Point(214, 201);
            this.btnOdaberiPice.Name = "btnOdaberiPice";
            this.btnOdaberiPice.Size = new System.Drawing.Size(156, 52);
            this.btnOdaberiPice.TabIndex = 3;
            this.btnOdaberiPice.Text = "Odaberi piće";
            this.btnOdaberiPice.UseVisualStyleBackColor = true;
            this.btnOdaberiPice.Click += new System.EventHandler(this.btnOdaberiPice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaruceneStavke
            // 
            this.lblNaruceneStavke.AutoSize = true;
            this.lblNaruceneStavke.BackColor = System.Drawing.Color.Transparent;
            this.lblNaruceneStavke.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaruceneStavke.ForeColor = System.Drawing.Color.White;
            this.lblNaruceneStavke.Location = new System.Drawing.Point(452, 61);
            this.lblNaruceneStavke.Name = "lblNaruceneStavke";
            this.lblNaruceneStavke.Size = new System.Drawing.Size(227, 38);
            this.lblNaruceneStavke.TabIndex = 6;
            this.lblNaruceneStavke.Text = "Naručene stavke";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNaruci.ForeColor = System.Drawing.Color.Maroon;
            this.btnNaruci.Location = new System.Drawing.Point(390, 480);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(207, 60);
            this.btnNaruci.TabIndex = 7;
            this.btnNaruci.Text = "NARUČI";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.ForeColor = System.Drawing.Color.White;
            this.lblUkupno.Location = new System.Drawing.Point(606, 497);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(70, 33);
            this.lblUkupno.TabIndex = 8;
            this.lblUkupno.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Restoran Victoria";
            // 
            // dgvNaruceneStavke
            // 
            this.dgvNaruceneStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaruceneStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNaruceneStavke.Location = new System.Drawing.Point(390, 102);
            this.dgvNaruceneStavke.Name = "dgvNaruceneStavke";
            this.dgvNaruceneStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNaruceneStavke.Size = new System.Drawing.Size(366, 372);
            this.dgvNaruceneStavke.TabIndex = 10;
            this.dgvNaruceneStavke.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvNaruceneStavke_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Naziv";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cijena";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = " Količina";
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // btnObrisiStavke
            // 
            this.btnObrisiStavke.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiStavke.Location = new System.Drawing.Point(214, 259);
            this.btnObrisiStavke.Name = "btnObrisiStavke";
            this.btnObrisiStavke.Size = new System.Drawing.Size(156, 52);
            this.btnObrisiStavke.TabIndex = 12;
            this.btnObrisiStavke.Text = "Obriši stavku ";
            this.btnObrisiStavke.UseVisualStyleBackColor = true;
            this.btnObrisiStavke.Click += new System.EventHandler(this.btnObrisiStavke_Click);
            // 
            // lblZahtjev
            // 
            this.lblZahtjev.AutoSize = true;
            this.lblZahtjev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZahtjev.ForeColor = System.Drawing.Color.White;
            this.lblZahtjev.Location = new System.Drawing.Point(235, 329);
            this.lblZahtjev.Name = "lblZahtjev";
            this.lblZahtjev.Size = new System.Drawing.Size(111, 17);
            this.lblZahtjev.TabIndex = 25;
            this.lblZahtjev.Text = "Zahtjevi narudzbe";
            // 
            // txtZahtjevi_naruzdbe
            // 
            this.txtZahtjevi_naruzdbe.Location = new System.Drawing.Point(214, 349);
            this.txtZahtjevi_naruzdbe.Multiline = true;
            this.txtZahtjevi_naruzdbe.Name = "txtZahtjevi_naruzdbe";
            this.txtZahtjevi_naruzdbe.Size = new System.Drawing.Size(156, 125);
            this.txtZahtjevi_naruzdbe.TabIndex = 24;
            // 
            // lblStol
            // 
            this.lblStol.AutoSize = true;
            this.lblStol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStol.ForeColor = System.Drawing.Color.White;
            this.lblStol.Location = new System.Drawing.Point(148, 513);
            this.lblStol.Name = "lblStol";
            this.lblStol.Size = new System.Drawing.Size(0, 17);
            this.lblStol.TabIndex = 23;
            // 
            // lblPosluzuje
            // 
            this.lblPosluzuje.AutoSize = true;
            this.lblPosluzuje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPosluzuje.ForeColor = System.Drawing.Color.White;
            this.lblPosluzuje.Location = new System.Drawing.Point(3, 535);
            this.lblPosluzuje.Name = "lblPosluzuje";
            this.lblPosluzuje.Size = new System.Drawing.Size(145, 17);
            this.lblPosluzuje.TabIndex = 21;
            this.lblPosluzuje.Text = "Posluzuje vas konobar: ";
            // 
            // lblBrojStola
            // 
            this.lblBrojStola.AutoSize = true;
            this.lblBrojStola.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojStola.ForeColor = System.Drawing.Color.White;
            this.lblBrojStola.Location = new System.Drawing.Point(16, 513);
            this.lblBrojStola.Name = "lblBrojStola";
            this.lblBrojStola.Size = new System.Drawing.Size(132, 17);
            this.lblBrojStola.TabIndex = 20;
            this.lblBrojStola.Text = "Sjedite na stolu broj: ";
            // 
            // vrijeme
            // 
            this.vrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vrijeme.Location = new System.Drawing.Point(597, 4);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.Size = new System.Drawing.Size(66, 20);
            this.vrijeme.TabIndex = 27;
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(669, 4);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(115, 20);
            this.datum.TabIndex = 26;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.White;
            this.lblZaposlenik.Location = new System.Drawing.Point(148, 535);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(0, 17);
            this.lblZaposlenik.TabIndex = 28;
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // frmKreiranjeNarudzbeGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.vrijeme);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.lblZahtjev);
            this.Controls.Add(this.txtZahtjevi_naruzdbe);
            this.Controls.Add(this.lblStol);
            this.Controls.Add(this.lblPosluzuje);
            this.Controls.Add(this.lblBrojStola);
            this.Controls.Add(this.btnObrisiStavke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNaruceneStavke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.lblNaruceneStavke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdaberiPice);
            this.Controls.Add(this.btnOdaberiJelo);
            this.Controls.Add(this.msIzbornikHelp);
            this.MainMenuStrip = this.msIzbornikHelp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKreiranjeNarudzbeGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje narudžbe";
            this.Load += new System.EventHandler(this.frmKreiranjeNarudzbeGlavna_Load);
            this.msIzbornikHelp.ResumeLayout(false);
            this.msIzbornikHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaruceneStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzbornikHelp;
        private System.Windows.Forms.ToolStripMenuItem msPomoc;
        private System.Windows.Forms.ToolStripMenuItem msUputeZaKoristenje;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem croatianToolStripMenuItem;
        private System.Windows.Forms.Button btnOdaberiJelo;
        private System.Windows.Forms.Button btnOdaberiPice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaruceneStavke;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvNaruceneStavke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiStavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblZahtjev;
        private System.Windows.Forms.TextBox txtZahtjevi_naruzdbe;
        private System.Windows.Forms.Label lblStol;
        private System.Windows.Forms.Label lblPosluzuje;
        private System.Windows.Forms.Label lblBrojStola;
        private System.Windows.Forms.DateTimePicker vrijeme;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

