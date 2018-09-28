using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CroMed
{
    public partial class DodajUrediZaposlenika : Form
    {

        public int idZaposlenika = 0;

        public DodajUrediZaposlenika(int id)
        {
            InitializeComponent();
            idZaposlenika = id;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajNovogZaposlenika()
        {
            if (imeTextBox.TextLength == 0 || prezimeTextBox.TextLength == 0 || adresaTextBox.TextLength == 0 || kontaktTextBox.TextLength == 0 || lozinkaTextBox.TextLength == 0 || korisnickoImeTextBox.TextLength == 0)
            {
                MessageBox.Show("Polja ne smiju biti prazna!", "Obavijest");
            }
            else
            {
                if (imeTextBox.TextLength > 30 || prezimeTextBox.TextLength > 30 || kontaktTextBox.TextLength > 45 || adresaTextBox.TextLength > 50 || korisnickoImeTextBox.TextLength > 15 || lozinkaTextBox.TextLength > 15)
                {
                    MessageBox.Show("Polja sadrže previše znakova!" + Environment.NewLine + "Ime - 30, Prezime - 30, Kontakt - 45" + Environment.NewLine + "Adresa - 50, Korisnicko - 15, Lozinka - 15", "Obavijest");
                }
                else
                {
                    using (var db = new CroMedDB_DataEntities())
                    {
                        int korisnickoProvjera = db.Zaposlenik.Where(z => z.KorisnickoIme.Equals(korisnickoImeTextBox.Text)).Count();
                        int lozinkaProvjera = db.Zaposlenik.Where(z => z.Lozinka.Equals(lozinkaTextBox.Text)).Count();

                        if (korisnickoProvjera != 0 || lozinkaProvjera != 0)
                        {
                            MessageBox.Show("Korisnik s istim korisničkim imenom ili lozinkom već postoji", "Obavijest");
                        }
                        else
                        {
                            Zaposlenik noviZaposlenik = new Zaposlenik
                            {
                                Ime = imeTextBox.Text,
                                Prezime = prezimeTextBox.Text,
                                Kontakt = kontaktTextBox.Text,
                                Adresa = adresaTextBox.Text,
                                KorisnickoIme = korisnickoImeTextBox.Text,
                                Lozinka = lozinkaTextBox.Text,
                                RazinaOvlasti = int.Parse((razinaOvlastiComboBox.SelectedIndex + 1).ToString())
                            };

                            db.Zaposlenik.Add(noviZaposlenik);
                            db.SaveChanges();

                            MessageBox.Show("Uspješno dodan novi zaposlenik!", "Obavijest");

                            this.Close();
                        }
                    }
                }
            }
        }

        private void UrediPostojecegZaposlenika()
        {
            if (imeTextBox.TextLength == 0 || prezimeTextBox.TextLength == 0 || adresaTextBox.TextLength == 0 || kontaktTextBox.TextLength == 0 || lozinkaTextBox.TextLength == 0 || korisnickoImeTextBox.TextLength == 0)
            {
                MessageBox.Show("Polja ne smiju biti prazna!", "Obavijest");
            }
            else
            {
                if (imeTextBox.TextLength > 30 || prezimeTextBox.TextLength > 30 || kontaktTextBox.TextLength > 45 || adresaTextBox.TextLength > 50 || korisnickoImeTextBox.TextLength > 15 || lozinkaTextBox.TextLength > 15)
                {
                    MessageBox.Show("Polja sadrže previše znakova!" + Environment.NewLine + "Ime - 30, Prezime - 30, Kontakt - 45" + Environment.NewLine + "Adresa - 50, Korisnicko - 15, Lozinka - 15", "Obavijest");
                }
                else
                {
                    using (var db = new CroMedDB_DataEntities())
                    {
                        string ime = imeTextBox.Text;
                        string prezime = prezimeTextBox.Text;
                        string kontakt = kontaktTextBox.Text;
                        string adresa = adresaTextBox.Text;
                        string korisnicko = korisnickoImeTextBox.Text;
                        string lozinka = lozinkaTextBox.Text;
                        int razina = 0;
                        if (razinaOvlastiComboBox.Text == "Administrator") { razina = 1; }
                        if (razinaOvlastiComboBox.Text == "Moderator") { razina = 2; }
                        if (razinaOvlastiComboBox.Text == "Korisnik") { razina = 3; }


                        db.Database.ExecuteSqlCommand("UPDATE Zaposlenik SET Ime = @p0, Prezime = @p1, Kontakt = @p2, Adresa = @p3, KorisnickoIme = @p4, Lozinka = @p5, RazinaOvlasti = @p6 WHERE Id = @p7", ime, prezime, kontakt, adresa, korisnicko, lozinka, razina, idZaposlenika);
                        db.SaveChanges();

                        MessageBox.Show("Uspješno uređivanje zaposlenika!", "Obavijest");
                        this.Close();

                    }
                }
            }
        }



        private void DodajUrediZaposlenika_Load(object sender, EventArgs e)
        {
            using (var db = new CroMedDB_DataEntities())
            {
                BindingList<RazinaOvlasti> razina = new BindingList<RazinaOvlasti>(db.RazinaOvlasti.ToList());
                razinaOvlastiComboBox.DataSource = razina;
            }

            if (idZaposlenika != 0)
            {
                using (var db = new CroMedDB_DataEntities())
                {

                    Zaposlenik zaposlenikUredivanje = (from z in db.Zaposlenik where z.Id == idZaposlenika select z).FirstOrDefault();
                    idTextBox.Text = zaposlenikUredivanje.Id.ToString();
                    imeTextBox.Text = zaposlenikUredivanje.Ime;
                    prezimeTextBox.Text = zaposlenikUredivanje.Prezime;
                    kontaktTextBox.Text = zaposlenikUredivanje.Kontakt;
                    adresaTextBox.Text = zaposlenikUredivanje.Adresa;
                    korisnickoImeTextBox.Text = zaposlenikUredivanje.KorisnickoIme;
                    lozinkaTextBox.Text = zaposlenikUredivanje.Lozinka;
                    string razina = (from r in db.RazinaOvlasti where r.Id == zaposlenikUredivanje.RazinaOvlasti select r.Naziv).FirstOrDefault().ToString();
                    razinaOvlastiComboBox.Text = razina;
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (idZaposlenika == 0)
            {
                DodajNovogZaposlenika();
            }
            else
            {
                UrediPostojecegZaposlenika();
            }

        }
    }
}
