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
    public partial class DodajOpremuAdmin : Form
    {
        public int idProizvoda { get; set; }

        public DodajOpremuAdmin()
        {
            InitializeComponent();
            idProizvoda = 0;
        }

        public DodajOpremuAdmin(int id)
        {
            InitializeComponent();
            idProizvoda = id;
        }

        private void DodajOpremuAdmin_Load(object sender, EventArgs e)
        {
            using (var db = new CroMedDB_DataEntities())
            {
                BindingList<Kategorija> k = new BindingList<Kategorija>(db.Kategorija.ToList());
                inputComboKategorija.DataSource = k;

                if (idProizvoda != 0)
                {
                    Proizvodi p = (from pr in db.Proizvodi where pr.Id == idProizvoda select pr).FirstOrDefault();
                    //txtSerijskiBroj.Enabled = true;
                    txtSerijskiBroj.Text = p.Id.ToString();
                    inputNaziv.Text = p.Naziv;
                    inputComboKategorija.Text = p.Kategorija1.Naziv;
                    inputNabavna.Text = p.NabavnaCijena.HasValue ? p.NabavnaCijena.Value.ToString("0.00") : "0.00";
                    inputProdajna.Text = p.ProdajnaCijena.HasValue ? p.ProdajnaCijena.Value.ToString("0.00") : "0.00";
                    txtStanje.Text = p.StanjeZaliha.ToString();
                }
            }

        }


        private void Spremi_Click(object sender, EventArgs e)
        {
            double nabavna, prodajna;
            int stanje;
            if (double.TryParse(inputNabavna.Text, out nabavna) && double.TryParse(inputProdajna.Text, out prodajna) && int.TryParse(txtStanje.Text, out stanje))
            {
                using (var db = new CroMedDB_DataEntities())
                {
                    if (idProizvoda == 0)
                    {
                        Kategorija k = inputComboKategorija.SelectedItem as Kategorija;
                        Proizvodi p = new Proizvodi
                        {
                            Naziv = inputNaziv.Text,
                            Kategorija = k.Id,
                            NabavnaCijena = nabavna,
                            ProdajnaCijena = prodajna,
                            StanjeZaliha = stanje
                        };
                        db.Proizvodi.Add(p);
                        db.SaveChanges();
                    }
                    else
                    {
                        Proizvodi p = (from pr in db.Proizvodi where pr.Id == idProizvoda select pr).First();
                        p.Id = int.Parse(txtSerijskiBroj.Text);
                        p.Naziv = inputNaziv.Text;
                        Kategorija k = inputComboKategorija.SelectedItem as Kategorija;
                        p.Kategorija = k.Id;
                        p.NabavnaCijena = nabavna;
                        p.ProdajnaCijena = prodajna;
                        p.StanjeZaliha = stanje;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Uspješno ste dodali opremu!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Pogrešan unos!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
