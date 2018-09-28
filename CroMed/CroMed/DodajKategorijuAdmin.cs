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
    public partial class DodajKategorijuAdmin : Form
    {
        public int idKategorije = 0;
        public DodajKategorijuAdmin(int id)
        {
            InitializeComponent();
            idKategorije = id;
        }

        private void DodajNovuKategoriju()
        {
            if(inputNaziKategorije.TextLength == 0 || inputOpisKategorije.TextLength == 0)
            {
                MessageBox.Show("Polja naziv i opis kategorije ne smiju biti prazna!", "Obavijest");
            }
            else
            {
                if(inputNaziKategorije.TextLength > 45 || inputOpisKategorije.TextLength == 0)
                {
                    MessageBox.Show("Neispravan unos! Predugi zapisi u poljima!", "Obavijest");
                }
                else
                {
                    string naziv = inputNaziKategorije.Text;
                    string opis = inputOpisKategorije.Text;

                    using(var db = new CroMedDB_DataEntities())
                    {
                        Kategorija novaKategorija = new Kategorija
                        {
                            Naziv = naziv, 
                            Opis = opis
                        };

                        db.Kategorija.Add(novaKategorija);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Nova kategorija uspješno dodana", "Obavijest");
                    this.Close();
                }
            }
        }

        private void UrediKategoriju()
        {
            if (inputNaziKategorije.TextLength == 0 || inputOpisKategorije.TextLength == 0)
            {
                MessageBox.Show("Polja naziv i opis kategorije ne smiju biti prazna!", "Obavijest");
            }
            else
            {
                if (inputNaziKategorije.TextLength > 45 || inputOpisKategorije.TextLength == 0)
                {
                    MessageBox.Show("Neispravan unos! Predugi zapisi u poljima!", "Obavijest");
                }
                else
                {
                    string naziv = inputNaziKategorije.Text;
                    string opis = inputOpisKategorije.Text;

                    using (var db = new CroMedDB_DataEntities())
                    {

                        db.Database.ExecuteSqlCommand("UPDATE Kategorija SET Naziv = @p0, Opis = @p1 WHERE Id = @p2", naziv, opis, idKategorije);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Kategorija uspješno uređena", "Obavijest");
                    this.Close();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajKategorijuAdmin_Load(object sender, EventArgs e)
        {
            if (idKategorije != 0)
            {
                using (var db = new CroMedDB_DataEntities())
                {
                    Kategorija kategorijaUredivanje = (from k in db.Kategorija where k.Id == idKategorije select k).FirstOrDefault();
                    inputIDKategorije.Text = kategorijaUredivanje.Id.ToString();
                    inputNaziKategorije.Text = kategorijaUredivanje.Naziv;
                    inputOpisKategorije.Text = kategorijaUredivanje.Opis;
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(idKategorije == 0)
            {
                DodajNovuKategoriju();
            }
            else
            {
                UrediKategoriju();
            }
        }
    }
}
