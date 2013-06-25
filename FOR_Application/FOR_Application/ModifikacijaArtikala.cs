using System;
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
    public partial class frmModifikacijaArtikala : Form
    {
        Artikli artikli;

        public frmModifikacijaArtikala()
        {
            InitializeComponent();
            artikli = new Artikli();
            this.txtJedinicaMjere.Text = "";
            this.txtJedinicnaCijena.Text = "";
            this.txtNazivArtikla.Text = "";
            this.txtOpisArtikla.Text = "";


        }


        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            frmDodajArtikl dodaj_artikl = new frmDodajArtikl();
            dodaj_artikl.Show();

        }

        private void frmModifikacijaArtikala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListaArtikala.Rows.RemoveAt(dgvListaArtikala.CurrentRow.Index);
            this.Validate();
            this.artikliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pi2013FastOrderdbDataSet);
        }

        private void btnSpremimodif_Click(object sender, EventArgs e)
        {
            bazaRad.Instance.Query("update [Artikli] set Naziv='" + txtNazivArtikla.Text + "', Jedinicna_cijena=" + Convert.ToDouble(txtJedinicnaCijena.Text) + ", Opis_artikla='" + txtOpisArtikla.Text + "', Jedinica_mjere = '" + txtJedinicaMjere.Text + "' where ID_artikla=" + Convert.ToInt32(this.dgvListaArtikala.SelectedRows[0].Index) + ";");
            this.Validate();
            this.artikliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pi2013FastOrderdbDataSet);
        }



 
    }
}