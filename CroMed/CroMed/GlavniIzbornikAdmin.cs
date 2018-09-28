using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RazinaOvlasti;

namespace CroMed
{
    public partial class GlavniIzbornik : Form
    {
        public int razinaOvlasti = 0;
        private string korIme;
        public GlavniIzbornik(int razina, string k)
        {
            InitializeComponent();
            timerVrijeme.Start();
            trenutnoVrijemeLabela.Text = DateTime.Now.ToLongTimeString();
            razinaOvlasti = razina;
            korIme = k;
        }

        private void PravaPristupa()
        {
            if (razinaOvlasti == 2)
            {
                ButtonZaposlenici.Enabled = false;
            }

            if (razinaOvlasti == 3)
            {
                dgvObavijesti.Visible = false;
                ButtonZaposlenici.Enabled = false;
                ButtonKategorije.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForma Login = new LoginForma();
            Login.ShowDialog();

            this.Close();
        }

        private void timerVrijeme_Tick(object sender, EventArgs e)
        {
            trenutnoVrijemeLabela.Text = DateTime.Now.ToLongTimeString();
        }

        private void ButtonOprema_Click(object sender, EventArgs e)
        {
            OpremaFormaAdmin forma = new OpremaFormaAdmin(razinaOvlasti);
            forma.ShowDialog();
        }

        private void ButtonKategorije_Click(object sender, EventArgs e)
        {
            KategorijeFormaAdmin forma = new KategorijeFormaAdmin(razinaOvlasti);
            forma.ShowDialog();
        }

        private void ButtonZaposlenici_Click(object sender, EventArgs e)
        {
            ZaposleniciFormaAdmin forma = new ZaposleniciFormaAdmin(razinaOvlasti);
            forma.ShowDialog();
        }

        private void ButtonNarudzbe_Click(object sender, EventArgs e)
        {
            DokumentiAdmin forma = new DokumentiAdmin(razinaOvlasti, korIme);
            forma.ShowDialog();
        }

        private void ButtonDobavljaci_Click(object sender, EventArgs e)
        {
            PoslovniSubjektiAdmin forma = new PoslovniSubjektiAdmin(razinaOvlasti);
            forma.ShowDialog();
        }

        private void ObavijestZalihe()
        {
            using (var db = new CroMedDB_DataEntities())
            {
                BindingList<Proizvodi> proizvodi = new BindingList<Proizvodi>(db.Proizvodi.Where(d => d.StanjeZaliha < 10).ToList());
                dgvObavijesti.DataSource = proizvodi;
            }
        }

        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {
            PravaPristupa();
            ObavijestZalihe();

            Razine razina = new Razine();
            lblOvlasti.Text = razina.VratiRazinuOvlasti(razinaOvlasti);
        }

        private void GlavniIzbornik_Activated(object sender, EventArgs e)
        {
            ObavijestZalihe();
        }
    }
}
