using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CroMed
{
    public partial class DodajUrediPoslovniSubjekt : Form
    {
        public int idSubjekta = 0;
        public DodajUrediPoslovniSubjekt(int id)
        {
            InitializeComponent();
            idSubjekta = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajUrediPoslovniSubjekt_Load(object sender, EventArgs e)
        {
            using (var db = new CroMedDB_DataEntities())
            {
                    BindingList<VrstaSubjekta> vrsta = new BindingList<VrstaSubjekta>(db.VrstaSubjekta.ToList());
                    vrstaSubjektaComboBox.DataSource = vrsta;             
            }


            if (idSubjekta != 0)
            {
                using (var db = new CroMedDB_DataEntities())
                {
                    PoslovniSubjekt subjekt = (from s in db.PoslovniSubjekt where s.Id == idSubjekta select s).FirstOrDefault();
                    idTextBox.Text = subjekt.Id.ToString();
                    nazivTextBox.Text = subjekt.Naziv;
                    kontaktTextBox.Text = subjekt.Kontakt;
                    adresaTextBox.Text = subjekt.Adresa;
                    string vrsta = (from v in db.VrstaSubjekta where v.Id == subjekt.VrstaSubjekta select v.Opis).FirstOrDefault().ToString();
                    vrstaSubjektaComboBox.Text = vrsta;
                    oIBTextBox.Text = subjekt.OIB;
                }
            }
        }

        private void DodajNoviSubjekt()
        {
            if (nazivTextBox.TextLength == 0 || kontaktTextBox.TextLength == 0 || adresaTextBox.TextLength == 0 || oIBTextBox.TextLength == 0)
            {
                MessageBox.Show("Polja ne smiju biti prazna!", "Obavijest");
            }
            else
            {
                if (nazivTextBox.TextLength > 45 || kontaktTextBox.TextLength > 45 || adresaTextBox.TextLength > 45 || oIBTextBox.TextLength > 15)
                {
                    MessageBox.Show("Neispravan unos! Predugački zapisi u poljima!", "Obavijest");
                }

                else
                {
                    string naziv = nazivTextBox.Text;
                    string kontakt = kontaktTextBox.Text;
                    string adresa = adresaTextBox.Text;
                    int vrsta = int.Parse(vrstaSubjektaComboBox.SelectedValue.ToString());
                    string oib = oIBTextBox.Text;

                    Regex sadrziSlova = new Regex(@"\D");
                    if (sadrziSlova.IsMatch(oib))
                    {
                        MessageBox.Show("Polje OIB može sadržavati samo brojeve!", "Obavijest");
                    }
                    else
                    {
                        using (var db = new CroMedDB_DataEntities())
                        {

                            int oibprovjera = db.PoslovniSubjekt.Where(p => p.OIB.Equals(oib)).Count();

                            if (oibprovjera == 0)
                            {
                                PoslovniSubjekt noviPoslovni = new PoslovniSubjekt()
                                {
                                    Naziv = naziv,
                                    Kontakt = kontakt,
                                    Adresa = adresa,
                                    VrstaSubjekta = vrsta,
                                    OIB = oib
                                };

                                db.PoslovniSubjekt.Add(noviPoslovni);
                                db.SaveChanges();

                                MessageBox.Show("Novi poslovni subjekt uspješno dodan", "Obavijest");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Poslovni subjekt s istim OIB-om već postoji!", "Obavijest");
                            }

                        }

                    }

                }
            }
        }


        private void UrediPostojeciSubjekt()
        {
            if (nazivTextBox.TextLength == 0 || kontaktTextBox.TextLength == 0 || adresaTextBox.TextLength == 0 || oIBTextBox.TextLength == 0)
            {
                MessageBox.Show("Polja ne smiju biti prazna!", "Obavijest");
            }
            else
            {
                if (nazivTextBox.TextLength > 45 || kontaktTextBox.TextLength > 45 || adresaTextBox.TextLength > 45 || oIBTextBox.TextLength > 15)
                {
                    MessageBox.Show("Neispravan unos! Predugački zapisi u poljima!", "Obavijest");
                }

                else
                {
                    string naziv = nazivTextBox.Text;
                    string kontakt = kontaktTextBox.Text;
                    string adresa = adresaTextBox.Text;
                    int vrsta = int.Parse(vrstaSubjektaComboBox.SelectedValue.ToString());
                    string oib = oIBTextBox.Text;

                    Regex sadrziSlova = new Regex(@"\D");
                    if (sadrziSlova.IsMatch(oib))
                    {
                        MessageBox.Show("Polje OIB može sadržavati samo brojeve!", "Obavijest");
                    }
                    else
                    {
                        using (var db = new CroMedDB_DataEntities())
                        {
                            db.Database.ExecuteSqlCommand("UPDATE PoslovniSubjekt SET Naziv = @p0, Kontakt = @p1, Adresa = @p2, VrstaSubjekta = @p3, OIB = @p4 WHERE Id = @p5", naziv, kontakt, adresa, vrsta, oib, idSubjekta);
                            db.SaveChanges();
                        }

                        MessageBox.Show("Poslovni subjekt uspješno uređen", "Obavijest");

                        this.Close();
                    }
                }

            }
        }



        private void Spremi_Click(object sender, EventArgs e)
        {
            if (idSubjekta == 0)
            {
                DodajNoviSubjekt();
            }
            else
            {
                UrediPostojeciSubjekt();
            }

        }

    }
}

