using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOR_Application
{
    public partial class frmUnosZaposlenika : Form
    {
        Zaposlenik zaposlenik;

        public frmUnosZaposlenika()
        {
            zaposlenik = new Zaposlenik();


            InitializeComponent();

            this.txtAdresa.Text = "";
            this.txtIme.Text = "";
            this.txtPrezime.Text = "";
            this.txtRadnoMjesto.Text = "";



        }

        private void frmUnosZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Evidencija_o_zaposlenima' table. You can move, or remove it, as needed.
            this.evidencija_o_zaposlenimaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Evidencija_o_zaposlenima);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            zaposlenik.Radno_mjesto = txtRadnoMjesto.Text;
            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime = txtPrezime.Text;
            zaposlenik.Adresa = txtAdresa.Text;


            zaposlenik.DodajZaposlenika();

            this.txtAdresa.Text = "";
            this.txtIme.Text = "";
            this.txtPrezime.Text = "";
            this.txtRadnoMjesto.Text = "";

            this.evidencija_o_zaposlenimaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Evidencija_o_zaposlenima);


        
        }

        private void btnIzadi_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
