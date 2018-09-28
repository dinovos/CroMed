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
    public partial class KategorijeFormaAdmin : Form
    {
        public int razinaOvlasti = 0;
        public KategorijeFormaAdmin(int razina)
        {
            InitializeComponent();
            razinaOvlasti = razina;
        }

        private void OsvjeziIspise()
        {
            using (var db = new CroMedDB_DataEntities())
            {
                BindingList<Kategorija> kategorije = new BindingList<Kategorija>(db.Kategorija.ToList());
                dgvKategorije.DataSource = kategorije;
            }
        }

        private void DodajKategoriju_Click(object sender, EventArgs e)
        {
            DodajKategorijuAdmin forma = new DodajKategorijuAdmin(0);
            forma.ShowDialog();
        }

        private void UrediKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvKategorije.RowCount == 0)
            {
                MessageBox.Show("Nema kategorija za uređivanje", "Obavijest");
            }

            else
            {
                int id = int.Parse(dgvKategorije.SelectedRows[0].Cells[0].Value.ToString());
                DodajKategorijuAdmin forma = new DodajKategorijuAdmin(id);
                forma.ShowDialog();
            }
        }

        private void KategorijeFormaAdmin_Load(object sender, EventArgs e)
        {
            OsvjeziIspise();
        }

        private void KategorijeFormaAdmin_Activated(object sender, EventArgs e)
        {
            OsvjeziIspise();
        }

        private void ObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvKategorije.RowCount == 0)
            {
                MessageBox.Show("Nema kategorija za brisanje", "Obavijest");
            }

            else
            {

                int id = int.Parse(dgvKategorije.SelectedRows[0].Cells[0].Value.ToString());
                if (MessageBox.Show("Da li ste sigurni da želite obrisati odabrano?", "Obavijest", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new CroMedDB_DataEntities())
                    {
                        int brojProizvodaKategorije = db.Proizvodi.Where(p => p.Kategorija == id).Count();

                        if (brojProizvodaKategorije == 0)
                        {
                            Kategorija kategorijaZaBrisanje = db.Kategorija.Where(k => k.Id == id).FirstOrDefault();
                            db.Kategorija.Remove(kategorijaZaBrisanje);
                            db.SaveChanges();

                            OsvjeziIspise();

                            MessageBox.Show("Kategorija uspješno obrisana!", "Obavijest");
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati kategoriju koja sadrži proizvode!", "Obavijest");
                        }

                    }
                }
            }
        }
    }
}





