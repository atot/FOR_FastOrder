namespace FOR_Application
{
    partial class frmDodajArtikl
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
            System.Windows.Forms.Label jedinica_mjereLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            System.Windows.Forms.Label opis_artiklaLabel;
            this.txtJedinicaMjere = new System.Windows.Forms.TextBox();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.txtOpisArtikla = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnIzaz = new System.Windows.Forms.Button();
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            jedinica_mjereLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            opis_artiklaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jedinica_mjereLabel
            // 
            jedinica_mjereLabel.AutoSize = true;
            jedinica_mjereLabel.ForeColor = System.Drawing.Color.White;
            jedinica_mjereLabel.Location = new System.Drawing.Point(34, 136);
            jedinica_mjereLabel.Name = "jedinica_mjereLabel";
            jedinica_mjereLabel.Size = new System.Drawing.Size(77, 13);
            jedinica_mjereLabel.TabIndex = 20;
            jedinica_mjereLabel.Text = "Jedinica mjere:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.ForeColor = System.Drawing.Color.White;
            nazivLabel.Location = new System.Drawing.Point(74, 15);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 18;
            nazivLabel.Text = "Naziv:";
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.ForeColor = System.Drawing.Color.White;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(25, 41);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 16;
            jedinicna_cijenaLabel.Text = "Jedinicna cijena:";
            // 
            // opis_artiklaLabel
            // 
            opis_artiklaLabel.AutoSize = true;
            opis_artiklaLabel.ForeColor = System.Drawing.Color.White;
            opis_artiklaLabel.Location = new System.Drawing.Point(49, 110);
            opis_artiklaLabel.Name = "opis_artiklaLabel";
            opis_artiklaLabel.Size = new System.Drawing.Size(62, 13);
            opis_artiklaLabel.TabIndex = 15;
            opis_artiklaLabel.Text = "Opis artikla:";
            // 
            // txtJedinicaMjere
            // 
            this.txtJedinicaMjere.Location = new System.Drawing.Point(117, 133);
            this.txtJedinicaMjere.Name = "txtJedinicaMjere";
            this.txtJedinicaMjere.Size = new System.Drawing.Size(100, 20);
            this.txtJedinicaMjere.TabIndex = 22;
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(117, 12);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtNazivArtikla.TabIndex = 21;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(117, 38);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(100, 20);
            this.txtJedinicnaCijena.TabIndex = 19;
            // 
            // txtOpisArtikla
            // 
            this.txtOpisArtikla.Location = new System.Drawing.Point(117, 107);
            this.txtOpisArtikla.Name = "txtOpisArtikla";
            this.txtOpisArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtOpisArtikla.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artikliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 244);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(234, 12);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(139, 67);
            this.btnDodajZaposlenika.TabIndex = 24;
            this.btnDodajZaposlenika.Text = "Dodaj artikl";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnIzaz
            // 
            this.btnIzaz.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzaz.Location = new System.Drawing.Point(234, 100);
            this.btnIzaz.Name = "btnIzaz";
            this.btnIzaz.Size = new System.Drawing.Size(139, 53);
            this.btnIzaz.TabIndex = 25;
            this.btnIzaz.Text = "Izlaz";
            this.btnIzaz.UseVisualStyleBackColor = true;
            this.btnIzaz.Click += new System.EventHandler(this.btnIzaz_Click);
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDartiklaDataGridViewTextBoxColumn.Visible = false;
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
            this.jedinicnacijenaDataGridViewTextBoxColumn.HeaderText = "Jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.Name = "jedinicnacijenaDataGridViewTextBoxColumn";
            // 
            // opisartiklaDataGridViewTextBoxColumn
            // 
            this.opisartiklaDataGridViewTextBoxColumn.DataPropertyName = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.HeaderText = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.Name = "opisartiklaDataGridViewTextBoxColumn";
            // 
            // jedinicamjereDataGridViewTextBoxColumn
            // 
            this.jedinicamjereDataGridViewTextBoxColumn.DataPropertyName = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.Name = "jedinicamjereDataGridViewTextBoxColumn";
            // 
            // frmDodajArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(500, 462);
            this.Controls.Add(this.btnIzaz);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(jedinica_mjereLabel);
            this.Controls.Add(this.txtJedinicaMjere);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.txtNazivArtikla);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(opis_artiklaLabel);
            this.Controls.Add(this.txtOpisArtikla);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmDodajArtikl";
            this.Text = "Dodaj artikl";
            this.Load += new System.EventHandler(this.frmDodajArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJedinicaMjere;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.TextBox txtOpisArtikla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnIzaz;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
    }
}