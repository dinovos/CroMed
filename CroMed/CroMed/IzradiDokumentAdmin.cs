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
    public partial class IzradiDokumentAdmin : Form
    {
        private int vrsta;
        private int idDokumenta;
        private List<string> listaStavki;
        private string korIme;
        public IzradiDokumentAdmin(int vr, string k)
        {
            InitializeComponent();
            vrsta = vr;
            listaStavki = new List<string>();
            korIme = k;
        }

        private void IzradiDokumentAdmin_Load(object sender, EventArgs e)
        {
            if (vrsta == 2)
            {
                txtRabat.Enabled = true;
            }
            using (var db = new CroMedDB_DataEntities())
            {
                inputSubjektCombo.DataSource = (from p in db.PoslovniSubjekt where p.VrstaSubjekta == vrsta select p).ToList<PoslovniSubjekt>();

                BindingList<Proizvodi> listaProizvoda = new BindingList<Proizvodi>(db.Proizvodi.ToList());
                inputArtiklCombo.DataSource = listaProizvoda;
            }
        }

        private void UnesiDokument_Click(object sender, EventArgs e)
        {
            using (var db = new CroMedDB_DataEntities())
            {
                PoslovniSubjekt s = inputSubjektCombo.SelectedItem as PoslovniSubjekt;
                Dokument d = new Dokument
                {
                    PoslovniSubjekt = s.Id
                };
                    db.Dokument.Add(d);
                    db.SaveChanges();
                    idDokumenta = d.Id;
            }
         }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            int rabat, kolicina;
            if (int.TryParse(inputKolicina.Text, out kolicina))
            {
                if (vrsta == 1)
                {
                    rabat = 0; //narudžba
                }
                else
                {
                    rabat = int.Parse(txtRabat.Text); //račun
                }

                using (var db = new CroMedDB_DataEntities())
                {
                    Proizvodi p = inputArtiklCombo.SelectedItem as Proizvodi;
                    if (p.StanjeZaliha < kolicina && vrsta == 2)
                    {
                        MessageBox.Show("Nedostatna količina odabranog proizvoda na zalihi!");
                    }
                    else if (p.StanjeZaliha > kolicina || vrsta == 1)
                    {
                        StavkeDokumenta stavka = new StavkeDokumenta
                        {
                            Dokument = idDokumenta,
                            Proizvod = p.Id,
                            Kolicina = kolicina,
                            Rabat = rabat
                        };
                        db.StavkeDokumenta.Add(stavka);
                        if (vrsta == 2)
                        {
                            db.Proizvodi.Attach(p);
                            p.StanjeZaliha -= kolicina;
                        }
                        db.SaveChanges();
                        listaStavki.Add(p.Naziv + " - " + stavka.Kolicina);
                        StavkeDokumentaListBox.DataSource = null;
                        StavkeDokumentaListBox.DataSource = listaStavki;
                    }

                }
            }
            else
            {
                MessageBox.Show("Pogresan unos!");
            }
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            //promjene stanja
            using (var db = new CroMedDB_DataEntities())
            {
                Proizvodi p = inputArtiklCombo.SelectedItem as Proizvodi;
                Zaposlenik z = db.Zaposlenik.Where(b => b.KorisnickoIme == korIme).FirstOrDefault();
                PromjeneStanjaDokumenta promjena = new PromjeneStanjaDokumenta
                {
                    Dokument = idDokumenta,
                    DatumPromjene = DateTime.Parse(inputDatum.Text),
                    Napomena = "",
                    StanjeDokumenta = 1, //otvoreno
                    Zaposlenik = z.Id
                };
                db.PromjeneStanjaDokumenta.Add(promjena);
                db.SaveChanges();
            }
            listaStavki = null;
            MessageBox.Show("Uspješno ste izradili dokument!");
            this.Close();
        }
    }
}
