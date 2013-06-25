namespace FOR_Application
{
    partial class frmUnosZaposlenika
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
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label radno_mjestoLabel;
            this.btnIzadi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvUnosZaposlenika = new System.Windows.Forms.DataGridView();
            this.iDzaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnomjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijaOZaposlenimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.evidencija_o_zaposlenimaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Evidencija_o_zaposlenimaTableAdapter();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            adresaLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnosZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaOZaposlenimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            adresaLabel.Location = new System.Drawing.Point(33, 121);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 27;
            adresaLabel.Text = "Adresa:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            prezimeLabel.Location = new System.Drawing.Point(29, 95);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 25;
            prezimeLabel.Text = "Prezime:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            imeLabel.Location = new System.Drawing.Point(49, 59);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 23;
            imeLabel.Text = "Ime:";
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            radno_mjestoLabel.Location = new System.Drawing.Point(1, 33);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(75, 13);
            radno_mjestoLabel.TabIndex = 22;
            radno_mjestoLabel.Text = "Radno mjesto:";
            // 
            // btnIzadi
            // 
            this.btnIzadi.Location = new System.Drawing.Point(328, 486);
            this.btnIzadi.Name = "btnIzadi";
            this.btnIzadi.Size = new System.Drawing.Size(149, 55);
            this.btnIzadi.TabIndex = 0;
            this.btnIzadi.Text = "Nazad";
            this.btnIzadi.UseVisualStyleBackColor = true;
            this.btnIzadi.Click += new System.EventHandler(this.btnIzadi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(41, 486);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(141, 55);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Spremi zaposlenika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvUnosZaposlenika
            // 
            this.dgvUnosZaposlenika.AutoGenerateColumns = false;
            this.dgvUnosZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnosZaposlenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzaposlenikaDataGridViewTextBoxColumn,
            this.radnomjestoDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dgvUnosZaposlenika.DataSource = this.evidencijaOZaposlenimaBindingSource;
            this.dgvUnosZaposlenika.Location = new System.Drawing.Point(32, 180);
            this.dgvUnosZaposlenika.Name = "dgvUnosZaposlenika";
            this.dgvUnosZaposlenika.Size = new System.Drawing.Size(445, 289);
            this.dgvUnosZaposlenika.TabIndex = 2;
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
            this.radnomjestoDataGridViewTextBoxColumn.HeaderText = "Radno_mjesto";
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
            // 
            // evidencijaOZaposlenimaBindingSource
            // 
            this.evidencijaOZaposlenimaBindingSource.DataMember = "Evidencija o zaposlenima";
            this.evidencijaOZaposlenimaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
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
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(82, 118);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(122, 20);
            this.txtAdresa.TabIndex = 29;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(82, 88);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(122, 20);
            this.txtPrezime.TabIndex = 28;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(82, 56);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 26;
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.Location = new System.Drawing.Point(82, 30);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.Size = new System.Drawing.Size(100, 20);
            this.txtRadnoMjesto.TabIndex = 24;
            // 
            // frmUnosZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(496, 569);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.dgvUnosZaposlenika);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzadi);
            this.Name = "frmUnosZaposlenika";
            this.Text = "Unos zaposlenika";
            this.Load += new System.EventHandler(this.frmUnosZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnosZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaOZaposlenimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzadi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvUnosZaposlenika;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource evidencijaOZaposlenimaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Evidencija_o_zaposlenimaTableAdapter evidencija_o_zaposlenimaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnomjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
    }
}