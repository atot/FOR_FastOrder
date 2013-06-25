using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBHelper;

namespace FOR_Application
{
    class noviZahtjev : bazaRad
    {
        /// <summary>
        /// s ovim SQL upitom testirati cemo ID status, ako je ono vece od 0 onda je to znak da smo zaprimili novu naruzdbu
        /// test cemo osvjezavati uz pomoc tickera (klasa pregledavanje narudzbi)
        /// drugi upit ce nam koristi za auziriranje novog statusa
        /// </summary>
        private string upit = "SELECT COUNT(IDstatus) AS brojNarudzbi, IDstatus FROM Narudzba WHERE IDstatus = 1 GROUP BY IDstatus";
        private string updateString = "UPDATE Narudzba SET IDStatus = 0";
        frmPregledNarudzbi pregled;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Pregled"></param>
        public noviZahtjev(frmPregledNarudzbi Pregled)
        {
            this.pregled = Pregled;
        }

        /// <summary>
        /// metoda kojom cemo ucitavati navedeni upit i koja ce vracat odgovarajucu vrijednost
        /// </summary>
           public int pregledajNoveZahtjeve()
        {
            try
            {
                SqlDataReader reader = QueryReader(upit);
                while (reader.Read())
                {
                    return Convert.ToInt32(reader.GetValue(0));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }

        /// <summary>
        /// metoda kojom updatamo nove zahtjeve ukoliko ih ima
        /// </summary>
        public void updateNoviZahtjevi() {
            QueryReader(updateString);
        }


    }
}

