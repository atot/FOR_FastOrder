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
    public partial class frmDodajArtikl : Form
    {
        Artikli artikli;

        
        public frmDodajArtikl()
        {
            InitializeComponent();
            artikli = new Artikli();
            this.txtJedinicaMjere.Text = "";
            this.txtJedinicnaCijena.Text = "";
            this.txtNazivArtikla.Text = "";
            this.txtOpisArtikla.Text = "";

        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            artikli.Jedinica_mjere = txtJedinicaMjere.Text;
            artikli.Jedinicna_cijena = Convert.ToInt32(txtJedinicnaCijena.Text);
            artikli.Naziv = txtNazivArtikla.Text;
            artikli.Opis_artikla = txtOpisArtikla.Text;

            artikli.DodajArtikl();
            


            this.txtJedinicaMjere.Text = "";
            this.txtJedinicnaCijena.Text = "";
            this.txtNazivArtikla.Text = "";
            this.txtOpisArtikla.Text = "";

            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);

            this.Validate();
            this.artikliBindingSource.EndEdit();
            this.artikliTableAdapter.Update(this.pi2013FastOrderdbDataSet.Artikli);

            

        
        }

        private void btnIzaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajArtikl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);

        }
    }
}
