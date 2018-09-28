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
    public partial class ZaposleniciFormaAdmin : Form
    {
        public int razinaOvlasti = 0;
        public ZaposleniciFormaAdmin(int razina)
        {
            InitializeComponent();
            razinaOvlasti = razina;
        }

        private void OsvjeziZaposlenike()
        {
            using (var db = new CroMedDB_DataEntities())
            {
                BindingList<Zaposlenik> zaposlenici = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());
                zaposlenikBindingSource.DataSource = zaposlenici;

                BindingList<RazinaOvlasti> razina = new BindingList<RazinaOvlasti>(db.RazinaOvlasti.ToList());
                razinaOvlastiBindingSource.DataSource = razina;
            }
        }
        private void DodajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajUrediZaposlenika forma = new DodajUrediZaposlenika(0);
            forma.ShowDialog();
        }

        private void UrediZaposlenika_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ZaposleniciGridView.SelectedRows[0].Cells[0].Value.ToString());

            using (var db = new CroMedDB_DataEntities())
            {
                int brojZaposlenikaPremaOvlasti = (from z in db.Zaposlenik where z.RazinaOvlasti == 1 select z).Count();
                if (brojZaposlenikaPremaOvlasti == 1)
                {
                    MessageBox.Show("Nije moguće urediti zaposlenika, zbog mogućeg gubitka administratorskih prava!", "Obavijest");
                }
                else
                {
                    DodajUrediZaposlenika forma = new DodajUrediZaposlenika(id);
                    forma.ShowDialog();
                }
            }
        }

        private void ZaposleniciFormaAdmin_Load(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }

        private void IzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ZaposleniciGridView.SelectedRows[0].Cells[0].Value.ToString());

            using (var db = new CroMedDB_DataEntities())
            {
                int brojZaposlenikaPremaOvlasti = (from z in db.Zaposlenik where z.RazinaOvlasti == 1 select z).Count();
                if (brojZaposlenikaPremaOvlasti == 1)
                {
                    MessageBox.Show("Nije moguće obrisati zaposlenika, zbog gubitka administratorskih prava!", "Obavijest");
                }
                else
                {
                    if (MessageBox.Show("Da li ste sigurni da želite obrisati odabrano?", "Obavijest", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        db.Database.ExecuteSqlCommand("DELETE FROM Zaposlenik WHERE Id = @p0", id);
                        db.SaveChanges();


                        MessageBox.Show("Zaposlenik uspješno obrisan!", "Obavijest");

                        OsvjeziZaposlenike();
                    }
                }

            }
        }

        private void ZaposleniciFormaAdmin_Activated(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }
    }
}
