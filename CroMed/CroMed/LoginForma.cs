using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CroMed
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
            inputKorisnickoIme.Focus();
        }

        private void IzlazButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrijavaBezProvjere()
        {
            this.Hide();
            GlavniIzbornik formaGlavniIzbornik = new GlavniIzbornik(1, "");
            formaGlavniIzbornik.ShowDialog();
            this.Close();
        }

        private void ProvjeraKorisnika()
        {
            string korisnickoIme = inputKorisnickoIme.Text;
            string lozinka = inputLozinka.Text;
            
            if(korisnickoIme == "" || lozinka == "")
            {
                MessageBox.Show("Polja korisničko ime i lozinka ne smiju biti prazni!", "Obavijest");
            }
            else
            {

                using(var db = new CroMedDB_DataEntities())
                {
                    int idKorisnicko = (from z in db.Zaposlenik where z.KorisnickoIme == korisnickoIme select z).Count();
                    int idLozinka = (from z in db.Zaposlenik where z.Lozinka == lozinka select z).Count();

                    var korisnik = db.Zaposlenik.Where(c => c.KorisnickoIme == korisnickoIme).FirstOrDefault();
                    var korisnik1 = db.Zaposlenik.Where(c => c.Lozinka == lozinka).FirstOrDefault();


                    if(idKorisnicko != 0 && idLozinka != 0 && korisnik.Id == korisnik1.Id)
                    {
                        this.Hide();
                        int razina = int.Parse(korisnik.RazinaOvlasti.ToString());
                        GlavniIzbornik formaGlavniIzbornik = new GlavniIzbornik(razina, korisnickoIme);
                        formaGlavniIzbornik.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Neispravni podaci za prijavu!", "Obavijest");
                        inputKorisnickoIme.Clear();
                        inputLozinka.Clear();
                        inputKorisnickoIme.Focus();
                    }
                }
            }

            

        }
        private void PrijavaButton_Click(object sender, EventArgs e)
        {
            //PrijavaBezProvjere();
            ProvjeraKorisnika();
        }
    }
}
