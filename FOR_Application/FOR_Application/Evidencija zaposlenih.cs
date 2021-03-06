﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper;

namespace FOR_Application
{
    public partial class frmEvidencija : Form
    {
        Zaposlenik zaposlenik;
        public frmEvidencija()
        {
            InitializeComponent();
            zaposlenik = new Zaposlenik();
            this.txtAdresa.Text = "";
            this.txtIme.Text = "";
            this.txtPrezime.Text = "";
            this.txtRadnoMjesto.Text = "";

        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenik.Radno_mjesto = txtRadnoMjesto.Text;
            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime = txtPrezime.Text;
            zaposlenik.Adresa = txtAdresa.Text;
            zaposlenik.DodajZaposlenika();

            this.evidencija_o_zaposlenimaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Evidencija_o_zaposlenima);


        }

        private void frmEvidencija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Evidencija_o_zaposlenima' table. You can move, or remove it, as needed.
            this.evidencija_o_zaposlenimaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Evidencija_o_zaposlenima);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvEvidencija.Rows.RemoveAt(dgvEvidencija.CurrentRow.Index);
            this.Validate();
            this.evidencija_o_zaposlenimaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pi2013FastOrderdbDataSet);
        }


    }
}
