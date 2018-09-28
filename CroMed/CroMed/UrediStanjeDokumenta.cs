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
    public partial class UrediStanjeDokumenta : Form
    {
        private int idDokumenta;
        private string korIme;
        public UrediStanjeDokumenta(int id, string k)
        {
            InitializeComponent();
            idDokumenta = id;
            korIme = k;
        }



        private void UrediStanjeDokumenta_Load(object sender, EventArgs e)
        {
            using (var db = new CroMedDB_DataEntities())
            {
                BindingList<StanjeDokumenta> listaStanja = new BindingList<StanjeDokumenta>(db.StanjeDokumenta.ToList());
                comboStanje.DataSource = listaStanja;
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            using (var db = new CroMedDB_DataEntities())
            {
                StanjeDokumenta s = comboStanje.SelectedItem as StanjeDokumenta;
                Zaposlenik z = db.Zaposlenik.Where(b => b.KorisnickoIme == korIme).FirstOrDefault(); 
                PromjeneStanjaDokumenta promjena = new PromjeneStanjaDokumenta
                {
                    Dokument = idDokumenta,
                    DatumPromjene = DateTime.Parse(inputDatum.Text),
                    Napomena = txtNapomena.Text,
                    StanjeDokumenta = s.Id,
                    Zaposlenik = z.Id
                };
                db.PromjeneStanjaDokumenta.Add(promjena);
                db.SaveChanges();
            }
            this.Close();

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
