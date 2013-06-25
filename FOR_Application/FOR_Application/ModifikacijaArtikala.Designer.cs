namespace FOR_Application
{
    partial class frmModifikacijaArtikala
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label opis_artiklaLabel;
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label jedinica_mjereLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifikacijaArtikala));
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.dgvListaArtikala = new System.Windows.Forms.DataGridView();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.lblpopis = new System.Windows.Forms.Label();
            this.artikliTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.txtOpisArtikla = new System.Windows.Forms.TextBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.txtJedinicaMjere = new System.Windows.Forms.TextBox();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            this.btnSpremimodif = new System.Windows.Forms.Button();
            opis_artiklaLabel = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            jedinica_mjereLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // opis_artiklaLabel
            // 
            opis_artiklaLabel.AutoSize = true;
            opis_artiklaLabel.ForeColor = System.Drawing.Color.White;
            opis_artiklaLabel.Location = new System.Drawing.Point(34, 111);
            opis_artiklaLabel.Name = "opis_artiklaLabel";
            opis_artiklaLabel.Size = new System.Drawing.Size(62, 13);
            opis_artiklaLabel.TabIndex = 10;
            opis_artiklaLabel.Text = "Opis artikla:";
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.ForeColor = System.Drawing.Color.White;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(216, 137);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 11;
            jedinicna_cijenaLabel.Text = "Jedinicna cijena:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.ForeColor = System.Drawing.Color.White;
            nazivLabel.Location = new System.Drawing.Point(265, 111);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 12;
            nazivLabel.Text = "Naziv:";
            // 
            // jedinica_mjereLabel
            // 
            jedinica_mjereLabel.AutoSize = true;
            jedinica_mjereLabel.ForeColor = System.Drawing.Color.White;
            jedinica_mjereLabel.Location = new System.Drawing.Point(19, 137);
            jedinica_mjereLabel.Name = "jedinica_mjereLabel";
            jedinica_mjereLabel.Size = new System.Drawing.Size(77, 13);
            jedinica_mjereLabel.TabIndex = 13;
            jedinica_mjereLabel.Text = "Jedinica mjere:";
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Maroon;
            this.btnDodajArtikl.Location = new System.Drawing.Point(37, 24);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(136, 40);
            this.btnDodajArtikl.TabIndex = 4;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // dgvListaArtikala
            // 
            this.dgvListaArtikala.AllowUserToAddRows = false;
            this.dgvListaArtikala.AllowUserToDeleteRows = false;
            this.dgvListaArtikala.AutoGenerateColumns = false;
            this.dgvListaArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArtikala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn});
            this.dgvListaArtikala.DataSource = this.artikliBindingSource;
            this.dgvListaArtikala.Location = new System.Drawing.Point(9, 215);
            this.dgvListaArtikala.Name = "dgvListaArtikala";
            this.dgvListaArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArtikala.Size = new System.Drawing.Size(543, 267);
            this.dgvListaArtikala.TabIndex = 9;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // jedinicnacijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnacijenaDataGridViewTextBoxColumn.DataPropertyName = "Jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.Name = "jedinicnacijenaDataGridViewTextBoxColumn";
            // 
            // opisartiklaDataGridViewTextBoxColumn
            // 
            this.opisartiklaDataGridViewTextBoxColumn.DataPropertyName = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisartiklaDataGridViewTextBoxColumn.Name = "opisartiklaDataGridViewTextBoxColumn";
            // 
            // jedinicamjereDataGridViewTextBoxColumn
            // 
            this.jedinicamjereDataGridViewTextBoxColumn.DataPropertyName = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = "Jedinica mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.Name = "jedinicamjereDataGridViewTextBoxColumn";
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblpopis
            // 
            this.lblpopis.AutoSize = true;
            this.lblpopis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpopis.ForeColor = System.Drawing.Color.White;
            this.lblpopis.Location = new System.Drawing.Point(203, 185);
            this.lblpopis.Name = "lblpopis";
            this.lblpopis.Size = new System.Drawing.Size(81, 17);
            this.lblpopis.TabIndex = 10;
            this.lblpopis.Text = "Baza artikala";
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = this.artikliTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Evidencija_o_zaposlenimaTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.Popis_stolovaTableAdapter = null;
            this.tableAdapterManager.Povratna_informacijaTableAdapter = null;
            this.tableAdapterManager.Racun_za_gostaTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtOpisArtikla
            // 
            this.txtOpisArtikla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Opis_artikla", true));
            this.txtOpisArtikla.Location = new System.Drawing.Point(102, 108);
            this.txtOpisArtikla.Name = "txtOpisArtikla";
            this.txtOpisArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtOpisArtikla.TabIndex = 11;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Jedinicna_cijena", true));
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(308, 134);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(100, 20);
            this.txtJedinicnaCijena.TabIndex = 12;
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Naziv", true));
            this.txtNazivArtikla.Location = new System.Drawing.Point(308, 108);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtNazivArtikla.TabIndex = 13;
            // 
            // txtJedinicaMjere
            // 
            this.txtJedinicaMjere.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Jedinica_mjere", true));
            this.txtJedinicaMjere.Location = new System.Drawing.Point(102, 134);
            this.txtJedinicaMjere.Name = "txtJedinicaMjere";
            this.txtJedinicaMjere.Size = new System.Drawing.Size(100, 20);
            this.txtJedinicaMjere.TabIndex = 14;
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnObrisiArtikl.ForeColor = System.Drawing.Color.Maroon;
            this.btnObrisiArtikl.Location = new System.Drawing.Point(219, 24);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(136, 42);
            this.btnObrisiArtikl.TabIndex = 15;
            this.btnObrisiArtikl.Text = "Obriši artikl";
            this.btnObrisiArtikl.UseVisualStyleBackColor = true;
            this.btnObrisiArtikl.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpremimodif
            // 
            this.btnSpremimodif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremimodif.ForeColor = System.Drawing.Color.Maroon;
            this.btnSpremimodif.Location = new System.Drawing.Point(381, 24);
            this.btnSpremimodif.Name = "btnSpremimodif";
            this.btnSpremimodif.Size = new System.Drawing.Size(137, 42);
            this.btnSpremimodif.TabIndex = 16;
            this.btnSpremimodif.Text = "Spremi modifikaciju";
            this.btnSpremimodif.UseVisualStyleBackColor = true;
            this.btnSpremimodif.Click += new System.EventHandler(this.btnSpremimodif_Click);
            // 
            // frmModifikacijaArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(572, 502);
            this.Controls.Add(this.btnSpremimodif);
            this.Controls.Add(this.btnObrisiArtikl);
            this.Controls.Add(jedinica_mjereLabel);
            this.Controls.Add(this.txtJedinicaMjere);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.txtNazivArtikla);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(opis_artiklaLabel);
            this.Controls.Add(this.txtOpisArtikla);
            this.Controls.Add(this.lblpopis);
            this.Controls.Add(this.dgvListaArtikala);
            this.Controls.Add(this.btnDodajArtikl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModifikacijaArtikala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifikacija artikala";
            this.Load += new System.EventHandler(this.frmModifikacijaArtikala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.DataGridView dgvListaArtikala;
        private System.Windows.Forms.Label lblpopis;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
        private pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtOpisArtikla;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.TextBox txtJedinicaMjere;
        private System.Windows.Forms.Button btnObrisiArtikl;
        private System.Windows.Forms.Button btnSpremimodif;
    }
}