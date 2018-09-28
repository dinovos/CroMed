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
    public partial class PoslovniSubjektiAdmin : Form
    {
        public int razinaOvlasti = 0;
        public PoslovniSubjektiAdmin(int razina)
        {
            InitializeComponent();
            razinaOvlasti = razina;
        }

        private void PravaPristupa()
        {
            if (razinaOvlasti == 3)
            {
                DodajPoslovniSubjekt.Enabled = false;
                UrediPoslovniSubjekt.Enabled = false;
                IzbrisiPoslovniSubjekt.Enabled = false;
            }
        }

        private void OsvjeziIspise()
        {
            using (var db = new CroMedDB_DataEntities())
            {
                string vrsta = cmbVrstaSubjekta.Text;

                if (vrsta == "Svi")
                {
                    BindingList<PoslovniSubjekt> poslovniSubjekti = new BindingList<PoslovniSubjekt>(db.PoslovniSubjekt.ToList());
                    dgvPoslovniSubjekti.DataSource = poslovniSubjekti;
                }

                if (vrsta == "Dobavljač")
                {
                    BindingList<PoslovniSubjekt> poslovniSubjekti = new BindingList<PoslovniSubjekt>(db.PoslovniSubjekt.Where(d => d.VrstaSubjekta == 1).ToList());
                    dgvPoslovniSubjekti.DataSource = poslovniSubjekti;
                }

                if (vrsta == "Kupac")
                {
                    BindingList<PoslovniSubjekt> poslovniSubjekti = new BindingList<PoslovniSubjekt>(db.PoslovniSubjekt.Where(d => d.VrstaSubjekta == 2).ToList());
                    dgvPoslovniSubjekti.DataSource = poslovniSubjekti;
                }
            }
        }

        private void DodajDobavljaca_Click(object sender, EventArgs e)
        {
            DodajUrediPoslovniSubjekt forma = new DodajUrediPoslovniSubjekt(0);
            forma.ShowDialog();
        }

        private void UrediDobavljaca_Click(object sender, EventArgs e)
        {
            if (dgvPoslovniSubjekti.RowCount == 0)
            {
                MessageBox.Show("Nema poslovnih subjekata za brisanje", "Obavijest");
            }

            else
            {
                int id = int.Parse(dgvPoslovniSubjekti.SelectedRows[0].Cells[0].Value.ToString());
                DodajUrediPoslovniSubjekt forma = new DodajUrediPoslovniSubjekt(id);
                forma.ShowDialog();
            }
        }

        private void PoslovniSubjektiAdmin_Load(object sender, EventArgs e)
        {
            PravaPristupa();

            using(var db = new CroMedDB_DataEntities())
            {
                BindingList<PoslovniSubjekt> poslovniSubjekti = new BindingList<PoslovniSubjekt>(db.PoslovniSubjekt.ToList());
                dgvPoslovniSubjekti.DataSource = poslovniSubjekti;

                BindingList<VrstaSubjekta> vrsta = new BindingList<VrstaSubjekta>(db.VrstaSubjekta.ToList());
                VrstaSubjekta novi = new VrstaSubjekta();
                novi.Opis = "Svi";
                vrsta.Add(novi);
                cmbVrstaSubjekta.DataSource = vrsta;

            }
        }

        private void cmbVrstaSubjekta_SelectedValueChanged(object sender, EventArgs e)
        {
            OsvjeziIspise();
        }

        private void IzbrisiDobavljaca_Click(object sender, EventArgs e)
        {
            if(dgvPoslovniSubjekti.RowCount == 0)
            {
                MessageBox.Show("Nema poslovnih subjekata za brisanje", "Obavijest");
            }

            else
            {
                int id = int.Parse(dgvPoslovniSubjekti.SelectedRows[0].Cells[0].Value.ToString());
                if (MessageBox.Show("Da li ste sigurni da želite obrisati odabrano?", "Obavijest", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    using (var db = new CroMedDB_DataEntities())
                    {
                        PoslovniSubjekt poslovniZaObrisati = db.PoslovniSubjekt.Where(p => p.Id == id).FirstOrDefault();
                        db.PoslovniSubjekt.Remove(poslovniZaObrisati);
                        db.SaveChanges();

                        OsvjeziIspise();

                        MessageBox.Show("Poslovni subjekt uspješno obrisan!", "Obavijest");
                    }
                }
            }

        }

        private void PoslovniSubjektiAdmin_Activated(object sender, EventArgs e)
        {
            OsvjeziIspise();
        }
    }
}
