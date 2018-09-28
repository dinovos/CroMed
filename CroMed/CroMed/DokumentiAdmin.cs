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
 
    public partial class DokumentiAdmin : Form
    {
        public int razinaOvlasti = 0;
        private string korIme;
        public DokumentiAdmin(int razina, string k)
        {
            InitializeComponent();
            razinaOvlasti = razina;
            korIme = k;
        }

        private void DokumentiAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'croMedDB_DataDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.croMedDB_DataDataSet.Zaposlenik);
            osvjeziIspise();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            IzradiDokumentAdmin forma = new IzradiDokumentAdmin(1, korIme);
            forma.ShowDialog();
            osvjeziIspise();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            IzradiDokumentAdmin forma = new IzradiDokumentAdmin(2, korIme);
            forma.ShowDialog();
            osvjeziIspise();
        }

        private void btnPromjena_Click(object sender, EventArgs e)
        {

            if(DokumentiGridView.RowCount == 0)
            {
                MessageBox.Show("Nema dokumenata za uređivanje!", "Obavijest");
            }
            else
            {
                UrediStanjeDokumenta forma = new UrediStanjeDokumenta(int.Parse(DokumentiGridView.CurrentRow.Cells[0].Value.ToString()), korIme);
                forma.ShowDialog();
                osvjeziIspise();
            }

        }



        private void osvjeziIspise()
        {
            this.proizvodiTableAdapter.Fill(this.croMedDB_DataDataSet.Proizvodi);
            this.stavkeDokumentaTableAdapter.Fill(this.croMedDB_DataDataSet.StavkeDokumenta);
            this.poslovniSubjektTableAdapter.Fill(this.croMedDB_DataDataSet.PoslovniSubjekt);
            this.dokumentTableAdapter.Fill(this.croMedDB_DataDataSet.Dokument);
            this.stanjeDokumentaTableAdapter.Fill(this.croMedDB_DataDataSet.StanjeDokumenta);
            this.promjeneStanjaDokumentaTableAdapter.Fill(this.croMedDB_DataDataSet.PromjeneStanjaDokumenta);
        }


    }
}
