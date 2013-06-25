namespace FOR_Application
{
    partial class frmEvidencija
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
            System.Windows.Forms.Label radno_mjestoLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvidencija));
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.evidencija_o_zaposlenimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.evidencija_o_zaposlenimaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Evidencija_o_zaposlenimaTableAdapter();
            this.tableAdapterManager = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.dgvEvidencija = new System.Windows.Forms.DataGridView();
            this.iDzaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnomjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnObrisiZaposlenik = new System.Windows.Forms.Button();
            this.btnModifikacijaZaposlenika = new System.Windows.Forms.Button();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.evidencija_o_zaposlenimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).BeginInit();
            this.SuspendLayout();
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            radno_mjestoLabel.Location = new System.Drawing.Point(12, 12);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(75, 13);
            radno_mjestoLabel.TabIndex = 17;
            radno_mjestoLabel.Text = "Radno mjesto:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            imeLabel.Location = new System.Drawing.Point(60, 38);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 18;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            prezimeLabel.Location = new System.Drawing.Point(40, 74);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 19;
            prezimeLabel.Text = "Prezime:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            adresaLabel.Location = new System.Drawing.Point(44, 100);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 20;
            adresaLabel.Text = "Adresa:";
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZaposlenika.ForeColor = System.Drawing.Color.Maroon;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(419, 12);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(136, 43);
            this.btnDodajZaposlenika.TabIndex = 16;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // evidencija_o_zaposlenimaBindingSource
            // 
            this.evidencija_o_zaposlenimaBindingSource.DataMember = "Evidencija o zaposlenima";
            this.evidencija_o_zaposlenimaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evidencija_o_zaposlenimaTableAdapter
            // 
            this.evidencija_o_zaposlenimaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Evidencija_o_zaposlenimaTableAdapter = this.evidencija_o_zaposlenimaTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.Popis_stolovaTableAdapter = null;
            this.tableAdapterManager.Povratna_informacijaTableAdapter = null;
            this.tableAdapterManager.Racun_za_gostaTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvEvidencija
            // 
            this.dgvEvidencija.AllowUserToAddRows = false;
            this.dgvEvidencija.AllowUserToDeleteRows = false;
            this.dgvEvidencija.AutoGenerateColumns = false;
            this.dgvEvidencija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzaposlenikaDataGridViewTextBoxColumn,
            this.radnomjestoDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dgvEvidencija.DataSource = this.evidencija_o_zaposlenimaBindingSource;
            this.dgvEvidencija.Location = new System.Drawing.Point(15, 141);
            this.dgvEvidencija.Name = "dgvEvidencija";
            this.dgvEvidencija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvidencija.Size = new System.Drawing.Size(543, 278);
            this.dgvEvidencija.TabIndex = 17;
            // 
            // iDzaposlenikaDataGridViewTextBoxColumn
            // 
            this.iDzaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "ID_zaposlenika";
            this.iDzaposlenikaDataGridViewTextBoxColumn.HeaderText = "ID_zaposlenika";
            this.iDzaposlenikaDataGridViewTextBoxColumn.Name = "iDzaposlenikaDataGridViewTextBoxColumn";
            this.iDzaposlenikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDzaposlenikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnomjestoDataGridViewTextBoxColumn
            // 
            this.radnomjestoDataGridViewTextBoxColumn.DataPropertyName = "Radno_mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.Name = "radnomjestoDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 200;
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidencija_o_zaposlenimaBindingSource, "Radno_mjesto", true));
            this.txtRadnoMjesto.Location = new System.Drawing.Point(93, 9);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.Size = new System.Drawing.Size(100, 20);
            this.txtRadnoMjesto.TabIndex = 18;
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidencija_o_zaposlenimaBindingSource, "Ime", true));
            this.txtIme.Location = new System.Drawing.Point(93, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 19;
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidencija_o_zaposlenimaBindingSource, "Prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(93, 67);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(122, 20);
            this.txtPrezime.TabIndex = 20;
            // 
            // txtAdresa
            // 
            this.txtAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidencija_o_zaposlenimaBindingSource, "Adresa", true));
            this.txtAdresa.Location = new System.Drawing.Point(93, 97);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(122, 20);
            this.txtAdresa.TabIndex = 21;
            // 
            // btnObrisiZaposlenik
            // 
            this.btnObrisiZaposlenik.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnObrisiZaposlenik.ForeColor = System.Drawing.Color.Maroon;
            this.btnObrisiZaposlenik.Location = new System.Drawing.Point(419, 71);
            this.btnObrisiZaposlenik.Name = "btnObrisiZaposlenik";
            this.btnObrisiZaposlenik.Size = new System.Drawing.Size(136, 43);
            this.btnObrisiZaposlenik.TabIndex = 22;
            this.btnObrisiZaposlenik.Text = "Obriši zapsolenika";
            this.btnObrisiZaposlenik.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenik.Click += new System.EventHandler(this.btnObrisiZaposlenik_Click);
            // 
            // btnModifikacijaZaposlenika
            // 
            this.btnModifikacijaZaposlenika.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifikacijaZaposlenika.ForeColor = System.Drawing.Color.Maroon;
            this.btnModifikacijaZaposlenika.Location = new System.Drawing.Point(248, 12);
            this.btnModifikacijaZaposlenika.Name = "btnModifikacijaZaposlenika";
            this.btnModifikacijaZaposlenika.Size = new System.Drawing.Size(136, 43);
            this.btnModifikacijaZaposlenika.TabIndex = 23;
            this.btnModifikacijaZaposlenika.Text = "Modificiraj zaposlenika";
            this.btnModifikacijaZaposlenika.UseVisualStyleBackColor = true;
            this.btnModifikacijaZaposlenika.Click += new System.EventHandler(this.btnModifikacijaZaposlenika_Click);
            // 
            // frmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.btnModifikacijaZaposlenika);
            this.Controls.Add(this.btnObrisiZaposlenik);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.dgvEvidencija);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvidencija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija zaposlenih";
            this.Load += new System.EventHandler(this.frmEvidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evidencija_o_zaposlenimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZaposlenika;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource evidencija_o_zaposlenimaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Evidencija_o_zaposlenimaTableAdapter evidencija_o_zaposlenimaTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvEvidencija;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnObrisiZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnomjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModifikacijaZaposlenika;
    }
}