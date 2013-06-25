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
using System.Data.SqlClient;


namespace Kreiranje_narudžbe
{
    public partial class frmKreiranjeNarudzbeGlavna : Form
    {
        Narudzba narudzba;
        public frmKreiranjeNarudzbeGlavna()
        {
            InitializeComponent();
            
            narudzba = new Narudzba();
            int c = (int)bazaRad.Instance.DohvatiVrijednost("select ID_stola from [Popis stolova];");
            this.lblStol.Text = c.ToString();

            string zaposlenik = (string)bazaRad.Instance.DohvatiVrijednost("select Prezime, Ime from [Evidencija o zaposlenima];");
            this.lblZaposlenik.Text = zaposlenik;


                      
        }
        /// <summary>
        /// Izracunava sumu cijena
        /// </summary>
        private void izracunaj_sumu()
        {
            int sum = 0;
            for (int i = 0; i < dgvNaruceneStavke.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvNaruceneStavke.Rows[i].Cells[2].Value);
            }
            this.label2.Text = sum.ToString()+" kn";
        }
        /// <summary>
        /// Otvara formu za odabir jela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdaberiJelo_Click(object sender, EventArgs e)
        {
            frmOdabirJela odabir_jela = new frmOdabirJela(this);
            odabir_jela.Show();
        }
        /// <summary>
        /// Otvara formu za odabir pica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdaberiPice_Click(object sender, EventArgs e)
        {
            frmOdabirPica odabir_pica = new frmOdabirPica(this);

            odabir_pica.Show();
        }
        /// <summary>
        /// Otvaraja se forma za upute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void croatianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpute odaberi_upute = new frmUpute();
            odaberi_upute.Show();
        }
        /// <summary>
        /// Brisu se stavke iz popisa odabranih artikala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiStavke_Click(object sender, EventArgs e)
        {
            if (this.dgvNaruceneStavke.SelectedRows.Count > 0)
            {
                dgvNaruceneStavke.Rows.RemoveAt(this.dgvNaruceneStavke.SelectedRows[0].Index);
            }

            izracunaj_sumu();
        }

 

        public int ID_status = 0;
        public bool klik = false;
        /// <summary>
        /// Button za kreiranje narudzbe i spremanje u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNaruci_Click(object sender, EventArgs e)
        {
                     
            klik = true;
            if (klik)
            {
                ID_status = 1;
            }
            narudzba.Datum = datum.Value.ToShortDateString();
            narudzba.Vrijeme = vrijeme.Value.ToShortTimeString();
            narudzba.Zahtjevi_narudzbe = txtZahtjevi_naruzdbe.Text;
            narudzba.FK_ID_stola = Convert.ToInt32(lblStol.Text);
            narudzba.IDStatus = (int)ID_status;           
                      
            narudzba.SpremiNarudzbu();

            object id_narudzbe = bazaRad.Instance.DohvatiVrijednost("select top 1 ID_narudzbe from Narudzba order by ID_narudzbe desc");
            int id=0;
            List<int> prodeni = new List<int>();
            for (int i = 0; i < dgvNaruceneStavke.RowCount-1; i++)
            {
                id = (int)dgvNaruceneStavke.Rows[i].Cells[0].Value;
                bool bilo = false;
                foreach (int a in prodeni)
                {
                    if (a == id) bilo = true;
                }
                if (!bilo)
                {
                    int kolicina = 1;
                    for (int j = i + 1; j < dgvNaruceneStavke.RowCount-1; j++)
                    {
                        if ((int)dgvNaruceneStavke.Rows[j].Cells[0].Value == id) kolicina++;
                    }
                    
                    bazaRad.Instance.Query("insert into [Stavke narudzbe] (FK_ID_narudzbe,FK_ID_artikla, Kolicina) values (" + id_narudzbe + "," + id + ", "+kolicina+")");
                    prodeni.Add(id);
                }
            
        }
            frmPovratnaPoruka povratnaPoruka = new frmPovratnaPoruka();
            const string poruka =
            "Želite li ostaviti povratnu informaciju?";
            const string naslov = "Povratna informacija";
            var result = MessageBox.Show(poruka, naslov,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // Ako odaberemo Yes 
            if (result == DialogResult.Yes)
            {
                
                povratnaPoruka.Show();
            }
            
            
            this.Refresh();
            this.Close();
        }

        private void frmKreiranjeNarudzbeGlavna_Load(object sender, EventArgs e)
        {
            izracunaj_sumu();
        }
        
        /// <summary>
        /// Za popis narucenih stavki racuna koliko je stavki od pojednih artikala naruceno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNaruceneStavke_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string cellValue = null;
            for (int i = 0; i <= this.dgvNaruceneStavke.Rows.Count - 1; i++)
            {
                if (!dgvNaruceneStavke.Rows[i].IsNewRow)
                {
                    cellValue = dgvNaruceneStavke[1, i].Value.ToString();
                    if (!dic.ContainsKey(cellValue))
                    {
                        dic.Add(cellValue, 1);
                    }
                    else
                    {
                        dic[cellValue] += 1;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Naručeno je:");
            foreach (KeyValuePair<string, int> keyvalue in dic)
            {
                sb.AppendLine(string.Format("{0}: {1}", keyvalue.Key, keyvalue.Value));
            }
            lblUniqueProducts.Text = sb.ToString();
            lblTotalProducts.Text = dic.Count.ToString();
            izracunaj_sumu();
        }
        
        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEngUpute instructions = new frmEngUpute();
            instructions.Show();
        }
                     
                    

       
        

     
        
    }
}
