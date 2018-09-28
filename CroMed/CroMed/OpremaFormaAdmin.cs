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
    public partial class OpremaFormaAdmin : Form
    {
        public int razinaOvlasti = 0;
        public OpremaFormaAdmin(int razina)
        {
            InitializeComponent();
            razinaOvlasti = razina;
        }

        private void PravaPristupa()
        {
            if (razinaOvlasti == 3)
            {
                obrisiOpremuButton.Enabled = false;
                urediOpremuButton.Enabled = false;
            }
        }

        private void DodajOpremuButton_Click(object sender, EventArgs e)
        {
            DodajOpremuAdmin forma = new DodajOpremuAdmin();
            forma.ShowDialog();
            PrikaziKategorije();
            PrikaziProizvode(SortirajOpremuCombo.SelectedItem as Kategorija);
        }

        private void UrediOpremuButton_Click(object sender, EventArgs e)
        {
            if (OpremaGridView.RowCount == 0)
            {
                MessageBox.Show("Nema opreme za uređivanje", "Obavijest");
            }

            else
            {
                int id;
                if (int.TryParse(OpremaGridView.CurrentRow.Cells[0].Value.ToString(), out id))
                {
                    DodajOpremuAdmin forma = new DodajOpremuAdmin(id);
                    forma.ShowDialog();
                    PrikaziKategorije();
                    PrikaziProizvode(SortirajOpremuCombo.SelectedItem as Kategorija);
                }
            }
        }

        private void OpremaFormaAdmin_Load(object sender, EventArgs e)
        {
            PravaPristupa();
            PrikaziKategorije();
            PrikaziProizvode(SortirajOpremuCombo.SelectedItem as Kategorija);
        }

 


        private void SortirajOpremuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziProizvode(SortirajOpremuCombo.SelectedItem as Kategorija);
        }

        private void obrisiOpremuButton_Click(object sender, EventArgs e)
        {
            if (OpremaGridView.RowCount == 0)
            {
                MessageBox.Show("Nema opreme za brisanje", "Obavijest");
            }

            else
            {
                Proizvodi proizvod = proizvodiBindingSource.Current as Proizvodi;
                if (proizvod != null)
                {
                    if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new CroMedDB_DataEntities())
                        {
                            db.Proizvodi.Attach(proizvod);
                            if (proizvod.StanjeZaliha == 0)
                            {
                                db.Proizvodi.Remove(proizvod);
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Nije moguće obrisati proizvod kojeg postoji na zalihi!");
                            }
                        }
                        PrikaziProizvode(SortirajOpremuCombo.SelectedItem as Kategorija);
                    }
                }
            }
        }

        private void PrikaziKategorije()
        {
            BindingList<Kategorija> listaKategorija = null;
            using (var db = new CroMedDB_DataEntities())
            {
                listaKategorija = new BindingList<Kategorija>(db.Kategorija.ToList());
            }
            kategorijaBindingSource.DataSource = listaKategorija;
        }


        private void PrikaziProizvode(Kategorija kat)
        {
            BindingList<Proizvodi> listaProizvoda = null;
            using (var db = new CroMedDB_DataEntities())
            {
                db.Kategorija.Attach(kat);
                listaProizvoda = new BindingList<Proizvodi>(kat.Proizvodi.ToList<Proizvodi>());
            }
            proizvodiBindingSource.DataSource = listaProizvoda;
        }

    }

}
