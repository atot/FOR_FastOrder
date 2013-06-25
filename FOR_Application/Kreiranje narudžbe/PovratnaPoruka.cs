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
    public partial class frmPovratnaPoruka : Form
    {
        public frmPovratnaPoruka()
        {
            InitializeComponent();
            
        }
        
        private void btnPošaljiPoruku_Click(object sender, EventArgs e)
        {
            //object id_narudzbe = bazaRad.Instance.DohvatiVrijednost("select top 1 ID_narudzbe from Narudzba order by ID_narudzbe desc");
            object id_narudzbe = bazaRad.Instance.DohvatiVrijednost("Exec VratiIdNarudzbe3");
            bazaRad.Instance.Query("insert into [Povratna informacija] (Opis,FK_ID_narudzbe) values ('" + this.txtPovratnaPoruka.Text + "',"+ id_narudzbe+")");
            
            this.Close();
        }
    }
}
