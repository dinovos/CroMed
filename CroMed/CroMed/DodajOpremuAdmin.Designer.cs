namespace CroMed
{
    partial class DodajOpremuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajOpremuAdmin));
            this.NazivLabela = new System.Windows.Forms.Label();
            this.KategorijaLabela = new System.Windows.Forms.Label();
            this.inputNaziv = new System.Windows.Forms.TextBox();
            this.inputComboKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Spremi = new System.Windows.Forms.Button();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.SerijskiBrojLabela = new System.Windows.Forms.Label();
            this.lblNabavna = new System.Windows.Forms.Label();
            this.lblProdajna = new System.Windows.Forms.Label();
            this.inputNabavna = new System.Windows.Forms.TextBox();
            this.inputProdajna = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.lblStanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivLabela
            // 
            this.NazivLabela.AutoSize = true;
            this.NazivLabela.BackColor = System.Drawing.Color.Transparent;
            this.NazivLabela.Location = new System.Drawing.Point(48, 140);
            this.NazivLabela.Name = "NazivLabela";
            this.NazivLabela.Size = new System.Drawing.Size(40, 13);
            this.NazivLabela.TabIndex = 1;
            this.NazivLabela.Text = "Naziv: ";
            // 
            // KategorijaLabela
            // 
            this.KategorijaLabela.AutoSize = true;
            this.KategorijaLabela.BackColor = System.Drawing.Color.Transparent;
            this.KategorijaLabela.Location = new System.Drawing.Point(48, 179);
            this.KategorijaLabela.Name = "KategorijaLabela";
            this.KategorijaLabela.Size = new System.Drawing.Size(60, 13);
            this.KategorijaLabela.TabIndex = 2;
            this.KategorijaLabela.Text = "Kategorija: ";
            // 
            // inputNaziv
            // 
            this.inputNaziv.Location = new System.Drawing.Point(149, 140);
            this.inputNaziv.Name = "inputNaziv";
            this.inputNaziv.Size = new System.Drawing.Size(151, 20);
            this.inputNaziv.TabIndex = 5;
            // 
            // inputComboKategorija
            // 
            this.inputComboKategorija.DataSource = this.kategorijaBindingSource;
            this.inputComboKategorija.DisplayMember = "Naziv";
            this.inputComboKategorija.FormattingEnabled = true;
            this.inputComboKategorija.Location = new System.Drawing.Point(149, 176);
            this.inputComboKategorija.Name = "inputComboKategorija";
            this.inputComboKategorija.Size = new System.Drawing.Size(151, 21);
            this.inputComboKategorija.TabIndex = 6;
            this.inputComboKategorija.ValueMember = "Id";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = typeof(CroMed.Kategorija);
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(297, 326);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(75, 23);
            this.Spremi.TabIndex = 8;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Enabled = false;
            this.txtSerijskiBroj.Location = new System.Drawing.Point(149, 105);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new System.Drawing.Size(151, 20);
            this.txtSerijskiBroj.TabIndex = 9;
            // 
            // SerijskiBrojLabela
            // 
            this.SerijskiBrojLabela.AutoSize = true;
            this.SerijskiBrojLabela.BackColor = System.Drawing.Color.Transparent;
            this.SerijskiBrojLabela.Location = new System.Drawing.Point(48, 108);
            this.SerijskiBrojLabela.Name = "SerijskiBrojLabela";
            this.SerijskiBrojLabela.Size = new System.Drawing.Size(66, 13);
            this.SerijskiBrojLabela.TabIndex = 10;
            this.SerijskiBrojLabela.Text = "Serijski broj: ";
            // 
            // lblNabavna
            // 
            this.lblNabavna.AutoSize = true;
            this.lblNabavna.BackColor = System.Drawing.Color.Transparent;
            this.lblNabavna.Location = new System.Drawing.Point(48, 221);
            this.lblNabavna.Name = "lblNabavna";
            this.lblNabavna.Size = new System.Drawing.Size(88, 13);
            this.lblNabavna.TabIndex = 11;
            this.lblNabavna.Text = "Nabavna cijena: ";
            // 
            // lblProdajna
            // 
            this.lblProdajna.AutoSize = true;
            this.lblProdajna.BackColor = System.Drawing.Color.Transparent;
            this.lblProdajna.Location = new System.Drawing.Point(48, 257);
            this.lblProdajna.Name = "lblProdajna";
            this.lblProdajna.Size = new System.Drawing.Size(86, 13);
            this.lblProdajna.TabIndex = 13;
            this.lblProdajna.Text = "Prodajna cijena: ";
            // 
            // inputNabavna
            // 
            this.inputNabavna.Location = new System.Drawing.Point(149, 217);
            this.inputNabavna.Name = "inputNabavna";
            this.inputNabavna.Size = new System.Drawing.Size(151, 20);
            this.inputNabavna.TabIndex = 14;
            // 
            // inputProdajna
            // 
            this.inputProdajna.Location = new System.Drawing.Point(149, 252);
            this.inputProdajna.Name = "inputProdajna";
            this.inputProdajna.Size = new System.Drawing.Size(151, 20);
            this.inputProdajna.TabIndex = 15;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 326);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(149, 288);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(151, 20);
            this.txtStanje.TabIndex = 18;
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblStanje.Location = new System.Drawing.Point(48, 293);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(67, 13);
            this.lblStanje.TabIndex = 17;
            this.lblStanje.Text = "Stanje zaliha";
            // 
            // DodajOpremuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.inputProdajna);
            this.Controls.Add(this.inputNabavna);
            this.Controls.Add(this.lblProdajna);
            this.Controls.Add(this.lblNabavna);
            this.Controls.Add(this.SerijskiBrojLabela);
            this.Controls.Add(this.txtSerijskiBroj);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.inputComboKategorija);
            this.Controls.Add(this.inputNaziv);
            this.Controls.Add(this.KategorijaLabela);
            this.Controls.Add(this.NazivLabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajOpremuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj / Uredi opremu";
            this.Load += new System.EventHandler(this.DodajOpremuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NazivLabela;
        private System.Windows.Forms.Label KategorijaLabela;
        private System.Windows.Forms.TextBox inputNaziv;
        private System.Windows.Forms.ComboBox inputComboKategorija;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label SerijskiBrojLabela;
        private System.Windows.Forms.Label lblNabavna;
        private System.Windows.Forms.Label lblProdajna;
        private System.Windows.Forms.TextBox inputNabavna;
        private System.Windows.Forms.TextBox inputProdajna;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.Label lblStanje;
    }
}